using AppEmpresa.ConsumeAPI;
using AppHoteles.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppHoteles.MVC.Controllers
{
    public class ReservasController : Controller
    {
        private string urlApi;

        public ReservasController(IConfiguration configuration)
        {
            urlApi = configuration.GetValue("ApiUrlBase", "").ToString() + "/Reservas";
        }

        // GET: ReservasController
        public ActionResult Index()
        {
            var data = Crud<Reserva>.Read(urlApi);
            return View(data);
        }

        // GET: ReservasController/Details/5
        public ActionResult Details(int id)
        {
            var data = Crud<Reserva>.Read_ById(urlApi, id);
            return View(data);
        }

        // GET: ReservasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReservasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Reserva data)
        {
            try
            {
                var newData = Crud<Reserva>.Create(urlApi, data);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(data);
            }
        }

        // GET: ReservasController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = Crud<Reserva>.Read_ById(urlApi, id);
            return View(data);
        }

        // POST: ReservasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Reserva data)
        {
            try
            {
                Crud<Reserva>.Update(urlApi, id, data);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(data);
            }
        }

        // GET: ReservasController/Delete/5
        public ActionResult Delete(int id)
        {
            var data = Crud<Reserva>.Read_ById(urlApi, id);
            return View(data);
        }

        // POST: ReservasController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Reserva data)
        {
            try
            {
                Crud<Reserva>.Delete(urlApi, id);
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