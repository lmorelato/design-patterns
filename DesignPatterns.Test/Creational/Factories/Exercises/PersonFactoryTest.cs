using DesignPatterns.Code.Creational.Factories.Exercises;

using FluentAssertions;

using Xunit;

namespace DesignPatterns.Test.Creational.Factories.Exercises
{
    public class PersonFactoryTest : BaseTest
    {
        [Fact]
        public void Create_ValidName_NewPerson()
        {
            // Arrange
            var factory = new PersonFactory();
            var personOneName = this.Faker.Name.FullName();
            var personTwoName = this.Faker.Name.FullName();

            // Act
            var personOne = factory.Create(personOneName);
            var personTwo = factory.Create(personTwoName);

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