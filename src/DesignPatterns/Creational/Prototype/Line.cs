// ReSharper disable NonReadonlyMemberInGetHashCode
namespace DesignPatterns.Creational.Prototype
{
    public sealed class Line : IPrototype<Line>
    {
        public Point Start { get; set; }

        public Point End { get; set; }

        public Line DeepCopy()
        {
            return new Line
               {
                   Start = this.Start.DeepCopy(),
                   End = this.End.DeepCopy()
               };
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            return this.Equals((Line)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((this.Start != null ? this.Start.GetHashCode() : 0) * 397) ^ (this.End != null ? this.End.GetHashCode() : 0);
            }
        }

        private bool Equals(Line other)
        {
            return this.Start.Equals(other.Start) && this.End.Equals(other.End);
        }
    }
}