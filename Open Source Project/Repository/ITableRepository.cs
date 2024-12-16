using Open_Source_Project.Models;

namespace Open_Source_Project.Repository
{
    public interface ITableRepository  : IRepository<Table>
    {
        List<Table> GetTableIsAvailable();
    }
}
