using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProgramPet.Domain;
using ProgramPet.Models;
using ProgramPet.Services;

namespace ProgramPet.Web.Controllers
{
    public class PetShopController : Controller
    {
        private readonly IServicesPet _servicespet;

        public PetShopController(IServicesPet servicespet)
        {
            _servicespet = servicespet;
        }
        // GET: PetShop
        public ActionResult Index()
        {
            var model = _servicespet.getall();

            var viewmodel = model.Select(c => new PetViewModel
            {
                id = c.id,
                Name = c.Name,
                Age = c.Age,
                Active = c.Active                
            });            

            return View(viewmodel);
        }

        // GET: PetShop/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PetShop/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PetShop/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PetViewModel collection)
        {
            try
            {
                var model = new PetShop();

                model.Name = collection.Name;
                model.Age = collection.Age;
                model.Active = collection.Active;
                _servicespet.save(model);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PetShop/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PetShop/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PetShop/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PetShop/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}