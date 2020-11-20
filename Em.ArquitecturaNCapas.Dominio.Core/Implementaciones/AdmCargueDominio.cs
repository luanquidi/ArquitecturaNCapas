using Em.ArquitecturaNCapas.Dominio.Core.Entidades;
using Em.ArquitecturaNCapas.Dominio.Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Em.ArquitecturaNCapas.Dominio.Core.Servicios
{
    public class AdmCargueDominio : IAdmCargueDominio
    {
        private readonly IAdmCargueDominio _admCargueDominio;
        public AdmCargueDominio(IAdmCargueDominio admCargueDominio)
        {
            _admCargueDominio = admCargueDominio;
        }

        public async Task<IEnumerable<AdmCargue>> GetAdmCargueAsync()
        {
            var listaDescripciones = await _admCargueDominio.GetAdmCargueAsync();
            return listaDescripciones;
        }
    }
}
