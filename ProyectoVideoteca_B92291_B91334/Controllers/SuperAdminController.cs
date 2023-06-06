using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace ProyectoVideoteca_B92291_B91334.Controllers
{
    [Authorize(Roles = "superAdmin")]
    public class SuperAdminController : Controller
    {
        // GET: SuperAdminController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SuperAdminController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SuperAdminController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SuperAdminController/Create
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

        // GET: SuperAdminController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SuperAdminController/Edit/5
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

        // GET: SuperAdminController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SuperAdminController/Delete/5
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
