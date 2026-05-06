using System.ComponentModel.DataAnnotations;

namespace Asp.Net_WebApi.DTOs.CancellationDTOs
{
    public class ProcessRefundRequestDTO
    {
        [Required(ErrorMessage = "CancellationRequestID is required.")]
        public int CancellationRequestID { get; set; }

        [Required(ErrorMessage = "ProcessedByUserID is required.")]
        public int ProcessedByUserID { get; set; }

        [Required(ErrorMessage = "RefundMethodID is required.")]
        public int RefundMethodID { get; set; }
    }
}