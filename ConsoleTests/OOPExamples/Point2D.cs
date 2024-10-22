namespace OOPExamples;

public class Point2D
{
    //private double _x;
    //private double _y;
    public double X { get; set; }
    public double Y { get; set; }

    private void DoSomethig()
    {
        // fa qualcosa
    }

    // KISS
    // DRY -> Don't Repeat Yourself

    public Point2D(double x, double y)
    {
        Initialize(x, y);
        DoSomethig();
    }

    public Point2D() : this(0d, 0d)
    {
    }

    private void Initialize(double x, double y)
    {
        X = x;
        Y = y;
    }

    /// <summary>
    /// Computes the distance of the current point from the origin
    /// </summary>
    /// <returns>The distance value</returns>
    public double DistanceFromOrigin() =>
        DistanceFrom(new Point2D());

    public double DistanceFrom(Point2D other) =>
        Math
        .Sqrt
        (
            Math.Pow(X - other.X, 2)
            +
            Math.Pow(Y - other.Y, 2)
        );

    public override string ToString() =>
        $"({X:0.00}, {Y:0.00})";


    //public double X
    //{
    //    get
    //    {
    //        return _x;
    //    }
    //    set
    //    {
    //        _x = value;
    //    }
    //}

    //public double X
    //{
    //    get => _x;
    //    set => _x = value;
    //}

    //public double X => 
    //    _x;

    //public double Y
    //{
    //    get
    //    {
    //        return _y;
    //    }

    //    set
    //    {
    //        _y = value;
    //    }
    //}

    //public double GetX() =>
    //    _x;

    //public void SetX(double x) => 
    //    _x = x;

    //public double GetY() => 
    //    _y;

    //public void SetY(double y) =>
    //    _y = y;
}


public class Cippa
{
    private Point2D _point = new Point2D();

    public void TestPoint()
    {
        var x = _point.X;
        _point.Y = 10d;
        _point.X = -5;
    }
}