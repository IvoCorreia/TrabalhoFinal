using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoElevador_Documentacao.Controllers
{
    public class TrabalhoController : Controller
    {
        // GET: TrabalhoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TrabalhoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TrabalhoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TrabalhoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TrabalhoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TrabalhoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TrabalhoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TrabalhoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
