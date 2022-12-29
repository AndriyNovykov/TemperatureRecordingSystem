using TemperatureRecordingSystem.Models;

namespace TemperatureRecordingSystem.Repositories;

public interface ITemperatureRepository {
    void Create(DailyTemperatureRecord record);
    void Update(DailyTemperatureRecord record);
    DailyTemperatureRecord Get(int sensorId, DateTime date);
}