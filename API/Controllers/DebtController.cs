using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class DebtController : Controller
    {
        private readonly IDebtService _debtService;

        public DebtController(IDebtService debtService)
        {
            _debtService = debtService;
        }

        [HttpGet]
        public IActionResult Test()
        {
            return Ok("I'm here!");
        }
    }
}
