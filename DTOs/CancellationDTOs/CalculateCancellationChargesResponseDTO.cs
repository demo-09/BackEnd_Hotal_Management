using System.ComponentModel.DataAnnotations;

namespace Asp.Net_WebApi.DTOs.CancellationDTOs
{
    public class CalculateCancellationChargesRequestDTO
    {
        [Required(ErrorMessage = "ReservationID is required.")]
        public int ReservationID { get; set; }

        [Required(ErrorMessage = "RoomsCancelled list cannot be empty.")]
        [MinLength(1, ErrorMessage = "At least one room must be cancelled.")]
        public List<int> RoomsCancelled { get; set; }
    }
}