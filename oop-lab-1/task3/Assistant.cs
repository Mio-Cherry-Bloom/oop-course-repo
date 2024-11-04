public class Assistant
{
    public string AssistantName { get; set; }
    private List<Display> assignedDisplays;
    public Assistant(string assistantName)
    {
        AssistantName = assistantName;
        assignedDisplays = new List<Display>();
    }
    public void AssignDisplay(Display d)
    {
        assignedDisplays.Add(d);
    }

    public void Assist()
    {
        Console.WriteLine($"\n{AssistantName} is assisting:");
        for (int i = 0; i < assignedDisplays.Count - 1; i++)
        {
            Console.WriteLine($"Comparing {assignedDisplays[i].Model} with {assignedDisplays[i + 1].Model}:");
            assignedDisplays[i].CompareWithMonitor(assignedDisplays[i + 1]);
        }
    }

    public Display BuyDisplay(Display d)
    {
        if (assignedDisplays.Contains(d))
        {
            assignedDisplays.Remove(d);
            return d;
        }
        else
        {
            Console.WriteLine($"{d.Model} is not assigned to {AssistantName}, purchase failed.");
            return null;
        }
    }
}
