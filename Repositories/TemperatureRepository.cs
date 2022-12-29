using TemperatureRecordingSystem.Dtos;
using TemperatureRecordingSystem.Models;

namespace TemperatureRecordingSystem.Repositories;

public class TemperatureRepository : ITemperatureRepository {
    

    public TemperatureRepository() {

    }

    public void Create(DailyTemperatureRecord record)
    {
        throw new NotImplementedException();
    }

    public DailyTemperatureRecord Get(int sensorId, DateTime date)
    {
        throw new NotImplementedException();
    }

    public void Update(DailyTemperatureRecord record)
    {
        throw new NotImplementedException();
    }
}