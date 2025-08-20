using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Enums;
using DataAccess.Entities.Concretes;

namespace BLL.Services.Abstract
{
    public interface IDepartmentService
    {
        Task<List<string>> GetAllDepartmentsAsync();
        Task<string> GetDepartmentByIdAsync(int id);
        Task<StatusMessage> CreateDepartmentAsync(string department);
        Task<StatusMessage> DeleteDepartmentAsync(int id);
        Task<StatusMessage> UpdateDepartmentAsync(Department department);
        Task<List<string>> GetDepartmentsByStaffIdAsync(int staffId);
    }
}
