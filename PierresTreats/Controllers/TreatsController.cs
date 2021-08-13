using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PierresTreats.Models;
using System.Web;
using System.Collections.Generic;
using System.Linq;

namespace PierresTreats.Controllers
{
  [Authorize]
  public class TreatsController : Controller
  {
    private readonly PierresTreatsContext _db;
    private readonly UserManager<User> _userManager;

    public TreatsController(UserManager<User> userManager, PierresTreatsContext db)
    {
      _userManager = userManager;
      _db = db;
    }
    [AllowAnonymous]
    public ActionResult Index()
    {
      return View(_db.Treats.ToList());
    }
  }
}