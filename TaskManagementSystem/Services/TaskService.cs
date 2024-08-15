using System;
using TaskManagementSystem.Models;
using TaskManagementSystem.Repositories;

namespace TaskManagementSystem.Services
{
    public class TaskService : ITaskService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TaskService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<EmployeeTask>> GetTasksForUserAsync(int userId)
        {
            return await _unitOfWork.EmployeeTask.FindAsync(t => t.AssignedTo.Id == userId);
        }

        public async Task<EmployeeTask> GetTaskByIdAsync(int taskId)
        {
            return await _unitOfWork.EmployeeTask.GetByIdAsync(taskId);
        }

        public async Task CreateTaskAsync(EmployeeTask task)
        {
            await _unitOfWork.EmployeeTask.AddAsync(task);
            await _unitOfWork.CompleteAsync();
        }

        public async Task UpdateTaskAsync(EmployeeTask task)
        {
            _unitOfWork.EmployeeTask.Update(task);
            await _unitOfWork.CompleteAsync();
        }
        public async Task DeleteTaskAsync(EmployeeTask task)
        {
            _unitOfWork.EmployeeTask.Remove(task);
            await _unitOfWork.CompleteAsync();
        }
    }
}

