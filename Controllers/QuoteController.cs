using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using QuotingDojo.Models;
using DbConnection;

namespace QuotingDojo.Controllers
{
  public class QuoteController : Controller
  {
    [HttpGet("")]
    public IActionResult Index()
    {
      return View();
    }

    [HttpGet("quotes")]
    public IActionResult Show()
    {
      List<Dictionary<string, object>> Quotes = DbConnector.Query("SELECT * FROM quotes ORDER BY created_at DESC");
      return View("Quotes", Quotes);
    }

    [HttpPost("quotes")]
    public IActionResult Create(Quote quote)
    {
      if(ModelState.IsValid)
      {
        string query = $"INSERT INTO quotes (author, quote) VALUES ('{quote.Author}', '{quote.Content}')";
        DbConnector.Execute(query);
        System.Console.WriteLine("valid quote");
        System.Console.WriteLine(quote.Author);
        System.Console.WriteLine(quote.Content);
        return RedirectToAction("Show");
      }
      else 
      {
        System.Console.WriteLine(quote.Author);
        System.Console.WriteLine(quote.Content);
        System.Console.WriteLine("invalid quote");
        return View("Index"); 
      }
    }

  }
}
