using Microsoft.AspNetCore.Mvc;
using SweetSavory.Models;
using System.Linq;
using System.Collections.Generic;

namespace SweetSavory.Controllers
{
  public class HomeController : Controller
  {
    private readonly SweetSavoryContext _db;

    public HomeController(SweetSavoryContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.Treats = new List<Treat>(_db.Treats.ToList());
      ViewBag.Flavors = new List<Flavor>(_db.Flavors.ToList());
      return View();
    }
  }
}