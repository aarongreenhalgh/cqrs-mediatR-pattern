using MediatR;

namespace dotnet.MediatR.pattern.Notifications
{
    public record ProductAddedNotification(Product Product) : INotification;
}
