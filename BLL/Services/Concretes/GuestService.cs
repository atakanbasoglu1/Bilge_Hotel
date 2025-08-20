using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Enums;
using BLL.Services.Abstract;
using DataAccess.Entities.Concretes;
using DataAccess.Repositories.Abstract;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace BLL.Services.Concretes
{
   public class GuestService : IGuestService
    {
        private readonly IBaseRepository<Guest> _baseRepository;

        public GuestService(IBaseRepository<Guest> baseRepository)
        {
            _baseRepository = baseRepository;
        }
        public async Task<List<Guest>> GetAllGuestsAsync()
        {
            return await _baseRepository.GetAllAsync();
        }
        public async Task<Guest> GetGuestByIdAsync(int id)
        {
            return await _baseRepository.GetByIdAsync(id);
        }
        public async Task<StatusMessage> CreateGuestAsync(Guest guest)
        {
            try
            {
                await _baseRepository.CreateAsync(guest);
                return StatusMessage.Success;
            }
            catch (Exception)
            {
                return StatusMessage.Error;
            }
        }
        public async Task<StatusMessage> DeleteGuestAsync(int id)
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
        public async Task<StatusMessage> UpdateGuestAsync(Guest updated)
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


    }
}
