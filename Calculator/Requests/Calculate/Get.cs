namespace Calculator.Requests.Calculate
{
    public class Get
    {
        public OperationTypeEnum OperationType { get; set; }
        public decimal FirstOperand { get; set; }
        public decimal SecondOperand { get; set; }

        public enum OperationTypeEnum
        {
            Add,
            Subtract,
            Multiply
        }

    }
}
