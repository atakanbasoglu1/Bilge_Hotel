using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Enums;
using DataAccess.Entities.Concretes;


namespace BLL.Services.Abstract
{
    public interface IShiftAssignmentService
    {
        Task<List<ShiftAssignment>> GetAllShiftsAsync();
        Task<ShiftAssignment> GetShiftByIdAsync(int id);
        Task<StatusMessage> CreateShiftAsync(ShiftAssignment shift);
        Task<StatusMessage> DeleteShiftAsync(int id);
        Task<StatusMessage> UpdateShiftAsync(ShiftAssignment shift);
        Task<List<ShiftAssignment>> GetShiftsByStaffIdAsync(int StaffId);
        Task<List<ShiftAssignment>> GetShiftsByDateRangeAsync(DateTime IsOffDay, DateTime IsOvertime);
    }
}
