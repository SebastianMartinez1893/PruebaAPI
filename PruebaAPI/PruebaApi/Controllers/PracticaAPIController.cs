using Microsoft.AspNetCore.Mvc;
using PruebaApi.Negocio.Interface;

namespace PruebaApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PracticaAPIController : ControllerBase
    {
        internal IPracticaNegocio practicaNegocio;
        public PracticaAPIController(IPracticaNegocio _practicaNegocio)
        {
            practicaNegocio = _practicaNegocio;
        }

        [HttpPost]
        public ActionResult PruebaRetornoJson()
        {
            try
            {
                return Ok(practicaNegocio.PracticaJson());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
