using AutoBogus;
using NUnit.Framework;

namespace Generic.Service.Tests
{
    public class GenericServiceTests
    {
        private GenericService<string>? _stringService;
        private GenericService<int>? _intService;

        [SetUp]
        public void Setup()
        {
            _stringService = new GenericService<string>();
            _intService = new GenericService<int>();
        }

        [Test]
        public void IsGenericNonVirtual_ReturnsCorrectResult_ForString()
        {
            // Arrange
            string inputString = AutoFaker.Create().Generate<string>();
            var expected = string.Format("{0} what the input in a non-virtual is Generic({1}).", inputString, typeof(string));

            // Act
            var actual = _stringService!.IsGenericNonVirtual(inputString);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsGenericVirtual_ReturnsCorrectResult_ForString()
        {
            // Arrange
            var inputString = AutoFaker.Create().Generate<string>();
            var expected = string.Format("{0} what the input in a virtual is Generic({1}).", inputString, typeof(string));

            // Act
            var actual = _stringService!.IsGenericVirtual(inputString);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsGenericNonVirtual_ReturnsCorrectResult_ForInt()
        {
            // Arrange
            var inputInt = AutoFaker.Create().Generate<int>();
            var expected = string.Format("{0} what the input in a non-virtual is Generic({1}).", inputInt, typeof(int));

            // Act
            var actual = _intService!.IsGenericNonVirtual(inputInt);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsGenericVirtual_ReturnsCorrectResult_ForInt()
        {
            // Arrange
            var inputInt = AutoFaker.Create().Generate<int>();
            var expected = string.Format("{0} what the input in a virtual is Generic({1}).", inputInt, typeof(int));

            // Act
            var actual = _intService!.IsGenericVirtual(inputInt);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}