using FizzBuzz.Models;
using FizzBuzz.Models.Interfaces;
using FizzBuzz.Services;
using FizzBuzz.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FizzBuzzApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using var host = Host.CreateDefaultBuilder(args)
                .ConfigureServices((context, services) =>
                {
                    services.AddScoped<IRule, FizzRule>();
                    services.AddScoped<IRule, BuzzRule>();
                    services.AddScoped<IRule, FizzBuzzRule>();
                    services.AddScoped<IFizzBuzzService, FizzBuzzService>();
                    services.AddScoped<FizzBuzzApp>();
                })
                .Build();

            var app = host.Services.GetRequiredService<FizzBuzzApp>();
            app.Run();
        }
    }


    public class FizzBuzzApp(IFizzBuzzService fizzBuzzService, IEnumerable<IRule> rules)
    {
        public void Run()
        {
            var results = fizzBuzzService.GetFizzBuzzSequence(rules, 1, 100);
            foreach (var result in results)
                Console.WriteLine(result);
        }
    }

}