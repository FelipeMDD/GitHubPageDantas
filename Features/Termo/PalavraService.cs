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
            var palavrasCincoLetras = new List<string>
                {
                    "acaso", "achar", "adiar", "ainda", "ajuda", "aliar", "amigo", "andar", "anexo", "antes", "apelo",
                    "apito", "areia", "aroma", "assim", "astro", "atomo", "atual", "autor", "aviso", "beber", "bicho",
                    "blusa", "bolsa", "brasa", "braço", "briga", "burro", "cabra", "cacho", "caixa", "caldo", "calma",
                    "campo", "canoa", "capaz", "carta", "carro", "casal", "casas", "ceder", "cenho", "certo", "cesta",
                    "chato", "cheio", "chuva", "claro", "clima", "cobra", "coisa", "conta", "corpo", "cravo", "credo",
                    "criar", "culpa", "curva", "dados", "dança", "dedos", "deixa", "desde", "deste", "dever", "diabo",
                    "dizer", "dobro", "doido", "dores", "douto", "droga", "duplo", "elite", "enfim", "entra", "entre",
                    "errar", "essas", "esses", "estar", "etapa", "exame", "exato", "extra", "falar", "falta", "fases",
                    "feliz", "feroz", "ferro", "feudo", "final", "firme", "fluir", "força", "fraco", "frase", "frito",
                    "fruta", "fugir", "furto", "galho", "ganho", "garra", "gasto", "gente", "gesso", "globo", "graça",
                    "grato", "grupo", "guiaa", "humor", "ideia", "igual", "impor", "indio", "inves", "irado", "janela",
                    "jeito", "junto", "largo", "lento", "leque", "leste", "levar", "livro", "lugar", "luzes", "macro",
                    "magro", "manso", "massa", "matar", "medir", "meiga", "melar", "membro", "mesmo", "metal", "moeda",
                    "monta", "moral", "motivo", "mudar", "muito", "mural", "museu", "nadar", "navio", "nobre", "noite",
                    "norte", "nossa", "novos", "nuvem", "obrar", "odiar", "ontem", "outra", "ouvir", "padre", "pagar",
                    "palma", "parte", "passo", "pauta", "pegar", "penso", "perda", "piano", "pilar", "pingo", "pinta",
                    "pista", "poder", "porta", "prato", "preto", "pular", "puxar", "raiva", "rasgo", "rasto", "reino",
                    "risco", "ritmo", "rodar", "rosto", "roubo", "saber", "salao", "salto", "santo", "seara", "selar",
                    "senso", "serao", "sexta", "sigla", "sinal", "sitio", "sobre", "sonho", "sorte", "subir", "talha",
                    "tarde", "tenso", "terra", "tempo", "texto", "tinha", "tocar", "tonto", "torre", "traga", "trago",
                    "trama", "trato", "treta", "troca", "unido", "untar", "urgir", "vacas", "vazio", "velho", "verde",
                    "verbo", "vezes", "visto", "viver", "volta", "votar", "xicar", "zelar", "termo"
                };


            var random = new Random();
            int index = random.Next(palavrasCincoLetras.Count);
            var palavraAleatoria = palavrasCincoLetras[index];

            return  palavraAleatoria;
        }

    }
}
