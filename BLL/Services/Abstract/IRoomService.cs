using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Enums;
using DataAccess.Entities.Concretes;

namespace BLL.Services.Abstract
{
    public interface IRoomService
    {
        Task<List<Room>> GetAllRoomsAsync();
        Task<Room> GetRoomByIdAsync(int id);
        Task<StatusMessage> CreateRoomAsync(Room room);
        Task<StatusMessage> DeleteRoomAsync(int id);
        Task<StatusMessage> UpdateRoomAsync(Room room);
        Task<List<Room>> GetAvailableRoomsAsync(DateTime checkIn, DateTime checkOut);
    }
}
