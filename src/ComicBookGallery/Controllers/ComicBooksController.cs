using ComicBookGallery.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue!</p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Dan", Role = "Script" }
                }
            };
            
            return View(comicBook);
        }
    }
}
