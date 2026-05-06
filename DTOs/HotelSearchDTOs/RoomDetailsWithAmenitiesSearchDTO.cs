namespace Asp.Net_WebApi.DTOs.HotelSearchDTOs
{
    public class RoomDetailsWithAmenitiesSearchDTO
    {
        public RoomSearchDTO Room { get; set; }
        public List<AmenitySearchDTO> Amenities { get; set; }
    }
}