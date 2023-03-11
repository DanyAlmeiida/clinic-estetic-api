namespace ClinicEsteticManagement.Application.DTOs.Client
{
    public interface IClientDto
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string JobOccupation { get; set; }
        public string Observations { get; set; }
    }
}
