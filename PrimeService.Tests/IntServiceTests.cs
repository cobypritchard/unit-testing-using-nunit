using AutoBogus;
using NUnit.Framework;

namespace Prime.Services.Tests
{
    public class IntServiceTests
    {
        private IntService? _intService;

        [SetUp]
        public void Setup()
        {
            _intService = new IntService();
        }

        [Test]
        public void IsIntNonVirtual_ReturnsCorrectResult()
        {
            // Arrange
            var inputString = AutoFaker.Create().Generate<string>();
            var expected = string.Format("{0} what the input in a non-virtual is Int.", inputString);

            // Act
            var actual = _intService!.IsIntNonVirtual(inputString);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        
        [Test]
        public void IsPrimeNonVirtual_ReturnsCorrectResult()
        {
            // Arrange
            var inputString = AutoFaker.Create().Generate<string>();
            var expected = string.Format("{0} what the input in a non-virtual is Prime(Int).", inputString);

            // Act
            var actual = _intService!.IsPrimeNonVirtual(inputString);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsPrimeVirtual_ReturnsCorrectResult()
        {
            // Arrange
            var inputString = AutoFaker.Create().Generate<string>();
            var expected = string.Format("{0} what the input in a virtual is Prime(Int).", inputString);

            // Act
            var actual = _intService!.IsPrimeVirtual(inputString);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}