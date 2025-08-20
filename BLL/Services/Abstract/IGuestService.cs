using BLL.Enums;
using DataAccess.Entities.Concretes;

namespace BLL.Services.Abstract
{
    public interface IGuestService
    {
        Task<List<Guest>> GetAllGuestsAsync();
        Task<Guest> GetGuestByIdAsync(int id);
        Task<StatusMessage> CreateGuestAsync(Guest guest);
        Task<StatusMessage> DeleteGuestAsync(int id);
        Task<StatusMessage> UpdateGuestAsync(Guest guest);
    }
}
