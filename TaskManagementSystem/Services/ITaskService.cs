using System;
using TaskManagementSystem.Models;
namespace TaskManagementSystem.Services
{
    public interface ITaskService
    {
        Task<IEnumerable<EmployeeTask>> GetTasksForUserAsync(int userId);
        Task<EmployeeTask> GetTaskByIdAsync(int taskId);
        Task CreateTaskAsync(EmployeeTask task);
        Task UpdateTaskAsync(EmployeeTask task);
        Task DeleteTaskAsync(EmployeeTask task);
    }
}

