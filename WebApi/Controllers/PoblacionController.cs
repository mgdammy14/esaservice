using ApiBusinessLogic.Interfaces.Poblacion;
using ApiModel.ResponseDTO.General;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApi.Controllers
{
    [Route("api/poblacion")]
    public class PoblacionController : Controller
    {
        private ResponseDTO _responseDTO = null;
        private IPoblacionLogic _logic;

        public PoblacionController(IPoblacionLogic logic)
        {
            _logic = logic;
        }

        [HttpGet]
        [Route("file/{id:int}")]
        public IActionResult File(int id)
        {
            _responseDTO = new ResponseDTO();
            try
            {
                var response = _responseDTO.Success(_responseDTO, _logic.File(id));
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
