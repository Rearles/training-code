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
    }
}
