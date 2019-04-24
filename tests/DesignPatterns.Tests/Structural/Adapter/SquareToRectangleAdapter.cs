using Bogus;

using DesignPatterns.Structural.Adapter;

using FluentAssertions;
using Xunit;

namespace DesignPatterns.Tests.Structural.Adapter
{
    public class SquareToRectangleAdapterTest : BaseTest
    {
        [Fact]
        public void SquareToRectangleAdapter_SquareObject_CreatesRectangle()
        {
            // Arrange
            var square = new Faker<Square>()
                .RuleFor(f => f.Side, f => f.Random.Int(1, 10))
                .Generate();

            // Act
            var result = new SquareToRectangleAdapter(square);

            // Assert
            result.Height.Should().Be(square.Side);
            result.Width.Should().Be(square.Side);
        }
    }
}