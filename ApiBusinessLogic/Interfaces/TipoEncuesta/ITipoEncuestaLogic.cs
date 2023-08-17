using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiBusinessLogic.Interfaces.TipoEncuesta
{
    public interface ITipoEncuestaLogic
    {
        public List<ApiModel.TipoEncuesta.TipoEncuesta> GetTipoEncuesta();
        public bool InsertTipoEncuesta(ApiModel.TipoEncuesta.TipoEncuesta tipoEncuesta);
    }
}
