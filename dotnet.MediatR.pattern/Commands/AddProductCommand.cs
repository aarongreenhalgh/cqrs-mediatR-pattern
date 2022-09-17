using MediatR;

namespace dotnet.MediatR.pattern.Commands
{
    public record AddProductCommand(Product Product) : IRequest<Product>;
}
