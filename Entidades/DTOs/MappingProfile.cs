using AutoMapper;

namespace Entidades.DTOs;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateVeiculoDTO, AddVeiculoDTO>().ReverseMap();
        CreateMap<AddVeiculoDTO, Carro>().ReverseMap();
        CreateMap<AddVeiculoDTO, Caminhao>().ReverseMap();
    }
}