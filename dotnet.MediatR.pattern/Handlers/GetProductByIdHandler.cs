using dotnet.MediatR.pattern.Queries;
using MediatR;

namespace dotnet.MediatR.pattern.Handlers
{
    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly DbContext _dbContext;

        public GetProductByIdHandler(DbContext dbContext) =>  _dbContext = dbContext;

        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken) =>
            await _dbContext.GetProductById(request.Id);

    }
}