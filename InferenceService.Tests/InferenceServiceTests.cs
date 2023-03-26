using AutoBogus;
using Inference.Service;
using NUnit.Framework;
using Moq;
using Prime.Services;

namespace Inference.Services.Tests
{
    public class InferenceServiceTests
    {
        private Mock<IPrimeService>? _primeServiceMock;
        private InferenceService? _inferenceService;

        [SetUp]
        public void Setup()
        {
            _primeServiceMock = new Mock<IPrimeService>();
            _inferenceService = new InferenceService(_primeServiceMock.Object);
        }

        [Test]
        public void IsInferenceNonVirtual_ReturnsCorrectResult()
        {
            // Arrange
            var inputString = AutoFaker.Create().Generate<string>();
            var expected = string.Format("{0} what the input in a non-virtual is Prime.", inputString);
            _primeServiceMock!.Setup(x => x.IsPrimeNonVirtual(It.IsAny<string>())).Returns(expected);

            // Act
            var actual = _inferenceService!.IsInferenceNonVirtual(inputString);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsInferenceVirtual_ReturnsCorrectResult()
        {
            // Arrange
            var inputString = AutoFaker.Create().Generate<string>();
            var expected = string.Format("{0} what the input in a virtual is Prime.", inputString);
            _primeServiceMock!.Setup(x => x.IsPrimeVirtual(It.IsAny<string>())).Returns(expected);

            // Act
            var actual = _inferenceService!.IsInferenceVirtual(inputString);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}