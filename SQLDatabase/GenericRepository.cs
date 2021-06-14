using Application;
using Application.Repository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace SQLDatabase
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private PopisContext _context = null;
        private DbSet<T> _table = null;

        public GenericRepository()
        {
            _context = new PopisContext();
            _table = _context.Set<T>();
        } 

        public void Delete(int id)
        {
            var entity = _table.Find(id);
            _table.Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _table.ToList();
        }

        public T GetById(int id)
        {
            return _table.Find(id);
        }

        public void Insert(T obj)
        {
            _table.Add(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T obj)
        {
            _table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
            Save();
        }
    }
}
