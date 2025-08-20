using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Enums;
using DataAccess.Entities.Concretes;

namespace BLL.Services.Abstract
{
    public interface IReservationService
    {
        Task<List<Reservation>> GetAllReservationsAsync();
        Task<Reservation> GetReservationByIdAsync(int id);
        Task<StatusMessage> CreateReservationAsync(Reservation reservation);
        Task<StatusMessage> DeleteReservationAsync(int id);
        Task<StatusMessage> UpdateReservationAsync(Reservation reservation);
        Task<List<Reservation>> GetReservationsByGuestIdAsync(int guestId);
        Task<List<Reservation>> GetReservationsByRoomIdAsync(int roomId);
        Task<List<Reservation>> GetReservationsByDateRangeAsync(DateTime CheckIn, DateTime CheckOut);
    }
}
