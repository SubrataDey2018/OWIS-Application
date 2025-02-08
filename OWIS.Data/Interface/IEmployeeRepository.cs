using OWIS.Data.Entities;

namespace OWIS.Data.Interface
{
    public interface IEmployeeRepository
    {
        Employee GetEmployeeById(int id);
    }
}
