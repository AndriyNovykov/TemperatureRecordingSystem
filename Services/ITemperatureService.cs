using TemperatureRecordingSystem.Dtos;

namespace TemperatureRecordingSystem.Services;

public interface ITemperatureService {
    void Process(TemperatureMeasurementDto dto);
}