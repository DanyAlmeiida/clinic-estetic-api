namespace ClinicEsteticManagement.Application.DTOs.Client
{
    public class CreateClientDto : IClientDto
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string JobOccupation { get; set; }
        public string Observations { get; set; }
    }
}
