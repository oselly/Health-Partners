namespace FizzBuzz.Models.Interfaces
{
    public interface IRule
    {
        bool IsMatch(int number);
        string TextToDisplay();
    }
}
