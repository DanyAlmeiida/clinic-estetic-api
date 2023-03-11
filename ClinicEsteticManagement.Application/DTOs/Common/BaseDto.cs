namespace ClinicEsteticManagement.Application.DTOs.Common
{
    public class BaseDto
    {
        public Guid Id { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
