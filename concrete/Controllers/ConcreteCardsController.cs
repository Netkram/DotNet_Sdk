using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using concrete.Models;
using concrete.Services;

namespace concrete.Controllers
{
    public class ConcreteCardsController : Controller
    {
        //
        // GET: /ConcreteCards/
        private ConcreteCardsService ConcreateCard = new ConcreteCardsService();


        public ActionResult Index()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult addcylinderdata(concreatecardview model)
        {

            ConcreateCard.addcylinder(model.Cyl);
            //this is pillayer
            return View("index", model); 
        }

        [HttpPost]
        public ActionResult addcarddata(concreatecardview model)
        {

            return View("index" , model);
        }



        //
        // GET: /ConcreteCards/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /ConcreteCards/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ConcreteCards/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /ConcreteCards/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /ConcreteCards/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /ConcreteCards/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /ConcreteCards/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
