using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder.Exercises
{
    public sealed class CodeBuilder
    {
        private readonly string _className;
        private readonly IList<(string Name, string Type)> _classFields;
        private const int IndentSpaceSize = 4;

        public CodeBuilder(string className)
        {
            _className = className ?? throw new ArgumentNullException(nameof(className));
            _classFields = new List<(string Name, string Type)>();
        }

        public CodeBuilder AddField(string name, string type)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));
            if (type == null) throw new ArgumentNullException(nameof(type));
            _classFields.Add((name, type));
            return this;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"public class {_className}");
            sb.AppendLine("{");
            foreach (var f in _classFields)
            {
                sb.AppendLine($"{IndentFor(1)}public {f.Type} {f.Name};");
            }
            sb.AppendLine("}");
            return sb.ToString();
        }

        private static string IndentFor(int n)
        {
            return new string(' ', IndentSpaceSize * n);
        }
    }
}