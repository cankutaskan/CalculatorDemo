using Calculator.Requests.Calculate;

namespace Calculator.Domain.Services
{
    public class CalculateServiceFactory(IServiceProvider serviceProvider) : ICalculateService
    {
        public decimal Handle(Get request, CancellationToken _)
        {
            switch (request.OperationType)
            {
                case Get.OperationTypeEnum.Add:
                    return serviceProvider.GetRequiredService<AddService>().Handle(request, _);
                case Get.OperationTypeEnum.Subtract:
                    return serviceProvider.GetRequiredService<SubtractService>().Handle(request, _);
                case Get.OperationTypeEnum.Multiply:
                    return serviceProvider.GetRequiredService<MultiplyService>().Handle(request, _);
                default:
                    throw new NotSupportedException($"Operation type {request.OperationType} is not supported.");
            }
        }
    }
}
