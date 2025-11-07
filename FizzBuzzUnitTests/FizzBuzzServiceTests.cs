using FizzBuzz.Models;
using FizzBuzz.Models.Interfaces;
using FizzBuzz.Services;

namespace FizzBuzzApp.Tests
{
    [TestFixture]
    public class FizzBuzzServiceTests
    {
        private FizzBuzzService _fizzBuzzService;
        private IEnumerable<IRule> _rules;

        [SetUp]
        public void Setup()
        {
            _fizzBuzzService = new FizzBuzzService();
            _rules = [new FizzBuzzRule(), new FizzRule(), new BuzzRule()];
        }

        /// <summary>
        /// Checks to see if a number divisible by 3 returns "Fizz"
        /// </summary>
        [Test]
        public void Returns_Fizz_When_Number_Divisible_By_3()
        {
            var result = _fizzBuzzService.GetFizzBuzzSequence(_rules, 3, 3).Single();
            Assert.That(result, Is.EqualTo("Fizz"));
        }

        /// <summary>
        /// Checks to see if a number divisible by 5 returns "Buzz"
        /// </summary>
        [Test]
        public void Returns_Buzz_When_Number_Divisible_By_5()
        {
            var result = _fizzBuzzService.GetFizzBuzzSequence(_rules, 5, 5).Single();
            Assert.That(result, Is.EqualTo("Buzz"));
        }

        /// <summary>
        /// Checks to see if a number divisible by both 3 and 5 returns "FizzBuzz"
        /// </summary>
        [Test]
        public void Returns_FizzBuzz_When_Number_Divisible_By_3_And_5()
        {
            var result = _fizzBuzzService.GetFizzBuzzSequence(_rules, 15, 15).Single();
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        /// <summary>
        /// Checks to see if a number not divisible by either 3 or 5 returns the number as a string
        /// </summary>
        [Test]
        public void Returns_Number_When_Not_Divisible_By_3_Or_5()
        {
            var result = _fizzBuzzService.GetFizzBuzzSequence(_rules, 2, 2).Single();
            Assert.That(result, Is.EqualTo("2"));
        }

        /// <summary>
        /// Checks to see if the correct number of results are generated for the range 1 to 100
        /// </summary>
        [Test]
        public void Generates_100_Results_For_Range_1_To_100()
        {
            var results = _fizzBuzzService.GetFizzBuzzSequence(_rules, 1, 100).ToList();
            Assert.That(results.Count, Is.EqualTo(100));
        }
    }
}
