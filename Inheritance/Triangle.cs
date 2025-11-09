class Triangle : Shape, IShape
{
    public double Hypotenuese { get; set; }

    public double GetArea()
    {
        return .5 * Length * Height;
    }
}