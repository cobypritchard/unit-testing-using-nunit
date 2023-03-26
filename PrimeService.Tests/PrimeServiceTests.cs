using AutoBogus;
using NUnit.Framework;

namespace Prime.Services.Tests
{
    public class PrimeServiceTests
    {
        private PrimeService? _primeService;

        [SetUp]
        public void Setup()
        {
            _primeService = new PrimeService();
        }

        [Test]
        public void IsPrimeNonVirtual_ReturnsCorrectResult()
        {
            // Arrange
            var inputString = AutoFaker.Create().Generate<string>();
            var expected = string.Format("{0} what the input in a non-virtual is Prime.", inputString);

            // Act
            var actual = _primeService!.IsPrimeNonVirtual(inputString);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsPrimeVirtual_ReturnsCorrectResult()
        {
            // Arrange
            var inputString = AutoFaker.Create().Generate<string>();
            var expected = string.Format("{0} what the input in a virtual is Prime.", inputString);

            // Act
            var actual = _primeService!.IsPrimeVirtual(inputString);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}