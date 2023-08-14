using ApiBusinessLogic.Interfaces.TipoEncuesta;
using ApiUnitOfWork.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiBusinessLogic.Implementation.TipoEncuesta
{
    public class TipoEncuestaLogic : ITipoEncuestaLogic
    {
        private readonly IUnitOfWork _unitOfWork;
        public TipoEncuestaLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<ApiModel.TipoEncuesta.TipoEncuesta> GetTipoEncuesta()
        {
            try
            {
                return _unitOfWork.IQuery.GetTipoEncuesta();
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
