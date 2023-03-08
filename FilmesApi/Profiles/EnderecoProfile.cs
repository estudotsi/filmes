using AutoMapper;
using FilmesApi.Data.Dtos.Endereco;
using FilmesApi.Data.Dtos.Filme;
using FilmesApi.Models;

namespace FilmesApi.Profiles
{
    public class EnderecoProfile : Profile
    {
        public EnderecoProfile()
        {
            CreateMap<CreateEnderecoDto, Endereco>();
            CreateMap<UpdateEnderecoDto, Endereco>();
            CreateMap<Endereco, UpdateEnderecoDto>();
            CreateMap<Endereco, ReadEnderecoDto>();
        }
    }
}
