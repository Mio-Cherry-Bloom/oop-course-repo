public class Program
{
    public static void Main()
    {

        Display dis1 = new Display(1920, 1080, 300, "ViewSonic VP3881");
        Display dis2 = new Display(2560, 1440, 300, "LG 34WK95U-W");
        Display dis3 = new Display(3840, 2160, 400, "Dell U4919DW");
        Display dis4 = new Display(3840, 1440, 300, "Dell S3221QS");

        Assistant assistant = new Assistant("Kindred");

        assistant.AssignDisplay(dis1);
        assistant.AssignDisplay(dis2);
        assistant.AssignDisplay(dis3);
        assistant.AssignDisplay(dis4);

        assistant.Assist();

        Console.WriteLine($"{assistant.BuyDisplay(dis2).Model} has been purchased.");
    }
}
