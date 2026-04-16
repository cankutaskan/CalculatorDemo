using Calculator.Requests.Calculate;

namespace Calculator.Domain.Services
{
    public class MultiplyService : ICalculateService
    {
        public decimal Handle(Get request, CancellationToken _) => request.FirstOperand * request.SecondOperand;
    }
}
