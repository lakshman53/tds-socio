using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TDS.Socio.Models
{
    public class OffersController : Controller
    {
        // GET: Offers
        public ActionResult Index()
        {
            return View();
        }

        // GET: Offers/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Offers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Offers/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                azure_sociodataEntities1 ctx = new azure_sociodataEntities1();

                Offer offer = new Offer();

             

                offer.message = collection.Get("message");
                offer.subject = collection.Get("subject");
                offer.sender = "laks";
                offer.sent = ctx.getLocalDateTime().First();
                
                ctx.Offers.Add(offer);

                ctx.SaveChanges();

                OfferGroup offerGroup = new OfferGroup();

                offerGroup.OfferId = offer.OfferId;
                offerGroup.GroupId = Convert.ToInt32(collection.Get("groupName"));

                ctx.OfferGroups.Add(offerGroup);

                ctx.SaveChanges();

                // TODO: Add insert logic here

                return RedirectToAction("SendMessages", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: Offers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Offers/Edit/5
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

        // GET: Offers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Offers/Delete/5
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
