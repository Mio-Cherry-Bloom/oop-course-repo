using System;
using System.Text.Json;

namespace CarService
{
   using System.Text.Json;
using System.Text.Json.Serialization;

public class Car
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("passengers")]
    public string PassengerType { get; set; }

    [JsonPropertyName("isDining")]
    public bool IsDining { get; set; }

    [JsonPropertyName("consumption")]
    public int Consumption { get; set; }

    public Car(int id, string type, string passengerType, bool isDining, int consumption)
    {
        Id = id;
        Type = type;
        PassengerType = passengerType;
        IsDining = isDining;
        Consumption = consumption;
    }
    public static Car FromJson(string json)
    {
        try
        {
            return JsonSerializer.Deserialize<Car>(json);
        }
        catch (JsonException ex)
        {
            Console.WriteLine($"Error deserializing car JSON: {ex.Message}");
            return null;
        }
    }
}

}
