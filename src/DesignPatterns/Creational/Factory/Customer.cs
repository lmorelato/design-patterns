using System;

namespace DesignPatterns.Creational.Factory
{
    public sealed class Customer
    {
        private Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public int Id { get; }

        public string Name { get; set; }

        public static class Factory
        {
            private static int lastId;

            public static Customer Create(string name)
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    throw new ArgumentException("Value cannot be null or whitespace.", nameof(name));
                }

                return new Customer(++lastId, name);
            }
        }
    }
}