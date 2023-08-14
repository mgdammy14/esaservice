using ApiBusinessLogic.Interfaces.Encuesta;
using ApiModel.Encuestas;
using ApiUnitOfWork.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiBusinessLogic.Implementation.Encuesta
{
    public class EncuestaLogic : IEncuestaLogic
    {
        private readonly IUnitOfWork _unitOfWork;

        public EncuestaLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<EncuestaQuery> GetEncuestaById(int IdEncuesta)
        {
            try
            {
                return _unitOfWork.IQuery.GetEncuestaById(IdEncuesta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ActivarEncuesta(EncuestaActivacion encuesta)
        {
            try
            {
                return _unitOfWork.ICommand.ActivarEncuesta(encuesta);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
