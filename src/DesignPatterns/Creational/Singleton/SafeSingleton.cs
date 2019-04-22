using System;

namespace DesignPatterns.Creational.Singleton
{
    public class SafeSingleton
    {
        private static readonly Lazy<SafeSingleton> Lazy =
            new Lazy<SafeSingleton>(() => new SafeSingleton());

        private SafeSingleton()
        {
            Count++;
        }

        public static int Count { get; private set; }

        public static SafeSingleton Instance => Lazy.Value;
    }
}