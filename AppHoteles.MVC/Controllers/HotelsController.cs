using AppEmpresa.ConsumeAPI;
using AppHoteles.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppHoteles.MVC.Controllers
{
    public class HotelsController : Controller
    {
        private string urlApi;

        public HotelsController(IConfiguration configuration)
        {
            urlApi = configuration.GetValue("ApiUrlBase", "").ToString() + "/Hotels";
        }

        // GET: HotelsController
        public ActionResult Index()
        {
            var data = Crud<Hotel>.Read(urlApi);
            return View(data);
        }

        // GET: HotelsController/Details/5
        public ActionResult Details(int id)
        {
            var data = Crud<Hotel>.Read_ById(urlApi, id);
            return View(data);
        }

        // GET: HotelsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HotelsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Hotel data)
        {
            try
            {
                var newData = Crud<Hotel>.Create(urlApi, data);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(data);
            }
        }

        // GET: HotelsController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = Crud<Hotel>.Read_ById(urlApi, id);
            return View(data);
        }

        // POST: HotelsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Hotel data)
        {
            try
            {
                Crud<Hotel>.Update(urlApi, id, data);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(data);
            }
        }

        // GET: HotelsController/Delete/5
        public ActionResult Delete(int id)
        {
            var data = Crud<Hotel>.Read_ById(urlApi, id);
            return View(data);
        }

        // POST: HotelsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Hotel data)
        {
            try
            {
                Crud<Hotel>.Delete(urlApi, id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(data);
            }
        }
    }
}