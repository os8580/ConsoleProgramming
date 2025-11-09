class Triangle : Shape, IShape
{
    public double Hypotenuese { get; set; }

    public double getArea()
    {
        return .5 * Length * Height;
    }
}