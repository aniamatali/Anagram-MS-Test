using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Anagram.Models;

namespace Anagram.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
      [HttpPost("/anagram/results")]
      public ActionResult Results()
      {
        Anagramer newWord = new Anagramer (Request.Form["inputWord"]);
        List<string> result = newWord.GetValue(newWord.GetWord());
        return View (result);
      }
      }
    }
  
