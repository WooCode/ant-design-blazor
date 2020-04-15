using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Append.AntDesign.Services;

namespace Append.AntDesign.Documentation.Standalone
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddBaseAddressHttpClient();
            builder.Services.AddSingleton<IIconService, IconService>();
            builder.Services.AddSingleton<GitHubService>();

            await builder.Build().RunAsync();
        }
    }
}
