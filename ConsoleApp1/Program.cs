public struct Point3D
{
    public double X;
    public double Y;
    public double Z;

    public Point3D(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public static Point3D operator +(Point3D p1, Point3D p2)
    {
        return new Point3D(p1.X + p2.X, p1.Y + p2.Y, p1.Z + p2.Z);
    }
    public static Point3D operator -(Point3D p1, Point3D p2)
    {
        return new Point3D(p1.X - p2.X, p1.Y - p2.Y, p1.Z - p2.Z);
    }
    public static Point3D operator *(Point3D p1, Point3D p2)
    {
        return new Point3D(p1.X * p2.X, p1.Y * p2.Y, p1.Z * p2.Z);
    }
    public static Point3D operator /(Point3D p1, Point3D p2)
    {
        return new Point3D(p1.X / p2.X, p1.Y / p2.Y, p1.Z / p2.Z);
    }

    static void Main()
    {
        Point3D Point1 = new Point3D(10, 20, 25);
        Point3D Point2 = new Point3D(15, 8, 18);
        Point3D Pointplus = Point1 + Point2;
        Point3D Pointminus = Point1 - Point2;
        Point3D Pointmultiply = Point1* Point2;
        Point3D Pointdivide = Point1 / Point2;

       
    }
}