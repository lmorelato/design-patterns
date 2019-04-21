// ReSharper disable NonReadonlyMemberInGetHashCode
namespace DesignPatterns.Creational.Prototype
{
    public class Point : IPrototype<Point>
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Point DeepCopy()
        {
            return this.MemberwiseClone() as Point;
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

            return this.Equals((Point)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (this.X * 397) ^ this.Y;
            }
        }

        protected bool Equals(Point other)
        {
            return this.X == other.X && this.Y == other.Y;
        }
    }
}