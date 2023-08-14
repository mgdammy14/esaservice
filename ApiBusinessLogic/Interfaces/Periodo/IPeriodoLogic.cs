using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiBusinessLogic.Interfaces.Periodo
{
    public interface IPeriodoLogic
    {
        public List<ApiModel.Periodos.Periodo> GetPeriodoByUnidadAcademica(string UnidadAcademica);
    }
}
