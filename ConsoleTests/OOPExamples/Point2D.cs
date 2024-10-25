
namespace OOPExamples;



public class Point2D
{
    private class Point2DImmutable : Point2D
    {
        public Point2DImmutable() : base()
        {
        }

        public override double X
        {
            get => base.X;
            set
            {
            }
        }

        public override double Y
        {
            get => base.Y;
            set { }
        }

        public override string ToString() =>
            "I'm Zero";

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
        public override bool Equals(Point2D? other)
        {
            return base.Equals(other);
        }
    }

    public virtual double X { get; set; }
    public virtual double Y { get; set; }

    private static Point2D _zero;

    internal static Type TypeForZero =>
        typeof(Point2DImmutable);

    // private static Point2D _oneOne;

    public static Point2D Zero =>
        _zero;

    static Point2D()
    {
        //   _oneOne = new(1, 1);
        _zero = new Point2DImmutable();
    }



    public Point2D(double x, double y)
    {
        Initialize(x, y);
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
        DistanceFrom(_zero);

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



    //public void Joke()
    //{
    //    _zero.X = -1;
    //}


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

    public override int GetHashCode() => 
        HashCode.Combine(X, Y);

    public override bool Equals(object? obj) =>
        Equals(obj as Point2D);

    public virtual bool Equals(Point2D? other)
    {
        if (other is null)
        {
            return false;
        }

        if (ReferenceEquals(this, other))
        {
            return true;
        }

        return 
            other.X == X 
            && other.Y == Y;
    }
}

