using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using SweetSavory.Models;

namespace SweetSavory.Controllers
{
  public class TreatsController : Controller
  {
    private readonly SweetSavoryContext _db;

    public TreatsController(SweetSavoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Treats.ToList());
    }
  }
}