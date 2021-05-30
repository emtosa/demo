using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using SuperFunctionApp;

[assembly: FunctionsStartup(typeof(Startup))]
namespace SuperFunctionApp
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddTransient<IHitchhikerGuideToTheGalaxy, HitchhikerGuideToTheGalaxy>();
            builder.Services.AddTransient<ISuperComputer, SuperComputer>();
        }
    }
}
