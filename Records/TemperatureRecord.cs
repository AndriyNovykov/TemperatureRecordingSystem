namespace TemperatureRecordingSystem.Records;

public record TemperatureRecord {
    public int SensorId { get; init; }
    public int HighestTemperatureInCelsius { get; init; }
    public int LowestTemperatureInCelsius { get; init; }
    public DateTime Date { get; init; }
}