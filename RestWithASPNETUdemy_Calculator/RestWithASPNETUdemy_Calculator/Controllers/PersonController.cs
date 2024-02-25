using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNETUdemy_Calculator.Controllers;
[ApiController]
[Route("[controller]")]
public class PersonController(ILogger<PersonController> logger): ControllerBase
{
    private readonly ILogger<PersonController> _logger = logger;

    [HttpGet("sum/{firstNumber}/{secondNumber}")]
    public IActionResult GetSum(string firstNumber, string secondNumber)
    {
      
        return BadRequest("Invalid Input");
    }
}
