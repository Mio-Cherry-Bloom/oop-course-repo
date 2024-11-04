
public class Program
{
    public static void Main(string[] args)
    {
        FileReader fileReader = new FileReader();
        foreach (string filePath in args)
        {
            try
            {
                string textContent = fileReader.ReadFileIntoString(filePath);
                TextData textData = new TextData(filePath, textContent);
                Console.WriteLine(textData);
                Console.WriteLine("\n \n"); 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file '{filePath}': {ex.Message}");
            }
        }
    }
}
