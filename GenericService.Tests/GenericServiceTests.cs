using AutoBogus;
using Moq;
using NUnit.Framework;
using Prime.Services;

namespace Generic.Service.Tests
{
    [TestFixture, NonParallelizable]
    public class GenericServiceTests
    {
        [Test]
        public void IsPrimeNonVirtualTest_String()
        {
            string inputString = AutoFaker.Create().Generate<string>();
            var expected = string.Format("{0} what the input in a non-virtual is Generic({1}).", inputString, typeof(string));

            var _genericService = new GenericService<string>();

            var actual = _genericService.IsGenericNonVirtual(inputString);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsPrimeVirtualTest_String()
        {
            var inputString = AutoFaker.Create().Generate<string>();
            var expected = string.Format("{0} what the input in a virtual is Generic({1}).", inputString, typeof(string));

            var _genericService = new GenericService<string>();

            var actual = _genericService.IsGenericVirtual(inputString);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsPrimeNonVirtualTest_Int()
        {
            var inputInt = AutoFaker.Create().Generate<int>();
            var expected = string.Format("{0} what the input in a non-virtual is Generic({1}).", inputInt, typeof(int));

            var _genericService = new GenericService<int>();

            var actual = _genericService.IsGenericNonVirtual(inputInt);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsPrimeVirtualTest_Int()
        {
            var inputInt = AutoFaker.Create().Generate<int>();
            var expected = string.Format("{0} what the input in a virtual is Generic({1}).", inputInt, typeof(int));

            var _genericService = new GenericService<int>();

            var actual = _genericService.IsGenericVirtual(inputInt);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}