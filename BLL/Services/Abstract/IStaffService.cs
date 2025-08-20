using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Enums;
using DataAccess.Entities.Concretes;

namespace BLL.Services.Abstract
{
    public interface IStaffService
    {
        Task<List<Staff>> GetAllStaffAsync();
        Task<Staff> GetStaffByIdAsync(int id);
        Task<StatusMessage> CreateStaffAsync(Staff staff);
        Task<StatusMessage> DeleteStaffAsync(int id);
        Task<StatusMessage> UpdateStaffAsync(Staff staff);
        Task<List<Staff>> GetStaffByRoleAsync(string role);

        Task<List<Staff>> GetStaffByDepartmentAsync(string department);

    }
}
