using System.Linq;
using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class EarningController : Controller
    {
        private readonly IEarningService _earningService;

        public EarningController(IEarningService earningService)
        {
            _earningService = earningService;
        }

        [HttpGet]
        public IActionResult GetEarning()
        {
            var earningList = _earningService.GetEarning();
            return earningList.Any()
                ? (IActionResult)Ok(earningList)
                : StatusCode(500);
        }
    }
}
