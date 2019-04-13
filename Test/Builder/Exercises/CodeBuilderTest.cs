using DesignPatterns.Builder.Exercises;
using FluentAssertions;
using NFluent;
using Shouldly;
using Xunit;

namespace Test.Builder.Exercises
{
    public class CodeBuilderTest
    {
        [Fact]
        public void AddField_ValidField_CodeBuilder()
        {
            // Arrange
            var builder = new CodeBuilder("Person")
                .AddField("Name", "string")
                .AddField("Age", "int");

            // Act
            var result = builder.ToString();

            //Assert
            result.Should().NotBeNull()
                .And.NotBeEmpty()
                .And.ContainAll("public class Person", "public string Name;", "public int Age;");

            Check.That(result).IsNotNull()
                .And.IsNotEmpty()
                .And.Contains("public class Person", "public string Name;", "public int Age;");
        }
    }
}