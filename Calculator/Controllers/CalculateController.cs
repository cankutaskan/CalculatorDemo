using Calculator.Domain.Services;
using Calculator.Requests.Calculate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Calculator.Requests.Calculate.Get;

namespace Calculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculateController : ControllerBase
    {
        [HttpGet("{Operation}/{FirstOperand}/{SecondOperand}")]
        public IActionResult Get(OperationTypeEnum Operation, decimal FirstOperand, decimal SecondOperand, [FromServices] ICalculateService calculateService, CancellationToken cancellationToken)
        {
            Get request = new()
            {
                OperationType = Operation,
                FirstOperand = FirstOperand,
                SecondOperand = SecondOperand
            };

            return StatusCode(StatusCodes.Status200OK, calculateService.Handle(request, cancellationToken));
        }
    }
}
