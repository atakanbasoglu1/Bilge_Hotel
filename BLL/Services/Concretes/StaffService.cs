using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Enums;
using BLL.Services.Abstract;
using DataAccess.Entities.Concretes;
using DataAccess.Repositories.Abstract;

namespace BLL.Services.Concretes
{
    public class StaffService : IStaffService
    {
        private readonly IBaseRepository<Staff> _baseRepository;

        public StaffService(IBaseRepository<Staff> baseRepository)
        {
            _baseRepository = baseRepository;
        }
        public async Task<List<Staff>> GetAllStaffAsync()
        {
            return await _baseRepository.GetAllAsync();
        }
        public async Task<Staff> GetStaffByIdAsync(int id)
        {
            return await _baseRepository.GetByIdAsync(id);
        }
        public async Task<StatusMessage> CreateStaffAsync(Staff staff)
        {
            try
            {
                await _baseRepository.CreateAsync(staff);
                return StatusMessage.Success;
            }
            catch (Exception)
            {
                return StatusMessage.Error;
            }
        }
        public async Task<StatusMessage> DeleteStaffAsync(int id)
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
        public async Task<StatusMessage> UpdateStaffAsync(Staff updated)
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
        public async Task<List<Staff>> GetStaffByRoleAsync(string role)
        {
            var allStaff = await _baseRepository.GetAllAsync();
            return allStaff.Where(s => s.Role.Equals(role, StringComparison.OrdinalIgnoreCase)).ToList();

        }
        public async Task<List<Staff>> GetStaffByDepartmentAsync(string department)
        {
            var allStaff = await _baseRepository.GetAllAsync();
            return allStaff.Where(s => s.Department.Equals(department, StringComparison.OrdinalIgnoreCase)).ToList();
        }

    }
}
