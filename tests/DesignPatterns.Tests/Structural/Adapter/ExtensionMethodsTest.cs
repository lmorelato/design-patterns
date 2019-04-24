using Bogus;
using DesignPatterns.Structural.Adapter;
using FluentAssertions;
using Xunit;

namespace DesignPatterns.Tests.Structural.Adapter
{
    public class ExtensionMethodsTest : BaseTest
    {
        [Fact]
        public void Area_RectangleObject_ReturnsArea()
        {
            // Arrange
            var rectangle = new Faker<Rectangle>()
                .CustomInstantiator(f => 
                    new Rectangle(
                        f.Random.Int(1, 10), 
                        f.Random.Int(1, 10)))
                .Generate();

            var expectedResult = rectangle.Width * rectangle.Height;

            // Act
            var result = rectangle.Area();

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}