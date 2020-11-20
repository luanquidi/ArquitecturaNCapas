using Dapper;
using Em.ArquitecturaNCapas.Dominio.Core.Entidades;
using Em.ArquitecturaNCapas.Dominio.Core.Interfaces;
using Em.ArquitecturaNCapas.Transversal.Conexion;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Em.ArquitecturaNCapas.Infraestructura.Repositorios
{
    public class AdmCargueRepository : IAdmCargueDominio
    {
        private readonly IConnectionFactory _connectionFactory;
        public AdmCargueRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }
   
        public async Task<IEnumerable<AdmCargue>> GetAdmCargueAsync()
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                //DynamicParameters parametros = new DynamicParameters();
                //parametros.Add(name:"pais", value: pais); pasar parametros antes del commandType
                var consulta = "SELECT * FROM T_DESCRIPCION LIMIT 5;";
                var listaDescripciones = await connection.QueryAsync<AdmCargue>(consulta, commandType: CommandType.Text);
                return listaDescripciones;
            }
        }
    }
}
