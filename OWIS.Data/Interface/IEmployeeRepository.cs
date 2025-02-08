using OWIS.Data.Entities;

namespace OWIS.Data.Interface
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);
    }
}
