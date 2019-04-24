namespace DesignPatterns.Structural.Adapter
{
    public class SquareToRectangleAdapter : IRectangle
    {
        private readonly Square square;

        public SquareToRectangleAdapter(Square square)
        {
            this.square = square;
            this.Width = this.Height = square.Side;
        }

        public int Width { get; }

        public int Height { get; }
    }
}