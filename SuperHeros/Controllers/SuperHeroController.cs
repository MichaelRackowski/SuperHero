using SuperHeros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperHeros.Controllers
{
    public class SuperHeroController : Controller
    {
        ApplicationDbContext context;
        public SuperHeroController()
        {
            context =  new ApplicationDbContext();
        }
        // GET: SuperHero
        public ActionResult Index()
        {
            var Heros = context.Heros.ToList();
            return View(Heros);
        }

        // GET: SuperHero/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }


        // GET: SuperHero/Create
        public ActionResult Create()
        {
            SuperHero superhero = new SuperHero();
            return View(superhero);
        }

        // POST: SuperHero/Create
        [HttpPost]
        public ActionResult Create(SuperHero superhero)
        {
            try
            {
                // TODO: Add insert logic here
                context.Heros.Add(superhero); 
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHero/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
               
               var SuperHeroDb = context.Heros.Where(s => s.Id == id).FirstOrDefault();
                return View(SuperHeroDb);
            }
            catch (Exception)
            {

                return View();
            }

            
        }

        // POST: SuperHero/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, SuperHero superhero)
        {
            try
            {
                var SuperHeroDb = context.Heros.Where(s => s.Id == id).FirstOrDefault();
                // TODO: Add update logic here
                SuperHeroDb.Name = superhero.Name;
                SuperHeroDb.AlterEgo = superhero.AlterEgo;
                SuperHeroDb.SuperPowerOne = superhero.SuperPowerOne;
                SuperHeroDb.SuperPowerTwo = superhero.SuperPowerTwo;
                SuperHeroDb.CatchPhrase = superhero.CatchPhrase;

                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHero/Delete/5
        public ActionResult Delete(int id)
        {
            var SuperHeroDb = context.Heros.Where(s => s.Id == id).FirstOrDefault();
            // TODO: Add update logic here

            return View();
        }

        // POST: SuperHero/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, SuperHero superHero)
        {
            try
            {
                // TODO: Add delete logic here
                var superherosToDelete = context.Heros.Where(s => s.Id == id).FirstOrDefault();
                context.Heros.Remove(superherosToDelete);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
