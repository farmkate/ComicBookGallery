﻿using Microsoft.AspNetCore.Mvc;
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
            ViewBag.SeriesTitle = "The Amazing Spider-Man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p> Final issue!  Witness the final hour of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</string> </p>";
            ViewBag.Artists = new string[]
            {
                "Script: Dan Slott", "Pencils: Humberto Ramos",
                "Inks: Victor Olazaba", "Colors: Edgar Delgado",
                "Letters: Chris Eliopoulos"
            };


            return View();
        }
    }
}
