using BusinessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IService<Product>
    {
        GenericRepository<Product> _product = new GenericRepository<Product>();
        Product _singleProduct;

        public void Add(Product p)
        {
            _product.Insert(p);
        }

        public void Delete(Product p)
        {
            _product.Delete(p);
        }

        public Product GetById(int id)
        {
            return _product.Get(x => x.Id == id);
        }

        public List<Product> List()
        {
            return _product.List();
        }

        public List<Product> List(Expression<Func<Product, bool>> filter)
        {
            return _product.List(filter);
        }

        public void Update(Product p)
        {
            _product.Update(p);
        }
        public void Buy(int id, int quantity)
        {
            _singleProduct = GetById(id);
            _singleProduct.Quantity = _singleProduct.Quantity - quantity;
            Update(_singleProduct);
        }
    }
}
