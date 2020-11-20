using Em.ArquitecturaNCapas.Dominio.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Em.ArquitecturaNCapas.Dominio.Core.Interfaces
{
    public interface IAdmCargueDominio
    {
        /// <summary>
        /// Método asincrono que permite obtener la lista de descripciones
        /// </summary>
        Task<IEnumerable<AdmCargue>> GetAdmCargueAsync();
    }
}
