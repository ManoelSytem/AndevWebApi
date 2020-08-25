using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppAndev.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppAndev.Controllers
{
    public class ProjetoController : Controller
    {

        // GET: ProjetoController
        [Route("{Controller}/Index")]
        public ActionResult Index()
        {
            return PartialView();
        }

        // GET: ProjetoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProjetoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProjetoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromServices] IProjetoService collection)
        {
            try
            {
                var resultado = collection.Get().Result;
                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                return View();
            }
        }

        // GET: ProjetoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProjetoController/Edit/5
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

        // GET: ProjetoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProjetoController/Delete/5
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
