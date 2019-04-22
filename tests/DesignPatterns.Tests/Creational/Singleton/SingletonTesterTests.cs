using DesignPatterns.Creational.Singleton;

using FluentAssertions;

using Xunit;

namespace DesignPatterns.Tests.Creational.Singleton
{
    public class SingletonTesterTests : BaseTest
    {
        [Fact]
        public void IsSingleton_SingletonObject_ReturnsTrue()
        {
            SingletonTester
                .IsSingleton(() => SafeSingleton.Instance)
                .Should()
                .BeTrue();
        }

        [Fact]
        public void IsSingleton_NotSingletonObject_ReturnsFalse()
        {
            SingletonTester
                .IsSingleton(() => new object())
                .Should()
                .BeFalse();
        }
    }
}