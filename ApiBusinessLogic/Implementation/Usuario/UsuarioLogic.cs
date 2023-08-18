using ApiBusinessLogic.Interfaces.Usuario;
using ApiModel.Encuestas;
using ApiModel.Usuarios;
using ApiUnitOfWork.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiBusinessLogic.Implementation.Usuario
{
    public class UsuarioLogic : IUsuarioLogic
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsuarioLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<ApiModel.Encuestas.EncuestaUsuario> GetEncuestaByEvaluadoAndCurso(string idUsuario, string idEvaluado, string idCurso)
        {
            try
            {
                return _unitOfWork.IQuery.GetEncuestaByEvaluadoAndCurso(idUsuario, idEvaluado, idCurso);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ApiModel.Encuestas.EncuestaUsuario> GetEncuestaByIdUsuario(string idUsuario)
        {
            try
            {
                return _unitOfWork.IQuery.GetEncuestaByIdUsuario(idUsuario);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool RegistrarEncuesta(EncuestaRespuestaUsuario encuestaUsuario)
        {
            try
            {
                return _unitOfWork.ICommand.RegistrarEncuesta(encuestaUsuario);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
