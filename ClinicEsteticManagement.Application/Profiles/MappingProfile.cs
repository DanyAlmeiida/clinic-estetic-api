using AutoMapper;
using ClinicEsteticManagement.Application.DTOs.Client;
using ClinicEsteticManagement.Application.DTOs.ClinicalData;
using ClinicEsteticManagement.Domain;
using ClinicEsteticManagement.Domain.ClinicalData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicEsteticManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region clients
            CreateMap<Client, ClientDto>()
             .ForMember(dest => dest.Id , opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.ClientId , opt => opt.MapFrom(src => src.ClientId))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.BirthDate, opt => opt.MapFrom(src => src.BirthDate))
            .ForMember(dest => dest.JobOccupation, opt => opt.MapFrom(src => src.JobOccupation))
            .ForMember(dest => dest.Observations , opt => opt.MapFrom(src => src.Observations))
            .ForMember(dest => dest.ModifiedAt , opt => opt.MapFrom(src => src.ModifiedAt))
            .ForMember(dest => dest.CreationDate, opt => opt.MapFrom(src => src.CreationDate))
            .ForMember(dest => dest.clinicalInformation, opt => opt.MapFrom(src => src.ClinicalInformations))
            .ReverseMap();

            CreateMap<Client, CreateClientDto>().ReverseMap();
            CreateMap<UpdateClientDto, Client>().ReverseMap();

            CreateMap<ClinicalInformation, ClinicalInformationDto>()
                .ForMember(dest => dest.Medicines, opt => opt.MapFrom(src => src.Medicines))
            .ForMember(dest => dest.GynecologicalConditions, opt => opt.MapFrom(src => src.GynecologicalConditions))
            .ReverseMap();

            CreateMap<ClinicalInformation, UpdateClinicalInformationDto>()
                .ForMember(dest => dest.Medicines, opt => opt.MapFrom(src => src.Medicines))
            .ForMember(dest => dest.GynecologicalConditions, opt => opt.MapFrom(src => src.GynecologicalConditions))
            .ReverseMap();

            CreateMap<GynecologicalConditions, GynecologicalConditionsDto>().ReverseMap();
            CreateMap<ClinicalInformation, CreateClinicalInformationDto>().ReverseMap();
            #endregion
        }
    }
}
