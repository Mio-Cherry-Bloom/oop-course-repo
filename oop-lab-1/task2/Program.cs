
public class Program
{
    public static void Main(string[] args)
    {
        string filePath = args[0];

        FileReader fileReader = new FileReader();
        string textContent = fileReader.ReadFileIntoString(filePath);

        TextData textData = new TextData(filePath, textContent);
        Console.WriteLine(textData);
    }
}
