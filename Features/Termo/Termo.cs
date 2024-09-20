namespace BlazorDantas.Features
{
    public class TermoGame
    {
        public string PalavraCorreta { get; private set; }
        public int TentativasRestantes { get; private set; }
        public bool JogoFinalizado { get; private set; }
        public List<Tentativa> Historico { get; private set; }

        public TermoGame(string palavraCorreta)
        {
            PalavraCorreta = palavraCorreta.ToLower();
            TentativasRestantes = 6;
            JogoFinalizado = false;
            Historico = new List<Tentativa>();
        }

        public Tentativa VerificarTentativa(string tentativa)
        {
            if (JogoFinalizado || TentativasRestantes == 0)
            {
                throw new InvalidOperationException("O jogo já terminou.");
            }

            tentativa = tentativa.ToLower();
            var tentativaResultado = new Tentativa(tentativa);

            for (int i = 0; i < tentativa.Length; i++)
            {
                if (PalavraCorreta[i] == tentativa[i])
                {
                    tentativaResultado.Resultado[i] = LetraResultado.Correta;
                }
                else if (PalavraCorreta.Contains(tentativa[i]))
                {
                    tentativaResultado.Resultado[i] = LetraResultado.LugarErrado;
                }
                else
                {
                    tentativaResultado.Resultado[i] = LetraResultado.Incorreta;
                }
            }

            Historico.Add(tentativaResultado);
            TentativasRestantes--;

            if (tentativa == PalavraCorreta)
            {
                JogoFinalizado = true;
            }
            else if (TentativasRestantes == 0)
            {
                JogoFinalizado = true;
            }

            return tentativaResultado;
        }
    }

    public class Tentativa
    {
        public string Palavra { get; private set; }
        public LetraResultado[] Resultado { get; private set; }

        public Tentativa(string palavra)
        {
            Palavra = palavra;
            Resultado = new LetraResultado[palavra.Length];
        }
    }

    public enum LetraResultado
    {
        Correta,
        LugarErrado,
        Incorreta
    }
}

