﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyWordrobeBL.Models;

namespace MyWordrobeBL.Controllers
{
    public class ShoesController : Controller
    {
        private WordrobeBLewisEntities db = new WordrobeBLewisEntities();

        // GET: Shoes
        public ActionResult Index()
        {
            var shoes = db.Shoes.Include(s => s.Occasion).Include(s => s.Photo).Include(s => s.Season).Include(s => s.ShoeSize);
            return View(shoes.ToList());
        }

        // GET: Shoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sho sho = db.Shoes.Find(id);
            if (sho == null)
            {
                return HttpNotFound();
            }
            return View(sho);
        }

        // GET: Shoes/Create
        public ActionResult Create()
        {
            ViewBag.OccasionID = new SelectList(db.Occasions, "OccasionID", "Occasion1");
            ViewBag.PhotoID = new SelectList(db.Photos, "PhotoID", "Photo1");
            ViewBag.SeasonID = new SelectList(db.Seasons, "SeasonID", "Season1");
            ViewBag.ShoeSizeID = new SelectList(db.ShoeSizes, "ShoeSizeID", "ShoeSizeID");
            return View();
        }

        // POST: Shoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ShoesID,Name,ShoeSizeID,PhotoID,SeasonID,OccasionID")] Sho sho)
        {
            if (ModelState.IsValid)
            {
                db.Shoes.Add(sho);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.OccasionID = new SelectList(db.Occasions, "OccasionID", "Occasion1", sho.OccasionID);
            ViewBag.PhotoID = new SelectList(db.Photos, "PhotoID", "Photo1", sho.PhotoID);
            ViewBag.SeasonID = new SelectList(db.Seasons, "SeasonID", "Season1", sho.SeasonID);
            ViewBag.ShoeSizeID = new SelectList(db.ShoeSizes, "ShoeSizeID", "ShoeSizeID", sho.ShoeSizeID);
            return View(sho);
        }

        // GET: Shoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sho sho = db.Shoes.Find(id);
            if (sho == null)
            {
                return HttpNotFound();
            }
            ViewBag.OccasionID = new SelectList(db.Occasions, "OccasionID", "Occasion1", sho.OccasionID);
            ViewBag.PhotoID = new SelectList(db.Photos, "PhotoID", "Photo1", sho.PhotoID);
            ViewBag.SeasonID = new SelectList(db.Seasons, "SeasonID", "Season1", sho.SeasonID);
            ViewBag.ShoeSizeID = new SelectList(db.ShoeSizes, "ShoeSizeID", "ShoeSizeID", sho.ShoeSizeID);
            return View(sho);
        }

        // POST: Shoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ShoesID,Name,ShoeSizeID,PhotoID,SeasonID,OccasionID")] Sho sho)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sho).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.OccasionID = new SelectList(db.Occasions, "OccasionID", "Occasion1", sho.OccasionID);
            ViewBag.PhotoID = new SelectList(db.Photos, "PhotoID", "Photo1", sho.PhotoID);
            ViewBag.SeasonID = new SelectList(db.Seasons, "SeasonID", "Season1", sho.SeasonID);
            ViewBag.ShoeSizeID = new SelectList(db.ShoeSizes, "ShoeSizeID", "ShoeSizeID", sho.ShoeSizeID);
            return View(sho);
        }

        // GET: Shoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sho sho = db.Shoes.Find(id);
            if (sho == null)
            {
                return HttpNotFound();
            }
            return View(sho);
        }

        // POST: Shoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sho sho = db.Shoes.Find(id);
            db.Shoes.Remove(sho);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
