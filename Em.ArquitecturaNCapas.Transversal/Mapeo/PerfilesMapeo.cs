using AutoMapper;
using Em.ArquitecturaNCapas.Dominio.Core.DTO;
using Em.ArquitecturaNCapas.Dominio.Core.Entidades;

namespace Em.ArquitecturaNCapas.Transversal.Mapeo
{
    public class PerfilesMapeo : Profile
    {
        public PerfilesMapeo()
        {
            CreateMap<AdmCargue, AdmCargueDTO>().ReverseMap();
        }
    }
}
