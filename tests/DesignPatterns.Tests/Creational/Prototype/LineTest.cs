using Bogus;

using DesignPatterns.Creational.Prototype;

using FluentAssertions;

using Xunit;

namespace DesignPatterns.Tests.Creational.Prototype
{
    public class LineTest : BaseTest
    {
        [Fact]
        public void DeepClone_WhenCalled_ClonedObject()
        {
            // Arrange
            var fakerPoint = new Faker<Point>()
                .RuleForType(typeof(int), f => f.Random.Int(1, 10));

            var fakerLine = new Faker<Line>()
                .RuleFor(r => r.Start, fakerPoint.Generate())
                .RuleFor(r => r.End, fakerPoint.Generate());

            var expectedResult = fakerLine.Generate();
            
            // Act
            var result = expectedResult.DeepCopy();

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}