using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MacauTravelling.Data;

namespace MacauTravelling.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MacauTravellingContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MacauTravellingContext>>()))
            {
                // Look for any movies.
                if (context.Tourists.Any())
                {
                    return;   // DB has been seeded
                }
                else
                {
                    context.Tourists.AddRange(
                    new Tourist
                    {
                        TouristName = "Luo Dacheng",
                        Password = "123123"
                    },

                    new Tourist
                    {
                        TouristName = "Ye Caiwei",
                        Password = "123123"
                    }

                    
                );
                    context.SaveChanges();
                }
                
            }
        }
    }
}
