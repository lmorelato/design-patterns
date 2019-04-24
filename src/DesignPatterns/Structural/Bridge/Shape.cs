namespace DesignPatterns.Structural.Bridge
{
    public abstract class Shape
    {
        private readonly IRenderer renderer;

        protected Shape(IRenderer renderer)
        {
            this.renderer = renderer;
        }

        protected string Name { get; set; }

        public override string ToString()
        {
            return $"Drawing {this.Name} as {this.renderer.WhatToRenderAs}";
        }
    }
}
