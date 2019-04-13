using DesignPatterns.Code.Creational.Builder.Exercises;
using FluentAssertions;
using NFluent;
using Xunit;

namespace DesignPatterns.Test.Creational.Builder.Exercises
{
    public class CodeBuilderTest
    {
        [Fact]
        public void AddFieldValidFieldCodeBuilder()
        {
            // Arrange:
            var builder = new CodeBuilder("Person")
                .AddField("Name", "string")
                .AddField("Age", "int");

            // Act:
            var result = builder.ToString();

            // Assert: Which library is more intuitive?
            // Fluent Assertions
            result.Should()
                .NotBeNull().And
                .NotBeEmpty().And
                .ContainAll("public class Person", "public string Name;", "public int Age;");

            // NFluent
            Check.That(result)
                .IsNotNull().And
                .IsNotEmpty().And
                .Contains("public class Person", "public string Name;", "public int Age;");
        }
    }
}