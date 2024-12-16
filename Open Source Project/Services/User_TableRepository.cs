using Microsoft.EntityFrameworkCore;
using Open_Source_Project.Data;
using Open_Source_Project.Models;
using Open_Source_Project.Repository;

namespace Open_Source_Project.Services
{
    public class User_TableRepository : IUser_TableRepository
    {
        ContextData Context;
        public User_TableRepository(ContextData Context)
        {
            this.Context = Context;
        }
        public void Add(User_Table entity)
        {
            Context.Add(entity);
        }

        public List<User_Table> BookedTableByUser(string Id)
        {
            return Context.User_Tables.Include(U=>U.Table).Where(UI=>UI.ApplicationUserId == Id).ToList();
        }

        public void Delete(int id)
        {
            Context.Remove(GetById(id));
        }

        public List<User_Table> GetAll()
        {
            return Context.User_Tables.Include(T=>T.Table).ToList();
        }

        public User_Table GetById(int id)
        {
            return Context.User_Tables.FirstOrDefault(T => T.TableId == id);
        }

        public void RemoveByEntity(User_Table entity)
        {
            Context.Remove(entity);
        }

        public void Save()
        {
            Context.SaveChanges();
        }

        public void Update(User_Table entity)
        {
            Context.Update(entity);
        }
    }
}
