using AutoBogus;
using GenericInference.Service;
using NUnit.Framework;
using Moq;
using Prime.Services;

namespace GenericInference.Services.Tests
{
    [TestFixture, NonParallelizable]
    public class GenericInferenceServiceTests
    {
        [Test]
        public void IsGenericInferenceNonVirtualTest()
        {
            var inputString = AutoFaker.Create().Generate<string>();
            var expected = string.Format("{0} what the input in a non-virtual is Prime.", inputString);

            var primeServiceMock = new Mock<PrimeService>() { CallBase = true };

            primeServiceMock.Setup(x => x.IsPrimeNonVirtual(It.IsAny<string>())).Returns(expected);

            var _inferenceService = new GenericInferenceService<PrimeService>(primeServiceMock.Object);

            var actual = _inferenceService.IsGenericInferenceNonVirtual(inputString);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsGenericInferenceVirtualTest()
        {
            var inputString = AutoFaker.Create().Generate<string>();
            var expected = string.Format("{0} what the input in a virtual is Prime.", inputString);

            var primeServiceMock = new Mock<PrimeService>();
            primeServiceMock.Setup(x => x.IsPrimeVirtual(It.IsAny<string>())).Returns(expected);

            var _inferenceService = new GenericInferenceService<PrimeService>(primeServiceMock.Object);

            var actual = _inferenceService.IsGenericInferenceVirtual(inputString);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}