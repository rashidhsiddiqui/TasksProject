using TasksProjectMVC5App.Models;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TasksProjectMVC5App.Controllers
{
    public class TasksController : Controller
    {
        private ApplicationDbContext _context;

        public TasksController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult New(Task task)
        {
            if (ModelState.IsValid)
            {
                task.dateCreated = DateTime.Now;
                _context.Tasks.Add(task);
                _context.SaveChanges();
                return RedirectToAction("Index", "Tasks");
            }

            return View(task);
        }

        [HttpPost]
        public ActionResult Edit(Task task)
        {
            if (ModelState.IsValid)
            {
                task.dateUpdated = DateTime.Now;
                _context.Tasks.Attach(task);
                _context.Entry(task).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index", "Tasks");
            }

            return View(task); //View("Edit", task);
        }

        public ActionResult Delete(int id)
        {
            var task = _context.Tasks.Where(a => a.id == id).SingleOrDefault();
            if (task != null)
            {
                _context.Tasks.Attach(task);
                _context.Entry(task).State = EntityState.Deleted;
                _context.SaveChanges();
                return RedirectToAction("Index", "Tasks");
            }
            else
            {
                return Content("Task record does not exist.");
            }
        }

        public ActionResult Edit(int id)
        {
            var task = _context.Tasks.Where(a => a.id == id).SingleOrDefault();
            return View(task);
        }

        public ActionResult Index()
        {
            var tasks = _context.Tasks.ToList();

            return View(tasks);
        }

    }
}