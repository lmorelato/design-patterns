using DesignPatterns.Structural.Bridge;

using FakeItEasy;

using FluentAssertions;

using Xunit;

namespace DesignPatterns.Tests.Structural.Bridge
{
    public class SquareTest : BaseTest
    {
        [Fact]
        public void Square_AnyIRenderer_ReturnsToString()
        {
            // Arrange
            var fakeRenderer = A.Fake<IRenderer>();
            A.CallTo(() => fakeRenderer.WhatToRenderAs)
                .Returns(this.Faker.Random.Word());

            var shape = new Square(fakeRenderer);
            var expectedResult = fakeRenderer.WhatToRenderAs;

            // Act
            var result = shape.ToString();

            // Assert
            result.Should()
                .Contain(expectedResult)
                .And.ContainEquivalentOf(shape.GetType().Name);
        }
    }
}