using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IService<T>
    {
        public void Add(T p);
        public void Delete(T p);
        public void Update(T p);
        List<T> List();
        List<T> List(Expression<Func<T, bool>> filter);
        T GetById(int id);



    }
}
