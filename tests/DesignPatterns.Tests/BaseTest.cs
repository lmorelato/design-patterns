using Bogus;

namespace DesignPatterns.Tests
{
    public class BaseTest
    {
        public BaseTest()
        {
            this.Faker = new Faker("en");
        }

        protected Faker Faker { get; }
    }
}