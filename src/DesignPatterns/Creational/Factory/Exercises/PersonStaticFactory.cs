using System;

namespace DesignPatterns.Creational.Factory.Exercises
{
    public static class PersonStaticFactory
    {
        private static int lastId;

        public static ThePerson Create(string name)
        {
            return new ThePerson(++PersonStaticFactory.lastId, name);
        }
    }

    public sealed class ThePerson
    {
        public ThePerson(int id, string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(name));
            }

            this.Id = id;
            this.Name = name;
        }

        public int Id { get; }

        public string Name { get; set; }
    }
}