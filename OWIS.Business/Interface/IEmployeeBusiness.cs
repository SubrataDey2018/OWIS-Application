using OWIS.Business.BusinessData;

namespace OWIS.Business.Interface
{
    public interface IEmployeeBusiness
    {
        EmployeeData GetEmployee(int id);
    }
}
