using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Diet.BLL.Manager.Abstarct
{
    public interface IGenaricManager<TModel>
    {
        void Add(TModel obj);
        void Update(TModel obj);
        void Delete(TModel obj);
        void Remove(TModel obj);
        TModel GetById(int id);
        ICollection<TModel> GetAll();
        ICollection<TModel> Search(Expression<Func<TModel, bool>> perdicate);
    }
}
