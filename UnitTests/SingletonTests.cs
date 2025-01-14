using DesignPatternsWebApi.DesignPatterns.Singleton;
using Xunit;

namespace DesignPatternsWebApi.UnitTests
{
    public class SingletonTests
    {
        [Fact]
        public void Singleton_Should_Return_Same_Instance()
        {
            var instance1 = SingletonBasic.Instance;
            var instance2 = SingletonBasic.Instance;

            Assert.Equal(instance1, instance2);
        }
    }
}