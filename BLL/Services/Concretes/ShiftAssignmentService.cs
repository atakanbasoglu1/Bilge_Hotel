using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Enums;
using DataAccess.Entities.Concretes;
using DataAccess.Repositories.Abstract;

namespace BLL.Services.Concretes
{
    public class ShiftAssignmentService
    {
        private readonly IBaseRepository<ShiftAssignment> _baseRepository;

        public ShiftAssignmentService(IBaseRepository<ShiftAssignment> baseRepository)
        {
            _baseRepository = baseRepository;
        }
        public async Task<List<ShiftAssignment>> GetAllShiftsAsync()
        {
            return await _baseRepository.GetAllAsync();
        }
        public async Task<ShiftAssignment> GetShiftByIdAsync(int id)
        {
            return await _baseRepository.GetByIdAsync(id);
        }
        public async Task<StatusMessage> CreateShiftAsync(ShiftAssignment shift)
        {
            try
            {
                await _baseRepository.CreateAsync(shift);
                return StatusMessage.Success;
            }
            catch (Exception)
            {
                return StatusMessage.Error;
            }
        }
        public async Task<StatusMessage> DeleteShiftAsync(int id)
        {
            try
            {
                await _baseRepository.DeleteAsync(id);
                return StatusMessage.Success;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusMessage.Error;
            }
        }
        public async Task<StatusMessage> UpdateShiftAsync(ShiftAssignment updated)
        {
            try
            {
                await _baseRepository.UpdateAsync(updated);
                return StatusMessage.Success;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusMessage.Error;
            }
        }

        public async Task<List<ShiftAssignment>> GetShiftsByStaffIdAsync(int staffId)
        {
            return await _baseRepository.GetByConditionAsync(s => s.StaffId == staffId);
        }
        public async Task<List<ShiftAssignment>> GetShiftsByDateRangeAsync(DateTime startDate, DateTime endDate)
        {
            return await _baseRepository.GetByConditionAsync(s => s.IsOffDay >= startDate && s.IsOvertime <= endDate);
        }
    }
}
