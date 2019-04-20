using DesignPatterns.Creational.Factory.Exercises;

using FluentAssertions;

using Xunit;

namespace DesignPatterns.Tests.Creational.Factory.Exercises
{
    public class AnyPersonTest : BaseTest
    {
        [Fact]
        public void Create_ValidName_NewPerson()
        {
            // Arrange
            var personOneName = this.Faker.Name.FullName();
            var personTwoName = this.Faker.Name.FullName();

            // Act
            var personOne = AnyPerson.Factory.Create(personOneName);
            var personTwo = AnyPerson.Factory.Create(personTwoName);

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