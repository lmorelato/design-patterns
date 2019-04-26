namespace DesignPatterns.Structural.Adapter
{
    public class SquareToRectangleAdapter : IRectangle
    {
        public SquareToRectangleAdapter(Square square)
        {
            this.Width = this.Height = square.Side;
        }

        public int Width { get; }

        public int Height { get; }
    }
}