using System.ComponentModel.DataAnnotations;

namespace Asp.Net_WebApi.DTOs.RoomAmenityDTOs
{
    public class RoomAmenityDTO
    {
        [Required]
        public int RoomTypeID { get; set; }
        [Required]
        public int AmenityID { get; set; }
    }
}