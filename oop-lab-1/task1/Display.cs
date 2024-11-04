
public class Display
{
    private int Width ;
    private int Height ;
    private float Ppi ;
    private string Model ;

    public Display(int width, int height, float ppi, string model)
    {
        Width = width;
        Height = height;
        Ppi = ppi;
        Model = model;
    }

    public void CompareSize(Display other)
    {
        int thisArea = Width * Height;
        int otherArea = other.Width * other.Height;

        Console.WriteLine($"\nComparing size between {Model} and {other.Model}:");
        if (thisArea > otherArea)
        {
            Console.WriteLine($"{Model} is larger than {other.Model}.");
        }
        else if (thisArea < otherArea)
        {
            Console.WriteLine($"{other.Model} is larger than {Model}.");
        }
        else
        {
            Console.WriteLine($"{Model} and {other.Model} have the same screen area.");
        }
    }

    public void CompareSharpness(Display other)
    {
        Console.WriteLine($"\nComparing sharpness between {Model} and {other.Model}:");
        if (Ppi > other.Ppi)
        {
            Console.WriteLine($"{Model} is sharper than {other.Model}.");
        }
        else if (Ppi < other.Ppi)
        {
            Console.WriteLine($"{other.Model} is sharper than {Model}.");
        }
        else
        {
            Console.WriteLine($"{Model} and {other.Model} have the same sharpness.");
        }
    }

    public void CompareWithMonitor(Display other)
    {
        Console.WriteLine($"\n> Comparing {Model} and {other.Model}:");
        CompareSize(other);
        CompareSharpness(other);
    }
}
