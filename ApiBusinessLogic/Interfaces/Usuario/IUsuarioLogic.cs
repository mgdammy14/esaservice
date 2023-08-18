using ApiModel.Encuestas;
using ApiModel.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiBusinessLogic.Interfaces.Usuario
{
    public interface IUsuarioLogic
    {
        public List<ApiModel.Encuestas.EncuestaUsuario> GetEncuestaByEvaluadoAndCurso(string idUsuario, string idEvaluado, string idCurso);
        public List<ApiModel.Encuestas.EncuestaUsuario> GetEncuestaByIdUsuario(string idUsuario);
        public bool RegistrarEncuesta(EncuestaRespuestaUsuario encuestaUsuario);
    }
}
