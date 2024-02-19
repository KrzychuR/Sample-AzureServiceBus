namespace Sample.ContractsRefactored
{
    using System;


    public record MonitorOrderShipmentTimeout
    {
        public Guid OrderId { get; init; }
    }
}