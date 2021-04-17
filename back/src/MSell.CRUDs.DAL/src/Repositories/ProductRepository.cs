using Microsoft.EntityFrameworkCore;
using MSell.CRUDs.Share.src.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSell.CRUDs.DAL.src.Repositories
{
    public class ProductRepository
    {
        private readonly AppCrudContext _context;
        private readonly DbSet<Product> _dbSet;

        public ProductRepository()
        {
            _context = new AppCrudContextFactory().CreateDbContext(null);
            _dbSet = _context.Set<Product>();
        }

        public IList<Product> GetAll()
        {
            return _dbSet.AsNoTracking<Product>().ToList();
        }

        public void New(Product product)
        {
            _dbSet.Add(product);
            _context.SaveChanges();
        }
    }
}
