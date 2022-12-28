namespace TemperatureRecordingSystem.Models;

public class TemperatureRecord {
    public int SensorId { get; set; }
    public int HighestTemperatureInCelsius { get; set; }
    public int LowestTemperatureInCelsius { get; set; }
    public DateTime Date { get; set; }
}