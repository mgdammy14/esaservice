using ApiBusinessLogic.Interfaces.Poblacion;
using ApiBusinessLogic.Interfaces.TipoEncuesta;
using ApiModel.ResponseDTO.General;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApi.Controllers
{
    [Route("api/tipoencuestas")]
    public class TipoEncuestaController : Controller
    {
        private ResponseDTO _responseDTO = null;
        private ITipoEncuestaLogic _logic;

        public TipoEncuestaController(ITipoEncuestaLogic logic)
        {
            _logic = logic;
        }

        [HttpGet]
        public IActionResult GetTipoEncuesta()
        {
            _responseDTO = new ResponseDTO();
            try
            {
                var response = _responseDTO.Success(_responseDTO, _logic.GetTipoEncuesta());
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
