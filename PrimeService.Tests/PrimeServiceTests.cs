using AutoBogus;
using NUnit.Framework;

namespace Prime.Services.Tests
{
    [TestFixture, NonParallelizable]
    public class PrimeServiceTests
    {
        [Test]
        public void IsPrimeNonVirtualTest()
        {
            var inputString = AutoFaker.Create().Generate<string>();
            var expected = string.Format("{0} what the input in a non-virtual is Prime.", inputString);

            var _primeService = new PrimeService();

            var actual = _primeService.IsPrimeNonVirtual(inputString);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsPrimeVirtualTest()
        {
            var inputString = AutoFaker.Create().Generate<string>();
            var expected = string.Format("{0} what the input in a virtual is Prime.", inputString);

            var _primeService = new PrimeService();

            var actual = _primeService.IsPrimeVirtual(inputString);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}