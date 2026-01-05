using LeaveManagementSystem.Web.Services.LeaveAllocations;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LeaveManagementSystem.Web.Controllers
{
    [Authorize]
    public class LeaveAllocationController(ILeaveAllocationsService _leaveAllocationsService) : Controller
    {
        public async Task<IActionResult> Details()
        {
            var leaveAllocations = await _leaveAllocationsService.GetAllocations();
            return View();
        }
    }
}
