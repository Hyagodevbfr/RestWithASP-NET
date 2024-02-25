using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNETUdemy_Calculator.Controllers;
[ApiController]
[Route("[controller]")]
public class CalculatorController: ControllerBase
{
    private readonly ILogger<CalculatorController> _logger;

    public CalculatorController(ILogger<CalculatorController> logger)
    {
        _logger = logger;
    }

    [HttpGet("sum/{firstNumber}/{secondNumber}")]
    public IActionResult GetSum(string firstNumber, string secondNumber)
    {
        if(IsNumeric(firstNumber)
            && IsNumeric(secondNumber))
        {
            var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
            return Ok(sum.ToString( ));
        }
        return BadRequest("Invalid Input");
    }
    [HttpGet("sub/{firstNumber}/{secondNumber}")]
    public IActionResult GetSub(string firstNumber, string secondNumber) 
    {
        if(IsNumeric(firstNumber)
            && IsNumeric(secondNumber))
        {
            var sub = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);
            return Ok(sub.ToString( ));
        }
        return BadRequest("Invalid Input");
    }
    [HttpGet("Multi/{firstNumber}/{secondNumber}")]
    public IActionResult GetMult(string firstNumber, string secondNumber)
    {
        if (IsNumeric(firstNumber)
            && IsNumeric(secondNumber))
        {
            var mult = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);
            return Ok(mult.ToString( ));
        }
        return BadRequest("Invalid Input");
    }
    [HttpGet("Div/{firstNumber}/{secondNumber}")]
    public IActionResult GetDiv(string firstNumber, string secondNumber)
    {
        if (IsNumeric(firstNumber)
            && IsNumeric(secondNumber))
        {
            var div = ConvertToDecimal(firstNumber) / ConvertToDecimal(secondNumber);
            return Ok(div.ToString( ));
        }
        return BadRequest("Invalid Input");
    }
    public IActionResult Mean(string firstNumber, string secondNumber)
    {
        if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
        {
            var mean = (ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber)) / 2;
            return Ok(mean.ToString( ));
        }
        return BadRequest("Invalid Input");
    }
    [HttpGet("sqrt/{firstNumber}")]
    public IActionResult GetSquareRoot(string firstNumber)
    {
        if (IsNumeric(firstNumber))
        {
            var squareRoot = Math.Sqrt((double)ConvertToDecimal(firstNumber));
            return Ok(squareRoot.ToString( ));
        }
        return BadRequest("Invalid Input");
    }
    private bool IsNumeric(string strNumber)
    {
        double number;
        bool IsNumber = double.TryParse(
            strNumber, System.Globalization.NumberStyles.Any,
            System.Globalization.NumberFormatInfo.InvariantInfo, out number);
        return IsNumber;
    }

    private decimal ConvertToDecimal(string strNumber)
    {
        decimal decimalValue;
        if(decimal.TryParse(strNumber, out decimalValue))
        {
            return decimalValue;
        }
        return 0;
    }

}
