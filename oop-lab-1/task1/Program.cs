
public class Program
{
    public static void Main()
    {
        Display dis1 = new Display(1920, 1080, 300, "ViewSonic VP3881");
        Display dis2 = new Display(2560, 1440, 300, "LG 34WK95U-W");
        Display dis3 = new Display(3840, 2160, 400, "Dell U4919DW");

        dis1.CompareWithMonitor(dis1);
        dis2.CompareWithMonitor(dis2);
        dis3.CompareWithMonitor(dis3);
    }
}
