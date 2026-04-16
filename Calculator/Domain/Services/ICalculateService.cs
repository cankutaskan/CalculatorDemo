using Calculator.Requests.Calculate;

namespace Calculator.Domain.Services
{
    public interface ICalculateService
    {
        decimal Handle(Get request, CancellationToken _);
    }
}
