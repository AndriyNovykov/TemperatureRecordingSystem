namespace TemperatureRecordingSystem.Dtos;

public record TemperatureRecordDto {
    public int SensorId { get; set; }
    public int TemperatureInCelsius { get; set; }
    public DateTime TimeStamp { get; set; }
}
