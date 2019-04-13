using DesignPatterns.Code.Creational.Builder.Exercises;

using FluentAssertions;

using Xunit;

namespace DesignPatterns.Test.Creational.Builder.Exercises
{
    public class CodeBuilderTest
    {
        [Fact]
        public void AddField_ValidFields_PrintClass()
        {
            // Arrange
            var builder = this.BuildSample();

            // Act
            var result = builder.ToString();

            // Assert
            result.Should().NotBeNull()
                .And.NotBeEmpty()
                .And.ContainAll("public class SomePerson", "public string Name;", "public int Age;");
        }

        [Fact]
        public void Clear_FieldsListGreaterThanZero_EmptyFieldsList()
        {
            // Arrange
            var builder = this.BuildSample();
            builder.Clear();

            // Act
            var result = builder.ToString();

            // Assert
            result.Should().NotBeNull()
                .And.NotBeEmpty()
                .And.NotContainAll("public string Name;", "public int Age;");
        }

        private CodeBuilder BuildSample()
        {
            var builder = new CodeBuilder("SomePerson").AddField("Name", "string").AddField("Age", "int");
            return builder;
        }
    }
}