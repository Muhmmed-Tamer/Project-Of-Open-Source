using Open_Source_Project.Data;
using Open_Source_Project.Models;
using Open_Source_Project.Repository;
using System.Security.Cryptography;
namespace Open_Source_Project.Services
{
    public class TableRepository : ITableRepository
    {
        ContextData Context;
        public TableRepository(ContextData Context)
        {
            this.Context = Context;
        }
        public void Add(Table entity)
        {
            Context.Add(entity);
        }

        public void Delete(int id)
        {
            Context.Remove(GetById(id));
        }

        public List<Table> GetAll()
        {
            return Context.Tables.ToList();
        }

        public Table GetById(int id)
        {
            return Context.Tables.FirstOrDefault(T => T.Id == id);
        }

        public List<Table> GetTableIsAvailable()
        {
            return Context.Tables.Where(T=>T.Status == Utility.TableAvailable).ToList();
        }

        public void Save()
        {
            Context.SaveChanges();
        }

        public void Update(Table entity)
        {
            Context.Update(entity);
        }
    }
}
