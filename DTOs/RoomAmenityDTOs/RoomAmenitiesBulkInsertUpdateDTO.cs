using System.ComponentModel.DataAnnotations;

namespace Asp.Net_WebApi.DTOs.RoomAmenityDTOs
{
    public class RoomAmenitiesBulkInsertUpdateDTO
    {
        [Required]
        public int RoomTypeID { get; set; }
        [Required]
        public List<int> AmenityIDs { get; set; }
    }
}