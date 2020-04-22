using Business.Entities;
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

        [HttpPost]
        public IActionResult CreateDebt([FromBody]Debt debt)
        {
            return _debtService.CreateDebt(debt) == true
                ? StatusCode(500)
                : Ok();
        }
    }
}
