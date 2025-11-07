namespace FizzBuzz.Services
{
    public class FizzBuzzService
    {
        public IEnumerable<string> GetFizzBuzzSequence(int start, int end)
        {
            var results = new List<string>();

            for (int i = start; i <= end; i++)
            {
                if (i % 15 == 0)
                    results.Add("FizzBuzz");
                else if (i % 3 == 0)
                    results.Add("Fizz");
                else if (i % 5 == 0)
                    results.Add("Buzz");
                else
                    results.Add(i.ToString());
            }

            return results;
        }
    }
}
