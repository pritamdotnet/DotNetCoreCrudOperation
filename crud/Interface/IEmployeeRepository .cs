using crud.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace crud.Interface
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployees();
    }

}
