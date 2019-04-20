using System;

namespace DesignPatterns.Creational.Factory.Exercises
{
    public class PersonFactory
    {
        private int lastId;

        public PersonForFactory Create(string name)
        {
            return new PersonForFactory(++this.lastId, name);
        }
    }

    public sealed class PersonForFactory
    {
        public PersonForFactory(int id, string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Value cannot be null or empty.", nameof(name));
            }

            this.Id = id;
            this.Name = name;
        }

        public int Id { get; }

        public string Name { get; set; }
    }
}