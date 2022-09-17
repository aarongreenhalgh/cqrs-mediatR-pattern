using dotnet.MediatR.pattern.Commands;
using MediatR;

namespace dotnet.MediatR.pattern.Handlers
{
    public class AddProductHandler : IRequestHandler<AddProductCommand, Product>
    {
        private readonly DbContext _dbContext;

        public AddProductHandler(DbContext dbContext) => _dbContext = dbContext;

        public async Task<Product> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            await _dbContext.AddProduct(request.Product);

            return request.Product;
        }
    }
}
