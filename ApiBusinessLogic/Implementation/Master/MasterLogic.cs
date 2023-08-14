using ApiBusinessLogic.Interfaces.Master;
using ApiUnitOfWork.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiBusinessLogic.Implementation.Master
{
    public class MasterLogic : IMasterLogic
    {
        private readonly IUnitOfWork _unitOfWork;

        public MasterLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<ApiModel.Masters.Master> GetMasterById(int listId)
        {
            try
            {
                return _unitOfWork.IQuery.GetMasterById(listId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
