using Microsoft.AspNetCore.Mvc;
using NotesApp.Models;

namespace NotesApp.Controllers
{
    public class NoteController : Controller
    {
       public static Note note = new Note();
        [HttpGet("/")]
        public IActionResult Index()
        {

            
            note.NoteId = 1;
            return View();
        }
    }
}
