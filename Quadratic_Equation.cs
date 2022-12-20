using System;

public class QuadraticEquation
{
    // Method that solves the quadratic equation 
    public static Tuple<double, double> FindRoots(double a, double b, double c)
    {
        double discriminant = b * b - 4 * a * c;
        if (discriminant < 0)
        {
            return new Tuple<double, double>(0, 0);
        }
        else if (discriminant == 0)
        {
            return new Tuple<double, double>(-b / (2 * a), -b / (2 * a));
        }
        else
        {
            return new Tuple<double, double>( (-b + Math.Sqrt(discriminant)) / (2 * a), (-b - Math.Sqrt(discriminant)) / (2 * a) );
        }
    }

    //public static void Main(string[] args)
    //{
    //    Tuple<double, double> roots = QuadraticEquation.FindRoots(2, 10, 8);
    //    Console.WriteLine("Roots: " + roots.Item1 + ", " + roots.Item2);
    //}
}