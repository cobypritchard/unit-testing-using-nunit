using AutoBogus;
using GenericInference.Service;
using NUnit.Framework;
using Moq;
using Prime.Services;

namespace GenericInference.Services.Tests
{
    public class GenericInferenceServiceTests
    {
        private Mock<PrimeService>? _primeServiceMock;
        private GenericInferenceService<PrimeService>? _genericInferenceService;

        [SetUp]
        public void Setup()
        {
            // Create a mock of the prime service
            _primeServiceMock = new Mock<PrimeService>();

            // Create an instance of the generic inference service using the mock object
            _genericInferenceService = new GenericInferenceService<PrimeService>(_primeServiceMock.Object);
        }

        [Test]
        public void IsGenericInferenceNonVirtual_ReturnsCorrectResult()
        {
            // Arrange
            var inputString = AutoFaker.Create().Generate<string>();
            var expected = string.Format("{0} what the input in a non-virtual is Prime.", inputString);
            _primeServiceMock!.Setup(x => x.IsPrimeNonVirtual(It.IsAny<string>())).Returns(expected);

            // Act
            var actual = _genericInferenceService!.IsGenericInferenceNonVirtual(inputString);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsGenericInferenceVirtual_ReturnsCorrectResult()
        {
            // Arrange
            var inputString = AutoFaker.Create().Generate<string>();
            var expected = string.Format("{0} what the input in a virtual is Prime.", inputString);
            _primeServiceMock!.Setup(x => x.IsPrimeVirtual(It.IsAny<string>())).Returns(expected);

            // Act
            var actual = _genericInferenceService!.IsGenericInferenceVirtual(inputString);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}