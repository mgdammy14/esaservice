using ApiBusinessLogic.Interfaces.ReporteResultado;
using ApiUnitOfWork.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiBusinessLogic.Implementation.ReporteResultado
{
    public class ReporteResultadoLogic : IReporteResultadoLogic
    {
        private readonly IUnitOfWork _unitOfWork;
        public ReporteResultadoLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
