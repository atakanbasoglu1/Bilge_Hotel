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
    public class RoomService:IRoomService
    {
        private readonly IBaseRepository<Room> _baseRepository;

        public RoomService(IBaseRepository<Room> baseRepository)
        {
            _baseRepository = baseRepository;
        }
        public async Task<List<Room>> GetAllRoomsAsync()
        {
            return await _baseRepository.GetAllAsync();
        }
        public async Task<Room> GetRoomByIdAsync(int id)
        {
            return await _baseRepository.GetByIdAsync(id);
        }
        public async Task<StatusMessage> CreateRoomAsync(Room room)
        {
            try
            {
                await _baseRepository.CreateAsync(room);
                return StatusMessage.Success;
            }
            catch (Exception)
            {
                return StatusMessage.Error;
            }
        }
        public async Task<StatusMessage> DeleteRoomAsync(int id)
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
        public async Task<StatusMessage> UpdateRoomAsync(Room updated)
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

        public async Task<List<Room>> GetAvailableRoomsAsync(DateTime CheckIn, DateTime CheckOut)
        {
            var allRooms = await _baseRepository.GetAllAsync();
            var reservations = await _baseRepository.GetByConditionAsync(r => r.CheckIn < CheckOut && r.CheckOut > CheckIn);
            var reservedRoomIds = reservations.Select(r => r.RoomID).ToList();
            return allRooms.Where(r => !reservedRoomIds.Contains(r.ID)).ToList();
        }
    }

}
