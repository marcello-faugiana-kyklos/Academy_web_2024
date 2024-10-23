using FluentAssertions;

namespace OOPExamples.Tests;

public class Point2DTests
{
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
    public void Test_tbd()
    {
        Point2D[] points = CreateRandomPoints(10_000);

        int count = 100_000;

        for (int i = 0; i < count; i++)
        {
            for (int j = 0; j < points.Length; j++)
            {
                double distance = points[j].DistanceFromOrigin();
            }
        }
    }

}