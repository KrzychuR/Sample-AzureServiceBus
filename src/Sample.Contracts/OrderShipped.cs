namespace Sample.ContractsRefactored
{
    using System;


    public record OrderShipped
    {
        public Guid OrderId { get; init; }
        public DateTimeOffset Timestamp { get; init; }
    }
}