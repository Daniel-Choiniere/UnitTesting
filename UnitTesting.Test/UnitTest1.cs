using NUnit.Framework;

namespace UnitTesting.Test
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var sut = new Calculator();

            int result = sut.AddNumbers(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }
    }
}