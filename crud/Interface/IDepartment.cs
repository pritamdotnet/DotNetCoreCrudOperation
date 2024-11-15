using crud.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace crud.Interface
{
    public interface IDepartment
    {
        Task<IEnumerable<Department>> GetDepartments();
        Task AddDepartment(Department department);
    }
}
