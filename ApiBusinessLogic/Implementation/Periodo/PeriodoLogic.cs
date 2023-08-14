using ApiBusinessLogic.Interfaces.Periodo;
using ApiUnitOfWork.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiBusinessLogic.Implementation.Periodo
{
    public class PeriodoLogic : IPeriodoLogic
    {
        private readonly IUnitOfWork _unitOfWork;

        public PeriodoLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<ApiModel.Periodos.Periodo> GetPeriodoByUnidadAcademica(string UnidadAcademica)
        {
            try
            {
                return _unitOfWork.IQuery.GetByUnidadAcademica(UnidadAcademica);
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }
    }
}
