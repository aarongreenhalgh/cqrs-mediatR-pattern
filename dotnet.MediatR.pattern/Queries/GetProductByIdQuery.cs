using MediatR;

namespace dotnet.MediatR.pattern.Queries
{
    public record GetProductByIdQuery(int Id) : IRequest<Product>;

}
