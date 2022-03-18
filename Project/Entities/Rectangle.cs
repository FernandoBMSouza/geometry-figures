using Project.Entities.Enums;
namespace Project.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(Color color, double widht, double heigth) : base(color)
        {
            Width = widht;
            Height = heigth;
        }
        public override double Area()
        {
            return Width * Height;
        }
    }
}