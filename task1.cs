//using static System.Math;
//internal class Task1
//{
//    private static void Main()
//    {
//        Vector a = new Vector(1, 2, 3);
//        Vector b = new Vector(4, 5, 6);
//        Vector c = a * b;
//        Console.WriteLine($"{c.X} {c.Y} {c.Z}"); //-3 6 -3
//        c *= c;
//        Console.WriteLine($"{c.X} {c.Y} {c.Z}"); //0 0 0
//        c = a + b;
//        Console.WriteLine($"{c.X} {c.Y} {c.Z}"); //5 7 9
//        c *= 5;
//        Console.WriteLine($"{c.X} {c.Y} {c.Z}"); //25 35 45
//        Console.WriteLine(c == c); //True
//        Console.WriteLine(c == a); //False
//        Console.WriteLine(c != b); //True
//        Console.WriteLine(a>c); //False
//        Console.WriteLine(b>a); //True
//        Console.WriteLine(a<b); //True
//        Console.WriteLine(a>a); //False
//        Console.WriteLine(a >= a); //True
//    }
//}

//struct Vector
//{
//    private double _x, _y, _z;
//    public Vector(double x, double y, double z) { _x = x; _y = y; _z = z; }
//    public double X { get { return _x; } }
//    public double Y { get { return _y; } }
//    public double Z { get { return _z; } }
//    public double len { get { return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2)); } }
//    public static Vector operator +(Vector a, Vector b) { return new Vector(a.X + b.X, a.Y + b.Y, a.Z + b.Z); }
//    public static Vector operator *(Vector a, Vector b) { return new Vector(a.Y * b.Z - a.Z * b.Y, a.Z * b.X - a.X * b.Z, a.X * b.Y - a.Y * b.X); }
//    public static Vector operator *(Vector a, double n) { return new Vector(a.X * n, a.Y * n, a.Z * n); }
//    public static Vector operator *(double n, Vector a) { return new Vector(a.X * n, a.Y * n, a.Z * n); }
//    public static bool operator ==(Vector a, Vector b) { return a.X == b.X && a.Y == b.Y && a.Z == b.Z; }
//    public static bool operator !=(Vector a, Vector b) { return a.X != b.X || a.Y != b.Y || a.Z != b.Z; }
//    public static bool operator >(Vector a, Vector b) { return a.len > b.len; }
//    public static bool operator <(Vector a, Vector b) { return a.len < b.len; }
//    public static bool operator <=(Vector a, Vector b) { return a.len <= b.len; }
//    public static bool operator >=(Vector a, Vector b) { return a.len >= b.len; }
//}
