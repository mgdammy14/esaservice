using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiBusinessLogic.Interfaces.Master
{
    public interface IMasterLogic
    {
        public List<ApiModel.Masters.Master> GetMasterById(int listId);
    }
}
