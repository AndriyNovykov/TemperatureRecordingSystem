using Microsoft.AspNetCore.Mvc;
using TemperatureRecordingSystem.Services;
using TemperatureRecordingSystem.Dtos;

namespace TemperatureRecordingSystem.Controllers;

[ApiController]
[Route("[controller]")]
public class TemperatureController : ControllerBase
{
    private ITemperatureService _temperatureService;
    public TemperatureController(ITemperatureService temperatureService)
    {
        _temperatureService = temperatureService;
    }

    [HttpPost]
    [Route("Post")]
    public ActionResult Post(TemperatureMeasurementDto dto)
    {
        _temperatureService.Process(dto);
        return Ok();
    }
}
