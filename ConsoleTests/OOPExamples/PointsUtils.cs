
namespace OOPExamples;

public static class PointsUtils
{
    public static double DistanceFromOrigin(double x, double y) =>
        DistanceFrom(x, y, 0d, 0d);

    public static double DistanceFrom(double x1, double y1, double x2, double y2) =>
        Math
        .Sqrt
        (
            Math.Pow(x1 - x2, 2)
            +
            Math.Pow(y1 - y2, 2)
        );

    public static string ToString(double x, double y) =>
        $"({x:0.00}, {y:0.00})";

}

