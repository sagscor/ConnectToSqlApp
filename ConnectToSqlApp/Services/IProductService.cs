using ConnectToSqlApp.Models;

namespace ConnectToSqlApp.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}