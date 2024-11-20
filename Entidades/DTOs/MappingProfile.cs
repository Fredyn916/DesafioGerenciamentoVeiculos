using AutoMapper;

namespace Entidades.DTOs;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateVeiculoDTO, Carro>().ReverseMap();
        CreateMap<CreateVeiculoDTO, Caminhao>().ReverseMap();
    }
}