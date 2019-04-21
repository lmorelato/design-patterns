using Bogus;

using DesignPatterns.Creational.Prototype;

using FluentAssertions;

using Xunit;

namespace DesignPatterns.Tests.Creational.Prototype
{
    public class PointTest : BaseTest
    {
        [Fact]
        public void DeepClone_WhenCalled_ClonedObject()
        {
            // Arrange
            var expectedResult = new Faker<Point>()
                .RuleForType(typeof(int), f => f.Random.Int(1, 10))
                .Generate();

            // Act
            var result = expectedResult.DeepCopy();

            // Assert
            result.X.Should().Be(expectedResult.X);
            result.Y.Should().Be(expectedResult.Y);
        }
    }
}