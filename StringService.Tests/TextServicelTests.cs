using AutoBogus;
using NUnit.Framework;

namespace String.Services.Tests
{
    public class TextServiceTests
    {
        private TextService? _textService;

        [SetUp]
        public void Setup()
        {
            _textService = new TextService();
        }

        [Test]
        public void IsStringAbstract_ReturnsCorrectResult()
        {
            // Arrange
            var inputString = AutoFaker.Create().Generate<string>();
            var expected = string.Format("{0} what the input in a abstract is String(Text).", inputString);

            // Act
            var actual = _textService!.IsStringAbstract(inputString);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsStringNonVirtual_ReturnsCorrectResult()
        {
            // Arrange
            var inputString = AutoFaker.Create().Generate<string>();
            var expected = string.Format("{0} what the input in a non-virtual is String(Text).", inputString);

            // Act
            var actual = _textService!.IsStringNonVirtual(inputString);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsStringVirtual_ReturnsCorrectResult()
        {
            // Arrange
            var inputString = AutoFaker.Create().Generate<string>();
            var expected = string.Format("{0} what the input in a virtual is String(Text).", inputString);

            // Act
            var actual = _textService!.IsStringVirtual(inputString);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}