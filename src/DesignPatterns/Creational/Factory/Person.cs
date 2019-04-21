using System;

namespace DesignPatterns.Creational.Factory
{
    public sealed class Person
    {
        private static int lastId;

        private Person(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public int Id { get; }

        public string Name { get; set; }

        public static Person Create(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(name));
            }

            return new Person(++Person.lastId, name);
        }
    }
}