namespace DesignPatterns.Structural.Adapter
{
    public class Rectangle : IRectangle
    {
        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public int Width { get; set; }

        public int Height { get; set; }
    }
}
