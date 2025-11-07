using FizzBuzz.Models.Interfaces;

namespace FizzBuzz.Models
{
    public class BuzzRule : IRule
    {
        public bool IsMatch(int value) => value % 5 == 0 && value % 3 != 0;
        public string TextToDisplay() => "Buzz";
    }
}
