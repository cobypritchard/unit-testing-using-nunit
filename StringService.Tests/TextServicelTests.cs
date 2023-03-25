using AutoBogus;
using Bogus;
using NUnit.Framework;
using String.Services;

namespace String.UnitTests.Services
{
    [TestFixture]
    public class TextServiceTests
    {
        [Test]
        public void IsStringAbstractTest()
        {
            var inputString = new Faker().Internet.DomainName();
            var expected = string.Format("{0} what the input in a abstract Is String(Text).", inputString);

            var _textService = new TextService();

            var actual = _textService.IsStringAbstract(inputString);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsStringNonVirtualTest()
        {
            var inputString = new Faker().Internet.DomainName();
            var expected = string.Format("{0} what the input in a non-virtual Is String(Text).", inputString);

            var _textService = new TextService();

            var actual = _textService.IsStringNonVirtual(inputString);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsStringVirtualTest()
        {
            var inputString = new Faker().Internet.DomainName();
            var expected = string.Format("{0} what the input in a virtual Is String(Text).", inputString);

            var _textService = new TextService();

            var actual = _textService.IsStringVirtual(inputString);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}