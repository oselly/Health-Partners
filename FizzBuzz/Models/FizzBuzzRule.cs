using FizzBuzz.Models.Interfaces;

namespace FizzBuzz.Models
{
    public class FizzBuzzRule : IRule
    {
        public bool IsMatch(int value) => value % 3 == 0 && value % 5 == 0;
        public string TextToDisplay() => "FizzBuzz";
    }
}
