using FizzBuzz.Models.Interfaces;

namespace FizzBuzz.Services.Interfaces
{
    public interface IFizzBuzzService
    {
        IEnumerable<string> GetFizzBuzzSequence(IEnumerable<IRule> rules, int start, int end);
    }
}
