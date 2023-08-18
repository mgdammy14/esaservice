using ApiModel.Encuestas;
using ApiModel.Poblacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiBusinessLogic.Interfaces.Encuesta
{
    public interface IEncuestaLogic
    {
        public List<EncuestaQuery> GetEncuestaById(int IdEncuesta);
        public bool ActivarEncuesta(EncuestaActivacion encuesta);
        public bool InsertEncuesta(ApiModel.Encuestas.Encuesta encuesta);
        public List<EncuestaDTO> GetAllEncuesta(EncuestaFilter encuestaFilter);
        public bool ClonarEncuesta(EncuestaClonacion encuesta);
        public List<ApiModel.Poblacion.Poblacion> GetPoblacion(PoblacionFilter filter);
    }
}
