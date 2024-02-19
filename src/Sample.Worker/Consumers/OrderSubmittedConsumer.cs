namespace Sample.Worker.Consumers
{
    using System.Threading.Tasks;
    using ContractsRefactored;
    using MassTransit;
    using Microsoft.Extensions.Logging;


    public class OrderSubmittedConsumer :
        IConsumer<OrderSubmitted>
    {
        readonly ILogger _logger;

        public OrderSubmittedConsumer(ILogger<OrderSubmittedConsumer> logger)
        {
            _logger = logger;
        }

        public async Task Consume(ConsumeContext<OrderSubmitted> context)
        {
            _logger.LogInformation("Order Submitted: {OrderId}", context.Message.OrderId);
        }
    }
}