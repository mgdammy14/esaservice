using ApiBusinessLogic.Interfaces.Resultado;
using ApiModel.Resultados;
using ApiUnitOfWork.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiBusinessLogic.Implementation.Resultado
{
    public class ResultadoLogic : IResultadoLogic
    {
        private readonly IUnitOfWork _unitOfWork;

        public ResultadoLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<EncuestaResultado> GetAllResultado(EncuestaResultadoFilter filter)
        {
            try
            {
                return _unitOfWork.IQuery.GetAllResultado(filter);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool ResetearEncuestaUsuario(EncuestaReseteoUsuario encuestaReseteoUsuario)
        {
            try
            {
                return _unitOfWork.ICommand.ResetearEncuestaUsuario(encuestaReseteoUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
