using Bogus;

namespace DesignPatterns.Tests
{
    public class BaseTest
    {
        protected BaseTest()
        {
            this.Faker = new Faker();
        }

        protected Faker Faker { get; }
    }
}