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
        private readonly HttpClient _httpClient;

        public PalavraService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> ObterPalavraAleatoria()
        {
            // Carrega o arquivo JSON do wwwroot
            var response = await _httpClient.GetStringAsync("palavras.json");
            var palavras = JsonSerializer.Deserialize<Palavras>(response);

            // Seleciona uma palavra aleatória
            var random = new Random();
            int index = random.Next(palavras.ListaPalavras.Count);
            return palavras.ListaPalavras[index];
        }
    }

    public class Palavras
    {
        public List<string>? ListaPalavras { get; set; }
    }
}
