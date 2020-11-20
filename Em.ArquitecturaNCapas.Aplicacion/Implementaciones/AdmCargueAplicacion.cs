using AutoMapper;
using Em.ArquitecturaNCapas.Aplicacion.Interfaces;
using Em.ArquitecturaNCapas.Dominio.Core.DTO;
using Em.ArquitecturaNCapas.Dominio.Core.Interfaces;
using Em.ArquitecturaNCapas.Transversal.Logs;
using Em.ArquitecturaNCapas.Transversal.Respuesta;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Em.ArquitecturaNCapas.Aplicacion.Implementaciones
{
    public class AdmCargueAplicacion : IAdmCargueAplicacion
    {
        private readonly IAdmCargueDominio _admCargueDominio;
        private readonly IMapper _mapper;
        private readonly IAppLogger<AdmCargueAplicacion> _appLogger;
        public AdmCargueAplicacion(IAdmCargueDominio admCargueDominio, IMapper mapper, IAppLogger<AdmCargueAplicacion> appLogger)
        {
            _admCargueDominio = admCargueDominio;
            _mapper = mapper;
            _appLogger = appLogger;
        }

        public async Task<RespuestaOperacion<IEnumerable<AdmCargueDTO>>> GetAdmCargueAsync()
        {
            var respuesta = new RespuestaOperacion<IEnumerable<AdmCargueDTO>>();

            try
            {
                var listaDescripciones = await _admCargueDominio.GetAdmCargueAsync();

                respuesta.Datos = _mapper.Map<IEnumerable<AdmCargueDTO>>(listaDescripciones);
                respuesta.ResultadoExitoso = true;
                respuesta.Mensaje = "Operacion exitosa";

    }
            catch (Exception ex)
            {
                respuesta.Datos = null;
                respuesta.ResultadoExitoso = false;
                respuesta.Mensaje = "Ocurrio un error.";
                _appLogger.LogError(ex.Message, "Error en el método GetAdmCargueAsync");
            };

            return respuesta;
        }

    }
}
