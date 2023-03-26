using AutoBogus;
using NUnit.Framework;

namespace Prime.Services.Tests
{
    [TestFixture, NonParallelizable]
    public class IntServiceTests
    {
        [Test]
        public void IsIntNonVirtualTest()
        {
            var inputString = AutoFaker.Create().Generate<string>();
            var expected = string.Format("{0} what the input in a non-virtual is Int.", inputString);

            var _intService = new IntService();

            var actual = _intService.IsIntNonVirtual(inputString);

            Assert.That(actual, Is.EqualTo(expected));
        }
        
        [Test]
        public void IsPrimeNonVirtualTest()
        {
            var inputString = AutoFaker.Create().Generate<string>();
            var expected = string.Format("{0} what the input in a non-virtual is Prime(Int).", inputString);

            var _intService = new IntService();

            var actual = _intService.IsPrimeNonVirtual(inputString);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsPrimeVirtualTest()
        {
            var inputString = AutoFaker.Create().Generate<string>();
            var expected = string.Format("{0} what the input in a virtual is Prime(Int).", inputString);

            var _intService = new IntService();

            var actual = _intService.IsPrimeVirtual(inputString);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}