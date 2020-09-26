using Microsoft.EntityFrameworkCore;
using website_dotnet.Models;

namespace website_dotnet.Data
{
    public class BoardContext : DbContext
    {
        public BoardContext (DbContextOptions<BoardContext> options)
            : base(options)
        {
        }

        public DbSet<Board> Board { get; set; }
    }
}