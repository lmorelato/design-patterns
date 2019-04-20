using System;

namespace DesignPatterns.Creational.Factory.Exercises
{
    public sealed class AnyPerson
    {
        private AnyPerson(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public int Id { get; }

        public string Name { get; set; }

        public static class Factory
        {
            private static int lastId;

            public static AnyPerson Create(string name)
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    throw new ArgumentException("Value cannot be null or whitespace.", nameof(name));
                }

                return new AnyPerson(++Factory.lastId, name);
            }
        }
    }
}