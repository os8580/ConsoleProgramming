class Cube : Shape, IShape
{
    public double Width { get; set; }

    public double GetArea()
    {
        return Length * Width;
    }

    public double GetVolume()
    {
        return Length * Width * Height;
    }
}
