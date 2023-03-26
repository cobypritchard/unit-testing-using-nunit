using AutoBogus;
using Inference.Service;
using NUnit.Framework;
using Moq;
using Prime.Services;

namespace Inference.Services.Tests
{
    [TestFixture, NonParallelizable]
    public class InferenceServiceTests
    {
        [Test]
        public void IsInferenceNonVirtualTest()
        {
            var inputString = AutoFaker.Create().Generate<string>();

            var primeServiceMock = new Mock<IPrimeService>();
            primeServiceMock.Setup(x => x.IsPrimeNonVirtual(It.IsAny<string>())).Returns(inputString);

            var expected = string.Format("{0} what the input in a non-virtual is Prime.", inputString);

            var _inferenceService = new InferenceService(primeServiceMock.Object);

            var actual = _inferenceService.IsInferenceNonVirtual(inputString);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsInferenceVirtualTest()
        {
            var inputString = AutoFaker.Create().Generate<string>();

            var primeServiceMock = new Mock<IPrimeService>();
            primeServiceMock.Setup(x => x.IsPrimeVirtual(It.IsAny<string>())).Returns(inputString);

            var expected = string.Format("{0} what the input in a virtual is Prime.", inputString);

            var _inferenceService = new InferenceService(primeServiceMock.Object);

            var actual = _inferenceService.IsInferenceVirtual(inputString);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}