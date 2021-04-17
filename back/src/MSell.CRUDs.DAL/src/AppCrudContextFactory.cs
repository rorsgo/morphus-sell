using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace MSell.CRUDs.DAL.src
{
    class AppCrudContextFactory : IDesignTimeDbContextFactory<AppCrudContext>
    {
        public AppCrudContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<AppCrudContext> builder = new DbContextOptionsBuilder<AppCrudContext>();
            string connectionString = "Host=192.168.15.12;Database=morphussell;Username=admin;Password=batata";
            builder.UseNpgsql(connectionString);
            return new AppCrudContext(builder.Options);
        }
    }
}
