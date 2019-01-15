using LibraryManagementCourse.Data.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementCourse.Data
{
    public static class DbInitializer
    {
        public static void Seed(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<LibraryDbContext>();


                // Add Customers
                var justin = new Customer { Name = "shero Noon" };

                var willie = new Customer { Name = "Abo  ruby" };

                var leoma = new Customer { Name = "Leoma  Gosse" };
                var ana = new Customer { Name = "na jons" };

            

                var kateb = new Customer { Name = "sh hba" };

                context.Customers.Add(justin);
                context.Customers.Add(willie);
                context.Customers.Add(ana);
                context.Customers.Add(kateb);
                context.Customers.Add(leoma);


                // Add Author
                var authorDeMarco = new Author
                {
                    Name = "M J DeMarco",
                    Books = new List<Book>()
                {
                    new Book { Title = "The Millionaire Fastlane" },
                    new Book { Title = "Unscripted" }
                }
                };
                var shehrmanon = new Author
                {
                    Name = "shehrmano",
                    Books = new List<Book>()
                {
                    new Book { Title = "new book" },
                    new Book { Title = "Unscripted" }
                }
                };

                var authorCardone = new Author
                {
                    Name = "Grant Cardone",
                    Books = new List<Book>()
                {
                    new Book { Title = "The 10X Rule"},
                    new Book { Title = "If You're Not First, You're Last"},
                    new Book { Title = "Sell To Survive"}
                }
                };

                context.Authors.Add(authorDeMarco);
                context.Authors.Add(authorCardone);
                context.Authors.Add(shehrmanon);

                context.SaveChanges();
            }
        }
    }
}