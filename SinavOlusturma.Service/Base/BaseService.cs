using Microsoft.Extensions.DependencyInjection;
using SinavOlusturma.Core;
using SinavOlusturma.Core.Entity.Enum;
using SinavOlusturma.Core.Service;
using SinavOlusturma.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using SinavOlusturma.Service.Tools;

namespace SinavOlusturma.Service.Base
{
    public class BaseService<T> : ICoreService<T> where T : CoreEntity
    {
        protected ProjectContext _context;
        public BaseService()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddDbContextService();
            ServiceProvider provider = services.BuildServiceProvider();

            _context = provider.GetService<ProjectContext>();
        }
        public void Add(T item)
        {
            try
            {
                item.Status = Status.Active;
                _context.Set<T>().Add(item);
                Save();
            }
            catch (Exception ex)
            {
                ;
            }
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetDefault(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression).ToList();
        }
        public void Update()
        {
            //T updated = GetById(item.Id);
            //DbEntityEntry entry = _context.Entry(updated);
            //entry.CurrentValues.SetValues(item);
            //Save();
        }

        public void Remove(T item)
        {
            throw new NotImplementedException();
        }

        public int Save()
        {
            return _context.SaveChanges();
        }




    }
}
