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
    public class DepartmentService : IDepartmentService
    {
        private readonly IBaseRepository<Department> _baseRepository;
        public DepartmentService(IBaseRepository<Department> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<StatusMessage> CreateDepartmentAsync(string department)
        {

            try
            {
                var newDepartment = new Department { DepartmentName = department };
                await _baseRepository.CreateAsync(newDepartment);
                return StatusMessage.Success;
            }
            catch (Exception)
            {
                return StatusMessage.Error;
            }

        }

        public Task<StatusMessage> DeleteDepartmentAsync(int id)
        {

            try
            {
                _baseRepository.DeleteAsync(id);
                return Task.FromResult(StatusMessage.Success);
            }
            catch (Exception)
            {
                return Task.FromResult(StatusMessage.Error);
            }
        }

        public Task<List<string>> GetAllDepartmentsAsync()
        {

            try
            {
                var departments = _baseRepository.GetAllAsync().Result;
                return Task.FromResult(departments.Select(d => d.DepartmentName).ToList());
            }
            catch (Exception)
            {
                return Task.FromResult(new List<string>());
            }
        }

        public Task<string> GetDepartmentByIdAsync(int id)
        {

            try
            {
                var department = _baseRepository.GetByIdAsync(id).Result;
                return Task.FromResult(department?.DepartmentName ?? string.Empty);
            }
            catch (Exception)
            {
                return Task.FromResult(string.Empty);
            }
        }

        public Task<List<string>> GetDepartmentsByStaffIdAsync(int staffId)
        {

            try
            {
                var staffDepartments = _baseRepository.GetByConditionAsync(d => d.Staffs.Any(s => s.ID == staffId)).Result;
                return Task.FromResult(staffDepartments.Select(d => d.DepartmentName).ToList());
            }
            catch (Exception)
            {
                return Task.FromResult(new List<string>());
            }
        }


        public async Task<StatusMessage> UpdateDepartmentAsync(Department department)
        {
            try
            {
                await _baseRepository.UpdateAsync(department);
                return StatusMessage.Success;
            }
            catch (Exception)
            {
                return StatusMessage.Error;
            }
        }
    }
}
