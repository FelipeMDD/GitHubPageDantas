using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace BlazorDantas.Features.Termo
{
    public class PalavraService
    {
        public async Task<string> ObterPalavraAleatoria()
        {
            // Caminho relativo ao local do binário
            var caminhoArquivo = Path.Combine(AppContext.BaseDirectory, "Features", "Termo", "ListaPalavras.json");

            // Certifique-se de que o arquivo existe
            if (File.Exists(caminhoArquivo))
            {
                // Ler o arquivo diretamente do sistema de arquivos
                var jsonString = await File.ReadAllTextAsync(caminhoArquivo);
                var palavras = JsonSerializer.Deserialize<Palavras>(jsonString);

                // Seleciona uma palavra aleatória
                var random = new Random();
                int index = random.Next(palavras.ListaPalavras.Count);
                return palavras.ListaPalavras[index];
            }
            else
            {
                throw new FileNotFoundException("O arquivo ListaPalavras.json não foi encontrado.");
            }
        }
    }

    public class Palavras
    {
        public List<string> ListaPalavras { get; set; }
    }
}
