using BlazorDantas;
using BlazorDantas.Features;
using BlazorDantas.Features.Termo;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<GeradorCPF>();
builder.Services.AddScoped<TermoGame>();
builder.Services.AddScoped<PalavraService>();

await builder.Build().RunAsync();
