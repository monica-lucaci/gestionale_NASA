using Microsoft.AspNetCore.Mvc;
using NASA_gestionale_task.Services;
using NASA_gestionale_task.Utils;

namespace NASA_gestionale_task.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OggettoCelesteController : Controller
    {
        private readonly OggettoCelesteService _service;

        public OggettoCelesteController(OggettoCelesteService service)
        {
            _service = service;
        }
    
        [HttpGet]
        public ActionResult<Risposta> ElencoOggettiCelesti()
        {
            return Ok(new Risposta()
            {
                Status = "SUCCESS",
                Data = _service.PrendiliTutti()
            }) ;
        }
    }
}
