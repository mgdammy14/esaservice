using ApiBusinessLogic.Interfaces.Periodo;
using ApiBusinessLogic.Interfaces.Poblacion;
using ApiModel.ResponseDTO.General;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApi.Controllers
{
    [Route("api/periodos")]
    public class PeriodoController : Controller
    {
        private ResponseDTO _responseDTO = null;
        private IPeriodoLogic _logic;

        public PeriodoController(IPeriodoLogic logic)
        {
            _logic = logic;
        }

        [HttpGet]
        [Route("{unidadacademica}")]
        public IActionResult File(string unidadacademica)
        {
            _responseDTO = new ResponseDTO();
            try
            {
                var response = _responseDTO.Success(_responseDTO, _logic.GetPeriodoByUnidadAcademica(unidadacademica));
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
