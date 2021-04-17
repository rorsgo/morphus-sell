using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MSell.CRUDs.DAL.src
{
    class AppCrudContextFactory : IDesignTimeDbContextFactory<AppCrudContext>
    {
        public AppCrudContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<AppCrudContext> builder = new DbContextOptionsBuilder<AppCrudContext>();
            /*Alterar para Pegar do AppSettings*/
            string connectionString = "Host=192.168.15.12;Database=morfussell2;Username=admin;Password=batata";
            builder.UseNpgsql(connectionString);
            return new AppCrudContext(builder.Options);
        }
    }
}
