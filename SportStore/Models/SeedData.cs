using Microsoft.EntityFrameworkCore;
namespace SportStore.Models
{
	public class SeedData
	{
		public static void EnsurePopulated(IApplicationBuilder app)
		{
			StoreDbContext context = app.ApplicationServices.CreateScope()
				.ServiceProvider.GetRequiredService<StoreDbContext>();

			if(context.Database.GetPendingMigrations().Any()) {
				context.Database.Migrate(); }

			if(!context.Products.Any()) {
				context.Products.AddRange(
					
					new Product
					{
						Name= "Меч",Description = "Полуторный Игрушечный",
						Category = "мечи",Price =600
					},
					new Product
					{
						Name = "Лодка",
						Description = "Пластмассовая не удобная",
						Category = "Рыболовство",
						Price = 1500
					},
					new Product
					{
						Name = "Спасательный жилет",
						Description = "Бело-рыжий",
						Category = "Рыболовство",
						Price = 300
					},
					new Product
					{
						Name = "Гантеля",
						Description = "2кг ",
						Category = "Спорт",
						Price = 100
					}, new Product
                    {
                        Name = "Гантеля",
                        Description = "4кг ",
                        Category = "Спорт",
                        Price = 200
                    }, new Product
                    {
                        Name = "Гантеля",
                        Description = "6кг ",
                        Category = "Спорт",
                        Price = 600
                    },
                    new Product
					{
						Name = "Эспандер",
						Description = "Пружинный",
						Category = "Спорт",
						Price = 220
					},
					new Product
					{
						Name = "Турник",
						Description = "Настенный с крепежем",
						Category = "Спорт",
						Price = 800
					},
					new Product
					{
						Name = "Лыжи",
						Description = "Беговые",
						Category = "Спорт",
						Price = 12000
					},
                    new Product
                    {
                        Name = "Шапка Синяя для Бассейна ",
                        Description = "Бассейн",
                        Category = "Спорт",
                        Price = 300
                    }

                    );
				context.SaveChanges();
			}

		}
		}
	}

