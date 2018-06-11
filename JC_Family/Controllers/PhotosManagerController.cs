using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using JC_Family.Models;

namespace JC_Family.Controllers
{
    public class PhotosManagerController : Controller
    {
        private JC_FamilyDB db = new JC_FamilyDB();

        // GET: PhotosManager
        public ActionResult Index()
        {
            var photos = db.Photos.Include(p => p.Creater).Include(p => p.Genre);
            return View(photos.ToList());
        }
            
        // GET: PhotosManager/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Photo photo = db.Photos.Find(id);
            if (photo == null)
            {
                return HttpNotFound();
            }
            return View(photo);
        }

        // GET: PhotosManager/Create
        public ActionResult Create()
        {
            ViewBag.CreaterId = new SelectList(db.Creaters, "CreaterId", "CreaterName");
            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "Name");
            return View();
        }

        // POST: PhotosManager/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PhotoId,GenreId,CreaterId,Title,CreatTime,PhotoUrl")] Photo photo)
        {
            if (ModelState.IsValid)
            {
                db.Photos.Add(photo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CreaterId = new SelectList(db.Creaters, "CreaterId", "CreaterName", photo.CreaterId);
            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "Name", photo.GenreId);
            return View(photo);
        }

        // GET: PhotosManager/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Photo photo = db.Photos.Find(id);
            if (photo == null)
            {
                return HttpNotFound();
            }
            ViewBag.CreaterId = new SelectList(db.Creaters, "CreaterId", "CreaterName", photo.CreaterId);
            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "Name", photo.GenreId);
            return View(photo);
        }

        // POST: PhotosManager/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PhotoId,GenreId,CreaterId,Title,CreatTime,PhotoUrl")] Photo photo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(photo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CreaterId = new SelectList(db.Creaters, "CreaterId", "CreaterName", photo.CreaterId);
            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "Name", photo.GenreId);
            return View(photo);
        }

        // GET: PhotosManager/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Photo photo = db.Photos.Find(id);
            if (photo == null)
            {
                return HttpNotFound();
            }
            return View(photo);
        }

        // POST: PhotosManager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Photo photo = db.Photos.Find(id);
            db.Photos.Remove(photo);
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
