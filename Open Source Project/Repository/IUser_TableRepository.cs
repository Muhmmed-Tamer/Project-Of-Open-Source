using Open_Source_Project.Models;

namespace Open_Source_Project.Repository
{
    public interface IUser_TableRepository  :IRepository<User_Table>
    {
        List<User_Table> BookedTableByUser(string Id);
        void RemoveByEntity(User_Table entity);
    }
}
