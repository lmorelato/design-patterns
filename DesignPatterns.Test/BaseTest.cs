using Bogus;

namespace DesignPatterns.Test
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