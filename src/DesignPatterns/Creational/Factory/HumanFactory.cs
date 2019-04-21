using System;

namespace DesignPatterns.Creational.Factory
{
    public static class HumanFactory
    {
        private static int lastId;

        public static Human Create(string name)
        {
            return new Human(++HumanFactory.lastId, name);
        }
    }

    public sealed class Human
    {
        public Human(int id, string name)
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