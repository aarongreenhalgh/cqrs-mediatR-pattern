using dotnet.MediatR.pattern.Queries;
using MediatR;

namespace dotnet.MediatR.pattern.Handlers
{
    public class GetProductsHandler : IRequestHandler<GetProductsQuery, IEnumerable<Product>>
    {
        private readonly DbContext dbContext;

        public GetProductsHandler(DbContext dbContext) => this.dbContext = dbContext;

        public async Task<IEnumerable<Product>> Handle(GetProductsQuery request,
            CancellationToken cancellationToken) => await this.dbContext.GetAllProducts();
    }
}
