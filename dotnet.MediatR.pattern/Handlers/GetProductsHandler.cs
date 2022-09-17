using dotnet.MediatR.pattern.Queries;
using MediatR;

namespace dotnet.MediatR.pattern.Handlers
{
    public class GetProductsHandler : IRequestHandler<GetProductsQuery, IEnumerable<Product>>
    {
        private readonly DbContext _dbContext;

        public GetProductsHandler(DbContext dbContext) => _dbContext = dbContext;

        public async Task<IEnumerable<Product>> Handle(GetProductsQuery request,
            CancellationToken cancellationToken) => await _dbContext.GetAllProducts();
    }
}
