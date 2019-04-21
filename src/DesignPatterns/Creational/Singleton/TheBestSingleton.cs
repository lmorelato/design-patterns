using System;

namespace DesignPatterns.Creational.Singleton
{
    public class TheBestSingleton
    {
        private static readonly Lazy<TheBestSingleton> LazyInstance =
            new Lazy<TheBestSingleton>(() => new TheBestSingleton());

        private TheBestSingleton()
        {
            Count++;
        }

        public static int Count { get; private set; }

        public static TheBestSingleton Instance => LazyInstance.Value;
    }
}