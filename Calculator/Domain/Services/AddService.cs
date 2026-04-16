
using Calculator.Requests.Calculate;
using static Calculator.Domain.Services.ICalculateService;

namespace Calculator.Domain.Services
{
    public class AddService : ICalculateService
    {
        public decimal Handle(Get request, CancellationToken _) => request.FirstOperand + request.SecondOperand;
    }
}
