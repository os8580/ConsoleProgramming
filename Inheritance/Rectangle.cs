class Rectangle : Shape, IShape
{
    public int Width { get; set; }
    public double getArea()
    {
        return Length * Width;
    }
}
