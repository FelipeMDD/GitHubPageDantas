namespace BlazorDantas.Features
{
    public class GeradorCPF
    {
        public string GerarCpfValido()
        {
            Random random = new Random();
            int[] cpf = new int[9];

            for (int i = 0; i < 9; i++)
            {
                cpf[i] = random.Next(0, 9);
            }

            int primeiroDigito = CalcularDigitoVerificador(cpf, new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2 });
            int segundoDigito = CalcularDigitoVerificador(cpf.Concat(new int[] { primeiroDigito }).ToArray(), new int[] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 });

            return string.Join("", cpf) + primeiroDigito + segundoDigito;
        }

        private int CalcularDigitoVerificador(int[] cpf, int[] pesos)
        {
            int soma = cpf.Zip(pesos, (d, p) => d * p).Sum();
            int resto = soma % 11;
            return resto < 2 ? 0 : 11 - resto;
        }
    }
}
