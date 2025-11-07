using FizzBuzz.Models.Interfaces;
using FizzBuzz.Services.Interfaces;
using System.Data;

namespace FizzBuzz.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public IEnumerable<string> GetFizzBuzzSequence(IEnumerable<IRule> rules, int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                string? result = null;

                foreach (var rule in rules)
                {
                    if (rule.IsMatch(i))
                    {
                        result = rule.TextToDisplay();
                        break;
                    }
                }

                yield return result ?? i.ToString();
            }
        }
    }
}
