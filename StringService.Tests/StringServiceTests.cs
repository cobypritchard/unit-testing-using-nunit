using AutoBogus;
using NUnit.Framework;

namespace String.Services.Tests
{
    public class StringServiceTests
    {
        private StringServiceImplementation? _stringServiceImplementation;

        [SetUp]
        public void Setup()
        {
            _stringServiceImplementation = new StringServiceImplementation();
        }

        [Test]
        public void IsStringAbstract_MustBeImplementedBySubclass()
        {
            // Arrange
            var inputString = AutoFaker.Create().Generate<string>();
            var expected = string.Format("{0} what the input in a abstract is String.", inputString);

            // Act
            var actual =_stringServiceImplementation!.IsStringAbstract(inputString);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsStringNonVirtual_ReturnsCorrectResult()
        {
            // Arrange
            var inputString = AutoFaker.Create().Generate<string>();
            var expected = string.Format("{0} what the input in a non-virtual is String.", inputString);

            // Act
            var actual = _stringServiceImplementation!.IsStringNonVirtual(inputString);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsStringVirtual_ReturnsCorrectResult()
        {
            // Arrange
            var inputString = AutoFaker.Create().Generate<string>();
            var expected = string.Format("{0} what the input in a virtual is String.", inputString);

            // Act
            var actual = _stringServiceImplementation!.IsStringVirtual(inputString);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }

    public class StringServiceImplementation : StringService
    {
        public override string IsStringAbstract(string candidate)
        {
            return  string.Format("{0} what the input in a abstract is String.", candidate);
        }
    }
}
