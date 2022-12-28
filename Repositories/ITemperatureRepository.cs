using TemperatureRecordingSystem.Models;

namespace TemperatureRecordingSystem.Repositories;

public interface ITemperatureRepository {
    void Create(TemperatureRecord record);
    void Update(TemperatureRecord record);
    TemperatureRecord Get(int sensorId, DateTime date);
}