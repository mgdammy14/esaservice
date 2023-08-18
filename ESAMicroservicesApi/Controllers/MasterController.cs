using ApiBusinessLogic.Interfaces.Master;
using ApiModel.ResponseDTO.General;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/masters")]
    public class MasterController : Controller
    {
        private ResponseDTO _responseDTO = null;
        private IMasterLogic _logic;

        public MasterController(IMasterLogic logic)
        {
            _logic = logic;
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetMasterById(int id)
        {
            _responseDTO = new ResponseDTO();
            try
            {
                var response = _responseDTO.Success(_responseDTO, _logic.GetMasterById(id));
                return Ok(response);
            }
            catch (Exception e)
            {
                var response = _responseDTO.Failed(_responseDTO, e);
                return BadRequest(response);
            }
        }
    }
}
