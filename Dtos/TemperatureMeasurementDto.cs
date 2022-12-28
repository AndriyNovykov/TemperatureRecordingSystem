namespace TemperatureRecordingSystem.Dtos;

public record TemperatureMeasurementDto {
    public int SensorId { get; init; }
    public int TemperatureInCelsius { get; init; }
    public DateTime Date { get; init; }
}
