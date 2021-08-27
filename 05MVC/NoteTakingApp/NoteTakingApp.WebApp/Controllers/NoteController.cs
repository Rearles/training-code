using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NoteTakingApp.Domain;

namespace NoteTakingApp.WebApp.Controllers
{
    public class NoteController : Controller
    {
        private readonly IRepository _repo;

        public NoteController(IRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View(_repo.GetNotes());
        }

        public IActionResult Details(int id)
        {
            // bad: should have a repo implementation to just get one note
            return View(_repo.GetNotes().First(x => x.Id == id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost] // form submission (by default)
        public IActionResult Create(Note note)
        {
            // ASP.NET "model binding"
            // - fill in action method parameters with data from the request
            //   (URL path, URL query string, form data, etc.)
            //   based on compatible data type and name.

            _repo.AddNote(note);

            //return View("Details", note);
            return RedirectToAction("Details", new { id = note.Id });
        }
    }
}
