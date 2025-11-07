using FizzBuzz.Services;

namespace FizzBuzzApp.Tests
{
    [TestFixture]
    public class FizzBuzzServiceTests
    {
        private FizzBuzzService _fizzBuzzService;

        [SetUp]
        public void Setup()
        {
            _fizzBuzzService = new FizzBuzzService();
        }

        [Test]
        public void Returns_Fizz_When_Number_Divisible_By_3()
        {
            var result = _fizzBuzzService.GetFizzBuzzSequence(3, 3).Single();
            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void Returns_Buzz_When_Number_Divisible_By_5()
        {
            var result = _fizzBuzzService.GetFizzBuzzSequence(5, 5).Single();
            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void Returns_FizzBuzz_When_Number_Divisible_By_3_And_5()
        {
            var result = _fizzBuzzService.GetFizzBuzzSequence(15, 15).Single();
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void Returns_Number_When_Not_Divisible_By_3_Or_5()
        {
            var result = _fizzBuzzService.GetFizzBuzzSequence(2, 2).Single();
            Assert.That(result, Is.EqualTo("2"));
        }

        [Test]
        public void Generates_100_Results_For_Range_1_To_100()
        {
            var results = _fizzBuzzService.GetFizzBuzzSequence(1, 100).ToList();
            Assert.That(results.Count, Is.EqualTo(100));
        }
    }
}
