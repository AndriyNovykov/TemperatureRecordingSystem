using Microsoft.AspNetCore.Mvc;

namespace TemperatureRecordingSystem.Controllers;

[ApiController]
[Route("[controller]")]
public class DataIngestionController : ControllerBase
{
    public DataIngestionController()
    {
        
    }

    [HttpPost]
    public ActionResult Post()
    {
        var result = "Data Received!\n";
        return Ok(result);
    }
}
