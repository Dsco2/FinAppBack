using Business.Entities;
using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

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
            return _debtService.CreateDebt(debt)
                ? Ok()
                : StatusCode(500);
        }

        [HttpGet]
        public IActionResult GetDebt()
        {
            var debtList = _debtService.GetDebt();
            return debtList.Any()
                ? (IActionResult) Ok(debtList)
                : StatusCode(500);
        }

        [HttpGet("{id}")]
        public IActionResult GetDetailsDebt(int id)
        {
            var debtList = _debtService.GetDetailDebt(id);
            return debtList.Any()
                ? (IActionResult)Ok(debtList)
                : StatusCode(500);
        }
    }
}
