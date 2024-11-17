using Microsoft.EntityFrameworkCore;
using PlatformService.Models;

namespace PlatformService.Data
{
    public static class PrepDb
    {
        public static void PrePopulation(IApplicationBuilder app, bool IsProd)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>(), IsProd);
            }
        }

        public static void SeedData(AppDbContext context, bool IsProd)
        {
            if (IsProd)
            {
                Console.WriteLine("---> Attempting to apply migrations....");
                try
                {
                    context.Database.Migrate();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"---> Could not run migrations: {ex.Message}");
                }
            }

            if (!context.platforms.Any())
            {
                Console.WriteLine("----> Seeding Data....");
                context.platforms.AddRange(
                    new Platform() { Name = "Dot Net", Publisher = "Microsoft", Cost = "Free" },
                    new Platform() { Name = "C#", Publisher = "Microsoft", Cost = "Free" },
                    new Platform() { Name = "Angular", Publisher = "Google", Cost = "Free" }
                );
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("----> We alredy have Data....");
            }
        }
    }
}
