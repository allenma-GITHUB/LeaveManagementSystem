
namespace LeaveManagementSystem.Web.Services.LeaveAllocations
{
    public interface ILeaveAllocationsService
    {
        Task AllocateLeave(string employeId);
        Task<List<LeaveAllocation>> GetAllocations();
    }
}