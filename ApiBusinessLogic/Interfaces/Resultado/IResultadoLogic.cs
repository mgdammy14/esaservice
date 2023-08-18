using ApiModel.Resultados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiBusinessLogic.Interfaces.Resultado
{
    public interface IResultadoLogic
    {
        public List<EncuestaResultado> GetAllResultado(EncuestaResultadoFilter filter);
        public bool ResetearEncuestaUsuario(EncuestaReseteoUsuario encuestaReseteoUsuario);
    }
}
