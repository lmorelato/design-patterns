using System;

namespace DesignPatterns.Creational.Factory.Exercises
{
    public sealed class SomePerson
    {
        private static int lastId;

        private SomePerson(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public int Id { get; }

        public string Name { get; set; }

        public static SomePerson Create(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(name));
            }

            return new SomePerson(++SomePerson.lastId, name);
        }
    }
}