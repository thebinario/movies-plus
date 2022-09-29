using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace movies_plus.Controllers
{
    public class movieController : Controller
    {
        // GET: movieController
        public ActionResult Index()
        {
            return View();
        }

        // GET: movieController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: movieController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: movieController/Create
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

        // GET: movieController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: movieController/Edit/5
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

        // GET: movieController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: movieController/Delete/5
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
