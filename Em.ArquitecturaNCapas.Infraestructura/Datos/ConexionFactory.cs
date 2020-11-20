using Em.ArquitecturaNCapas.Transversal.Conexion;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace Em.ArquitecturaNCapas.Infraestructura.Datos
{
    public class ConexionFactory : IConnectionFactory
    {
        private readonly IConfiguration _configuration;

        public ConexionFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection GetConnection
        {
            get
            {
                var oracleConnection = new OracleConnection();

                if (oracleConnection == null) return null;

                oracleConnection.ConnectionString = _configuration.GetConnectionString("FUTURA");

                return oracleConnection;

            }
        }
    }
}
