using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder.Exercises
{
    public sealed class CodeBuilder
    {
        private const int IndentSpaceSize = 4;

        private readonly IList<(string Name, string Type)> classFields;

        private readonly string className;

        public CodeBuilder(string className)
        {
            this.className = className ?? throw new ArgumentNullException(nameof(className));
            this.classFields = new List<(string Name, string Type)>();
        }

        public CodeBuilder AddField(string name, string type)
        {
            name = name ?? throw new ArgumentNullException(nameof(name));
            type = type ?? throw new ArgumentNullException(nameof(type));
            this.classFields.Add((name, type));
            return this;
        }

        public void Clear()
        {
            this.classFields.Clear();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"public class {this.className}");
            sb.AppendLine("{");
            foreach (var f in this.classFields)
            {
                sb.AppendLine($"{CodeBuilder.IndentFor(1)}public {f.Type} {f.Name};");
            }

            sb.AppendLine("}");
            return sb.ToString();
        }

        private static string IndentFor(int n)
        {
            return new string(' ', CodeBuilder.IndentSpaceSize * n);
        }
    }
}