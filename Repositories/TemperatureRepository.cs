using TemperatureRecordingSystem.Dtos;
using TemperatureRecordingSystem.Models;

namespace TemperatureRecordingSystem.Repositories;

public class TemperatureRepository : ITemperatureRepository {
    

    public TemperatureRepository() {

    }

    public void Create(TemperatureRecord record)
    {
        throw new NotImplementedException();
    }

    public TemperatureRecord Get(int sensorId, DateTime date)
    {
        throw new NotImplementedException();
    }

    public void Update(TemperatureRecord record)
    {
        throw new NotImplementedException();
    }
}