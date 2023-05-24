using Book.DataAccess.Data;
using Book.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public ICategoryRepository CategoryRepo { get; private set; }
        public IProductRepository ProductRepo { get; private set; }


        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            CategoryRepo = new CategoryRepository(_db);
            ProductRepo= new ProductRepository(_db);
        }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
