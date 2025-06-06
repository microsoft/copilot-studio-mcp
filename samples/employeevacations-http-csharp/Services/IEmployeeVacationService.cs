using MCP.HTTP.Server.Entities;

namespace MCP.HTTP.Server.Services
{
    public interface IEmployeeVacationService
    {
        Task<int?> GetVacationDaysLeftAsync(string employeeName);
        Task<bool> ChargeVacationDaysAsync(string employeeName, int daysToCharge);
        Task<List<Employee>> GetAllEmployeesAsync();
    }
}
