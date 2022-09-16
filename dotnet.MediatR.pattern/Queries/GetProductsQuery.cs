using MediatR;

namespace dotnet.MediatR.pattern.Queries
{
    public record GetProductsQuery() : IRequest<IEnumerable<Product>>;
}
