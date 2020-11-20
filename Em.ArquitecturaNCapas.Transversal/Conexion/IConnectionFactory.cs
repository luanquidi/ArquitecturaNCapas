using System.Data;

namespace Em.ArquitecturaNCapas.Transversal.Conexion
{
    public interface IConnectionFactory
    {
        IDbConnection GetConnection { get; }
    }
}
