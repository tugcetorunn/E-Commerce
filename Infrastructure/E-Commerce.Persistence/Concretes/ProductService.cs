using E_Commerce.Application.Abstractions;
using E_Commerce.Domain.Entities;

namespace E_Commerce.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
            => new() // normalde veritabanından alıyoruz fakat şuan onion architecture simülasyonu yaptığımız için yandaki target type new özelliği ile
                     // referansı belli olan nesne oluştururken kullanabildiğimiz yapıyla örnek obje oluşturuyoruz. yani normalde metod içinde
                     // return list a = new list() yaparken tipi belli olan bu nesne oluşturmalarda direk new() ile oluşturabiliyoruz. (c# 9 dan sonra)
            {
                new() // burada da normalde new product() ile oluştururken tip zaten metodda belli olduğu için içeride product oluşturulacağı belli
                      // o yüzden sadece new() ile yapabiliyoruz.
                {
                    Id = Guid.NewGuid(),
                    Name = "Product 1",
                    CreatedDate = DateTime.Now,
                    Price = 200,
                    Stock = 10
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Product 2",
                    CreatedDate = DateTime.Now,
                    Price = 300,
                    Stock = 10
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Product 3",
                    CreatedDate = DateTime.Now,
                    Price = 400,
                    Stock = 10
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Product 4",
                    CreatedDate = DateTime.Now,
                    Price = 500,
                    Stock = 10
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Product 5",
                    CreatedDate = DateTime.Now,
                    Price = 600,
                    Stock = 10
                }

            };
    }
}
