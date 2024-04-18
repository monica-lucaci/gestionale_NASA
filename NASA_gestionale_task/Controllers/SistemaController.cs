using Microsoft.AspNetCore.Mvc;
using NASA_gestionale_task.Services;

namespace NASA_gestionale_task.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SistemaController : Controller
    {
        private readonly SistemaService _service;

        public SistemaController(SistemaService service)
        {
            _service = service;
        }
    }
}
