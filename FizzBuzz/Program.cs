using FizzBuzz.Services;
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
                    services.AddScoped<FizzBuzzService>();
                    services.AddScoped<FizzBuzzApp>();
                })
                .Build();

            var app = host.Services.GetRequiredService<FizzBuzzApp>();
            app.Run();
        }
    }


    public class FizzBuzzApp(FizzBuzzService fizzBuzzService)
    {
        public void Run()
        {
            var results = fizzBuzzService.GetFizzBuzzSequence(1, 100);
            foreach (var result in results)
                Console.WriteLine(result);
        }
    }

}