using DesignPatterns.Creational.Factory;

using FluentAssertions;

using Xunit;

namespace DesignPatterns.Tests.Creational.Factory
{
    public class HumanFactoryTest : BaseTest
    {
        [Fact]
        public void Create_ValidName_NewHuman()
        {
            // Arrange
            var personOneName = this.Faker.Name.FullName();
            var personTwoName = this.Faker.Name.FullName();

            // Act
            var personOne = HumanFactory.Create(personOneName);
            var personTwo = HumanFactory.Create(personTwoName);

            // Assert
            personOne.Should().NotBeNull();
            personOne.Id.Should().BeGreaterThan(0);
            personOne.Name.Should().NotBeNullOrWhiteSpace().And.Be(personOneName);

            personTwo.Should().NotBeNull();
            personTwo.Id.Should().BeGreaterThan(1);
            personTwo.Name.Should().NotBeNullOrWhiteSpace().And.Be(personTwoName);
        }
    }
}