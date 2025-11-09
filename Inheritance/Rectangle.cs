class Rectangle : Shape, IShape
{
    public int Width { get; set; }
    public double GetArea()
    {
        return Length * Width;
    }
}
