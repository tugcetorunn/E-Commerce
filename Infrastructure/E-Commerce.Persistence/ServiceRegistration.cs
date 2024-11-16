using E_Commerce.Application.Abstractions;
using E_Commerce.Persistence.Concretes;
using E_Commerce.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace E_Commerce.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        { // persistence ta daha bir çok service olabilir bunları ioc container a ekleyebilmemiz için bu extension metodunu oluşturuyoruz.
            // services.AddSingleton<IProductService, ProductService>(); // uygulamanın çalışmaya başladığı andan duruncaya kadar geçen tüm süre boyunca
                                                                         // yalnızca bir kez oluşturulur ve her zaman aynı nesne kullanılır. (addSingletonda)
            // hangi db ye migration uygulayacaksak onunla ilgili server ı bildiriyoruz ve connection string i de ekliyoruz.
            services.AddDbContext<ECommerceDbContext>(options => options.UseNpgsql("Host=localhost;Database=postgres;Username=tt;Password=tt2727;Search Path=ecommerce"));
            // connectionString kodun içinde olmamalı. düzenleyeceğiz. ileride birşeyleri değiştirme ihtimalinde (örn başka bir sunucuya geçilebilir) projeyi yeniden
            // derleyip yayına alma problemi yaşamamak için önden configuration ifadeleri kod içinde değil bir json, xml, txt dosyaları gibi dış kaynaklarda hatta
            // environment larda tutmak doğrudur.
        }
        // bu extension ı oluşturduktan sonra ioc container ı barındıran presentation katmanından çağrılması gerekiyor. (program.cs)
        // uygulamayı ayağa kaldırdığımızda ioc container ayağa kalkacak ve program.cs deki fonksiyon ve daha sonra sonra bu extension çalışacak ve
        // persistence taki service i ekleyecek.
    }
}
