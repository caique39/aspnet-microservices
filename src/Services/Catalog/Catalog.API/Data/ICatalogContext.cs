using MongoDB.Driver;
using Catalog.API.Entities;

namespace Catalog.API.Data
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
