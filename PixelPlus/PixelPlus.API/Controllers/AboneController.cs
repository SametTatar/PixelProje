using Microsoft.AspNetCore.Mvc;
using PixelPlus.Core;
using PixelPlus.Core.PixelPlus.DTO;
using PixelPlus.ENT;
using PixelPlus.UOW;

namespace PixelPlus.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AboneController : Controller
    {
        IUnitOfWork _uow;
        public AboneController(IUnitOfWork uow)
        {
            _uow = uow;
        }
        [HttpGet(Name = "Lists")]
        public IEnumerable<AboneLists> List([FromServices] AboneLists AboneLists)
        {
            return _uow._aboneRepos.AboneLists();
        }
        [HttpPut(Name = "AboneFaturaOdeme")]
        public IActionResult FaturaUpdate(int id, [FromBody] FaturaOdeme model)
        {
            Fatura seciliFatura = _uow._faturaRepos.Find(id);
            //seciliFatura.Abone.AboneBakiye = seciliFatura.Abone.AboneBakiye - model.FaturaTutar;
            seciliFatura.FaturaDurumu = model.FaturaDurumu;

            _uow._faturaRepos.Update(seciliFatura);
            _uow.save();
            return RedirectToAction("FaturaOdeme");
        }
    }
}
