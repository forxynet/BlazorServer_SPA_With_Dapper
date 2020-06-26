using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorServer_SPA_With_Dapper.Data {
    public interface IEmployeeService {
        Task<IEnumerable<EmployeeModel>> GetEmployees();
        Task<bool> CreateEmployee(Employee employee);
        Task<bool> EditEmployee(int id, EmployeeModel employee);
        Task<EmployeeModel> SingleEmployee(int id);
        Task<bool> DeleteEmployee(int id);
    }
}
