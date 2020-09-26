using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using website_dotnet.Data;
using System;
using System.Linq;

namespace website_dotnet.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BoardContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BoardContext>>()))
            {
                // Look for any movies.
                if (context.Board.Any())
                {
                    return;   // DB has been seeded
                }

                context.Board.AddRange(
                    new Board
                    {
                        Title = "Test Board 01",
                        CreatedAt = DateTime.Parse("1989-2-12"),
                        Text = "This is a test board 01",
                        Tags = "",
                    },

                    new Board
                    {
                        Title = "Test Board 02",
                        CreatedAt = DateTime.Parse("1990-2-12"),
                        Text = "This is a test board 02",
                        Tags = "",
                    },

                    new Board
                    {
                        Title = "Test Board 03",
                        CreatedAt = DateTime.Parse("2001-2-12"),
                        Text = "This is a test board 03",
                        Tags = "",
                    },

                    new Board
                    {
                        Title = "Test Board 04",
                        CreatedAt = DateTime.Parse("2010-2-12"),
                        Text = "This is a test board 04",
                        Tags = "",
                    }

                );
                context.SaveChanges();
            }
        }
    }
}