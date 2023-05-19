using App.ApplicationCore.Domain;
using App.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.UI.Web.Controllers
{
    public class PrestataireController : Controller
    {
        IUnitOfWork unitOfWork;
        IPrestataireService prestataireService;

        public PrestataireController(IUnitOfWork unitOfWork,IPrestataireService prestataireService)
        {
            this.unitOfWork= unitOfWork;
            this.prestataireService= prestataireService;    
        }

        // GET: PrestataireController
        public ActionResult Index()
        {
            return View(prestataireService.GetPresOrderByNom());
        }

        // GET: PrestataireController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PrestataireController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PrestataireController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Prestataire p)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                prestataireService.Add(p);
                unitOfWork.Commit();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PrestataireController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PrestataireController/Edit/5
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

        // GET: PrestataireController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PrestataireController/Delete/5
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
