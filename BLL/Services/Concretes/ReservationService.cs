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
    public class ReservationService : IReservationService
    {
        private readonly IBaseRepository<Reservation> _baseRepository;

        public ReservationService(IBaseRepository<Reservation> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<List<Reservation>> GetAllReservationsAsync()
        {
            return await _baseRepository.GetAllAsync();
        }
        public async Task<Reservation> GetReservationByIdAsync(int id)
        {
            return await _baseRepository.GetByIdAsync(id);
        }
        public async Task<StatusMessage> CreateReservationAsync(Reservation reservation)
        {
            try
            {
                await _baseRepository.CreateAsync(reservation);
                return StatusMessage.Success;
            }
            catch (Exception)
            {
                return StatusMessage.Error;
            }
        }
        public async Task<StatusMessage> DeleteReservationAsync(int id)
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
        public async Task<StatusMessage> UpdateReservationAsync(Reservation updated)
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
        public async Task<List<Reservation>> GetReservationsByGuestIdAsync(int guestId)
        {
            return await _baseRepository.GetByConditionAsync(r => r.GuestId == guestId);
        }
        public async Task<List<Reservation>> GetReservationsByRoomIdAsync(int roomId)
        {
            return await _baseRepository.GetByConditionAsync(r => r.RoomId == roomId);
        }
        public async Task<List<Reservation>> GetReservationsByDateRangeAsync(DateTime startDate, DateTime endDate)
        {
            return await _baseRepository.GetByConditionAsync(r => r.CheckIn >= startDate && r.CheckOut <= endDate);

        }
    }
}
