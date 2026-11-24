using GymManagementSystemG02.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymManagementSystemG02.Controllers
{
    public class PlansController : Controller
    {
        public async Task<IActionResult> Index()
        {
            using GymDbContext context = new GymDbContext();

            var plans = await context.Plans.ToListAsync();

            return View(plans);
        }

    }
}
