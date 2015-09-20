using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Domain.Abstract;
using Store.Domain.Entities;

namespace Store.Domain.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        private EFDbContext context = new EFDbContext();

        public IQueryable<Product> Products
        {
            get { return context.Products; }
        }

        public void CreateProduct(Product prod)
        {
            context.Products.Add(prod);
            context.SaveChanges();
        }

        public void Delete(int Id)
        {
            context.Products.Remove(context.Products.Find(Id));
            context.SaveChanges();
        }
    }
}
