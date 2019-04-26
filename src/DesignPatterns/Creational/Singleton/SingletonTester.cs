﻿using System;

namespace DesignPatterns.Creational.Singleton
{
    public static class SingletonTester
    {
        public static bool IsSingleton(Func<object> func)
        {
            var obj1 = func();
            var obj2 = func();
            return ReferenceEquals(obj1, obj2);
        }
    }
}