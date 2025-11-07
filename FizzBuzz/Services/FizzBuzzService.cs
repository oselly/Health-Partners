using FizzBuzz.Models.Interfaces;
using FizzBuzz.Services.Interfaces;
using System.Data;

namespace FizzBuzz.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        /// <summary>
        /// Checks to see if any rules match the current number in the range, if so returns the corresponding text, otherwise retruns the number as a string.
        /// </summary>
        /// <param name="rules"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
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
