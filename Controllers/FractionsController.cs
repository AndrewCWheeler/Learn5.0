using System;
using System.Web;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Learn.Data;
using Learn.Models;

namespace Learn.Controllers
{
    public class FractionsController : Controller
    {
        private readonly LearnContext _context;
        public FractionsController(LearnContext context)
        {
            _context = context;
        }

        public IActionResult DivideLevelOne()
        {
            int? LoggedId = HttpContext.Session.GetInt32("UserId");
            if (LoggedId == null)
            {
                return RedirectToAction("Index", "Home");
            }
            //ViewBag.LoggedUser = _context.Users.FirstOrDefault(u => u.Id == (int)LoggedId);
            ViewBag.LoggedUser = "Guest";
            
            FractionCard[] Cards = new FractionCard[12];

            for (int i = 0; i < 12; ++i)
            {
                Cards[i] = new DivisionCard().Create(1);
            }

            return View("DivideLevelOne", Cards);
        }

        public IActionResult DivideLevelTwo()
        {
            int? LoggedId = HttpContext.Session.GetInt32("UserId");
            if (LoggedId == null)
            {
                return RedirectToAction("Index", "Home");
            }
            //ViewBag.LoggedUser = _context.Users.FirstOrDefault(u => u.Id == (int)LoggedId);
            ViewBag.LoggedUser = "Guest";

            FractionCard[] Cards = new FractionCard[12];
            for (int i = 0; i < 12; ++i)
            {
                Cards[i] = new DivisionCard().Create(2);
            }
            return View("DivideLevelTwo", Cards);
        }

        public IActionResult DivideLevelThree()
        {
            int? LoggedId = HttpContext.Session.GetInt32("UserId");
            if (LoggedId == null)
            {
                return RedirectToAction("Index", "Home");
            }
            //ViewBag.LoggedUser = _context.Users.FirstOrDefault(u => u.Id == (int)LoggedId);
            ViewBag.LoggedUser = "Guest";

            FractionCard[] Cards = new FractionCard[12];

            for (int i = 0; i < 12; ++i)
            {
                Cards[i] = new DivisionCard().Create(3);
            }
            return View("DivideLevelThree", Cards);
        }

        public IActionResult MultiplyLevelOne()
        {
            int? LoggedId = HttpContext.Session.GetInt32("UserId");
            if (LoggedId == null)
            {
                return RedirectToAction("Index", "Home");
            }
            //ViewBag.LoggedUser = _context.Users.FirstOrDefault(u => u.Id == (int)LoggedId);
            ViewBag.LoggedUser = "Guest";
            
            // Instantiate an array of Fraction Card objects
            FractionCard[] Cards = new FractionCard[12];
            for (int i = 0; i < 12; ++i)
            {
                Cards[i] = new MultiplicationCard().Create(1, i);
            }
            
            return View("MultiplyLevelOne", Cards);
        }

        public IActionResult MultiplyLevelTwo()
        {
            int? LoggedId = HttpContext.Session.GetInt32("UserId");
            if (LoggedId == null)
            {
                return RedirectToAction("Index", "Home");
            }
            //ViewBag.LoggedUser = _context.Users.FirstOrDefault(u => u.Id == (int)LoggedId);
            ViewBag.LoggedUser = "Guest";
            // Instantiate an array of Fraction Card objects
            FractionCard[] Cards = new FractionCard[12];
            for (int i = 0; i < 12; ++i)
            {
                Cards[i] = new MultiplicationCard().Create(2, i);
            }
            return View("MultiplyLevelTwo", Cards);
        }

        public IActionResult MultiplyLevelThree()
        {
            int? LoggedId = HttpContext.Session.GetInt32("UserId");
            if (LoggedId == null)
            {
                return RedirectToAction("Index", "Home");
            }
            //ViewBag.LoggedUser = _context.Users.FirstOrDefault(u => u.Id == (int)LoggedId);
            ViewBag.LoggedUser = "Guest";
            // Instantiate an array of Fraction Card objects
            FractionCard[] Cards = new FractionCard[12];
            for (int i = 0; i < 12; ++i)
            {
                Cards[i] = new MultiplicationCard().Create(3, i);
            }
            return View("MultiplyLevelThree", Cards);
        }


        public IActionResult AddLevelOne()
        {
            int? LoggedId = HttpContext.Session.GetInt32("UserId");
            if (LoggedId == null)
            {
                return RedirectToAction("Index", "Home");
            }
            //ViewBag.LoggedUser = _context.Users.FirstOrDefault(u => u.Id == (int)LoggedId);
            ViewBag.LoggedUser = "Guest";
            
            FractionCard[] Cards = new FractionCard[12];
            for (int i = 0; i < 12; ++i)
            {
                Cards[i] = new AdditionCard().Create(1, i);
            }
            return View("AddLevelOne", Cards);
        }

        public IActionResult AddLevelTwo()
        {
            int? LoggedId = HttpContext.Session.GetInt32("UserId");
            if(LoggedId == null)
            {
                return RedirectToAction("Index", "Home");
            }
            //ViewBag.LoggedUser = _context.Users.FirstOrDefault(u => u.Id == (int)LoggedId);
            ViewBag.LoggedUser = "Guest";
            FractionCard[] Cards = new FractionCard[12];
            for (int i = 0; i < 12; ++i)
            {
                Cards[i] = new AdditionCard().Create(2, i);
            }
            return View("AddLevelTwo", Cards);
        }

        public IActionResult AddLevelThree()
        {
            int? LoggedId = HttpContext.Session.GetInt32("UserId");
            if(LoggedId == null)
            {
                return RedirectToAction("Index", "Home");
            }
            //ViewBag.LoggedUser = _context.Users.FirstOrDefault(u => u.Id == (int)LoggedId);
            ViewBag.LoggedUser = "Guest";
            FractionCard[] Cards = new FractionCard[12];
            for (int i = 0; i < 12; ++i)
            {
                Cards[i] = new AdditionCard().Create(3, i);
            }
            return View("AddLevelThree", Cards);
        }
    }
}