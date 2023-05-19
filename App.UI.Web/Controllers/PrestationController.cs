using App.ApplicationCore.Domain;
using App.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace App.UI.Web.Controllers
{
    public class PrestationController : Controller


    {

        IUnitOfWork unitOfWork;
        IPrestationService prestationService;
        IPrestataireService prestataireService;

        public PrestationController(IUnitOfWork unitOfWork, IPrestataireService prestataireService, IPrestationService prestationService)
        {
            this.unitOfWork = unitOfWork;
            this.prestationService = prestationService;
            this.prestataireService = prestataireService;
        }
        // GET: PrestationController

        public ActionResult Index()
        {
            return View();
        }

        // GET: PrestationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PrestationController/Create
        public ActionResult Create()
        {
            ViewBag.Prestataires = new SelectList(prestataireService.GetAll().Select(e => new { e.PrestataireId, Description = $"PrestataireId : {e.PrestataireNom}, Name = {e.PrestataireNom}" }), nameof(Prestataire.PrestataireId), "Description");

            return View();
        }

        // POST: PrestationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Prestation p)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                prestationService.Add(p);
                unitOfWork.Commit();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PrestationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PrestationController/Edit/5
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

        // GET: PrestationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PrestationController/Delete/5
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
