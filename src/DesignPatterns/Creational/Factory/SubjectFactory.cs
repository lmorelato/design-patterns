using System;

namespace DesignPatterns.Creational.Factory
{
    public class SubjectFactory
    {
        private int lastId;

        public Man Create(string name)
        {
            return new Man(++this.lastId, name);
        }
    }

    public sealed class Man
    {
        public Man(int id, string name)
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