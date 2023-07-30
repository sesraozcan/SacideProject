using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SacideProject.Business.Abstract;
using SacideProject.Entity;

namespace SacideProject.WebUI.Controllers
{
    public class DanismanController : Controller
    {
        private IDanismanService _danismanService;
        private ITerapiService _terapiService;

        public DanismanController(IDanismanService danismanService, ITerapiService terapiService)
        {
            _danismanService = danismanService;
            _terapiService = terapiService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DanismanList()
        {
            var values = _danismanService.GetListAll();
            return View(values);
        }

        public IActionResult DanismanEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DanismanEkle(Danisman danisman)
        {
            int rnd1 = new Random().Next(1, 6);
            danisman.TerapiID = rnd1;
            _danismanService.Create(danisman);
            return RedirectToAction("DanismanList", "Danisman");
        }

        public IActionResult DanismanDuzenle(int id)
        {
            List<SelectListItem> values1 = (from x in _terapiService.GetAll()
                                            select new SelectListItem
                                            {
                                                Text = x.TerapiAd,
                                                Value = x.TerapiID.ToString()
                                            }).ToList();
            ViewBag.cv = values1;
            var values = _danismanService.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult DanismanDuzenle(Danisman danisman)
        {
            var entity = _danismanService.GetById(danisman.DanismanID);
            entity.DanismanAd = danisman.DanismanAd;
            entity.DanismanSoyad = danisman.DanismanSoyad;
            entity.TerapiID = danisman.TerapiID;
            _danismanService.Update(entity);
            return RedirectToAction("DanismanList", "Danisman");
        }

        public IActionResult DanismanSil(int id)
        {
            var entity = _danismanService.GetById(id);
            _danismanService.Delete(entity);
            return RedirectToAction("DanismanList", "Danisman");
        }

        public IActionResult DanismanAta(Danisman danisman)
        {
            int rnd = new Random().Next(1, 6);
            danisman.TerapiID = rnd;
            ViewBag.v1 = rnd;

            var values = _danismanService.GetListAll();
            return View(values);
        }
    }
}
