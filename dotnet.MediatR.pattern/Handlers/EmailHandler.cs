using dotnet.MediatR.pattern.Notifications;
using MediatR;

namespace dotnet.MediatR.pattern.Handlers
{
    public class EmailHandler : INotificationHandler<ProductAddedNotification>
    {
        private readonly DbContext _dbContext;

        public EmailHandler(DbContext dbContext) => _dbContext = dbContext;

        public async Task Handle(ProductAddedNotification notification, CancellationToken cancellationToken)
        {
            await _dbContext.EventOccured(notification.Product, "Email sent");
            await Task.CompletedTask;
        }
    }
}
