using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SinavOlusturma.Core.Service
{
    public interface ICoreService<T> where T : CoreEntity
    {
        void Add(T item);
        void Remove(T item);
        T GetById(int id);
        List<T> GetDefault(Expression<Func<T,bool>> expression);
        int Save();

        
    }
}
