using Em.ArquitecturaNCapas.Dominio.Core.DTO;
using Em.ArquitecturaNCapas.Transversal.Respuesta;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Em.ArquitecturaNCapas.Aplicacion.Interfaces
{
    public interface IAdmCargueAplicacion
    {
        Task<RespuestaOperacion<IEnumerable<AdmCargueDTO>>> GetAdmCargueAsync();
    }
}
