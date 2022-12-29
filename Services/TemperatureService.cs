using TemperatureRecordingSystem.Models;
using TemperatureRecordingSystem.Dtos;
using TemperatureRecordingSystem.Repositories;

namespace TemperatureRecordingSystem.Services;

public class TemperatureService : ITemperatureService{
    private ITemperatureRepository _temperatureRepository;

    TemperatureService(ITemperatureRepository temperatureRepository) {
        _temperatureRepository = temperatureRepository;
    }

    public void Process(TemperatureMeasurementDto dto)
    {
        var record = _temperatureRepository.Get(dto.SensorId, dto.Date);

        if (record is null) 
        {
            record = new DailyTemperatureRecord{
                SensorId = dto.SensorId,
                HighestTemperatureInCelsius = dto.TemperatureInCelsius,
                LowestTemperatureInCelsius = dto.TemperatureInCelsius,
                Date = dto.Date
            };
            _temperatureRepository.Create(record);
        }
        else if (TemperatureRecordNeedsToBeUpdated(dto, record)) 
        {
            var highestTemp = Math.Max(record.HighestTemperatureInCelsius, dto.TemperatureInCelsius);
            var lowestTemp = Math.Min(record.LowestTemperatureInCelsius, dto.TemperatureInCelsius);
            record = new DailyTemperatureRecord {
                SensorId = record.SensorId,
                HighestTemperatureInCelsius = highestTemp,
                LowestTemperatureInCelsius = lowestTemp,
                Date = record.Date
            };
            _temperatureRepository.Update(record);
        }
    }

    private bool TemperatureRecordNeedsToBeUpdated(TemperatureMeasurementDto dto, DailyTemperatureRecord record) 
    {
        return record.HighestTemperatureInCelsius < dto.TemperatureInCelsius ||
            record.LowestTemperatureInCelsius > dto.TemperatureInCelsius;
    }
}