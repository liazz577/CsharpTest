using GeometryExample;

public class Program
{
    static void Main(string[] args)
    {
        Cylinder cylinder = new ();
        cylinder.Input();
        cylinder.Process(cylinder.Radius, cylinder.Height);
        Console.WriteLine("Cylinder Characteristics: ");
        Console.WriteLine(cylinder.Result());
    }
}