using Microsoft.AspNetCore.Mvc;
using PixelPlus.API.Models;
using PixelPlus.Core;
using PixelPlus.Core.PixelPlus.DTO;
using PixelPlus.ENT;
using PixelPlus.UOW;

namespace PixelPlus.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class GiseGörevlisiController : Controller
    {
        IUnitOfWork _uow;
        public GiseGörevlisiController(IUnitOfWork uow)
        {
            _uow = uow;
        }
        
        
        [HttpGet(Name = "List")]
        public IEnumerable<AboneLists> List([FromServices] AboneLists AboneLists)
        {
            return _uow._aboneRepos.AboneLists();
        }
        [HttpPost(Name = "Create")]
        public IActionResult Create([FromBody] AboneOlustur model)
        {
            _uow._aboneRepos.Create(new Abone
            {
                
                AboneName = model.AboneName,
                AbonelikDurumu = model.AbonelikDurumu,
                AboneBakiye = model.AboneBakiye,
                Depozito = 100,
             });
            _uow.save();
            return Ok(model.AboneName);
        }
        
        [HttpPost(Name = "AboneSorgula")]
        public Abone Find([FromBody] int id)
        {
            Abone Sorgula = _uow._aboneRepos.Find(id);
            return (Sorgula);
            
        }
        [HttpPut(Name ="FaturaOdeme")]
        public IActionResult FaturaUpdate(int id,[FromBody]FaturaOdeme model)
        {
            Fatura seciliFatura= _uow._faturaRepos.Find(id);
           
            seciliFatura.FaturaDurumu = model.FaturaDurumu;
            
            _uow._faturaRepos.Update(seciliFatura);
            _uow.save();
            return RedirectToAction("FaturaOdeme");
         }


        [HttpPut(Name = "AbonelikKapatma")]
        public IActionResult AboneUpdate(int id, [FromBody] AboneKapatma model)
        {
            Fatura seciliFatura = _uow._faturaRepos.Find(id);

            if (seciliFatura.FaturaDurumu == true)
            {
                seciliFatura.Abone.AbonelikDurumu = model.AbonelikDurumu;
                _uow._aboneRepos.Update(seciliFatura.Abone);
                _uow.save();
                return RedirectToAction("AbonelikKapatma");
            }
            else
                return NotFound();
        }
    }
}
