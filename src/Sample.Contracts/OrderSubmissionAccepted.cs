namespace Sample.ContractsRefactored
{
    using System;


    public record OrderSubmissionAccepted
    {
        public Guid OrderId { get; init; }
        public string OrderNumber { get; init; }
    }
}