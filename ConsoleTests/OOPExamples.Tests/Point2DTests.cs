using FluentAssertions;
using System.Diagnostics;
using Xunit.Abstractions;

namespace OOPExamples.Tests;

public class Point2DTests
{
    private readonly ITestOutputHelper _output;

    public Point2DTests(ITestOutputHelper output)
    {
        _output = output;
    }

    [Fact]
    public void Point_created_with_default_ctor_should_have_x_and_y_zero()
    {
        Point2D p = new Point2D();

        p.X.Should().Be(0d);
        p.Y.Should().Be(0d);
    }

    [Fact]
    public void Point_created_with_ctor_should_set_x_and_y_with_parameters()
    {
        Point2D p = new Point2D(3d, 4d);
        p.X.Should().Be(3d);
        p.Y.Should().Be(4d);
    }

    [Fact]
    public void Point_3_4_should_have_distance_5_from_origin()
    {
        Point2D p = new Point2D(3d, 4d);
        p.DistanceFromOrigin().Should().Be(5d);
    }

    [Fact]
    public void Point_minus3_minus4_should_have_distance_5_from_origin()
    {
        Point2D p = new Point2D(-3d, -4d);
        p.DistanceFromOrigin().Should().Be(5d);
    }

    [Fact]
    public void Point_1_2_should_have_distance_5_from_point_4_6()
    {
        Point2D p1 = new Point2D(1d, 2d);
        Point2D p2 = new Point2D(4d, 6d);
        p1.DistanceFrom(p2).Should().Be(5d);
        p2.DistanceFrom(p1).Should().Be(5d);
    }

    private Point2D[] CreateRandomPoints(int n)
    {
        Random rnd = new Random();

        double GetNextXY()
        {
            int sign = rnd.Next(2) == 0 ? 1 : -1;
            return sign * 100 * rnd.NextDouble();
        }

        double xrnd = 100 * rnd.NextDouble();

        return
            Enumerable.Range(0, n)
            .Select
            (
                _ => new Point2D(GetNextXY(), GetNextXY())
            )
            .ToArray();

        // Equivalente del LinQ precedente. Versione con List<T>
        //List<Point2D> listOfPoints = new List<Point2D>();
        //for (int i = 0; i < n; i++)
        //{
        //    Point2D p = new Point2D(GetNextXY(), GetNextXY());
        //    listOfPoints.Add(p);
        //}
        //Point2D[] points = listOfPoints.ToArray();


        // Equivalente del LinQ precedente. Versione con array
        //Point2D[] points = new Point2D[n];

        //for (int i = 0; i < n; i++)
        //{
        //    Point2D p = new Point2D(GetNextXY(), GetNextXY());
        //    points[i] = p;
        //}
    }


    [Fact]
    public void Test_memory_pressure_with_DistanceFromOrigin_version_1()
    {
        Point2D[] points = CreateRandomPoints(10_000);

        int count = 10_000;
        Stopwatch sw = Stopwatch.StartNew();
        for (int i = 0; i < count; i++)
        {
            for (int j = 0; j < points.Length; j++)
            {
                double distance = points[j].DistanceFromOrigin();
            }
        }
        sw.Stop();
        _output.WriteLine($"Elapsed time: {sw.Elapsed}");
    }

    [Fact]
    public void Test_Point2D_Zero()
    {
        Point2D.Zero.X = 1;
        Point2D p1 = new Point2D(1, 1);
        object p2 = new Point2D(1, 1);
        Console.WriteLine(p2);
        p2 = "Hello world!";
        //Console.WriteLine(p2);


        Point2D p3 = new Point2D();
        Point2D.Zero.Equals(p3).Should().Be(true);

        p1.Equals(Point2D.Zero).Should().Be(true);

        Type typeOfZero = Point2D.Zero.GetType();
        typeOfZero.Should().Be(Point2D.TypeForZero);

        //object[] mixedObjects = new object[5];
        //mixedObjects[0] = "Hello";
        //mixedObjects[1] = DateTime.Now;
        //mixedObjects[2] = Point2D.Zero;
        //mixedObjects[3] = 6;
        //mixedObjects[4] = 1m;

        //Point2D[] points = new Point2D[2];
        //points[0] = new Point2D();
        //points[1] = new Point2D(1, 1);

        //object[] pointsObj = points;
        //pointsObj[0] = 5;


    }

    [Fact]
    public void Test_PointsUtils()
    {
        object o = 5;

        int five = (int)o;

        var d1 = PointsUtils.DistanceFromOrigin(3, 4);
        var d2 = PointsUtils.DistanceFrom(2, 1, 3, 4);
        string s1 = PointsUtils.ToString(4, 3);
    }

    [Fact]
    public void Test_MI()
    {
        /*
         *             A m1
         *            / \
         *        m2 B   C m2
         *            \ /
         *             D
         * 
         * 
         * */
    }

}