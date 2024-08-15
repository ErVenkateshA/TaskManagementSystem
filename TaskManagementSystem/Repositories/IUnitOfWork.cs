using System;
using TaskManagementSystem.Models;

namespace TaskManagementSystem.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<User> Users { get; }
        IRepository<EmployeeTask> EmployeeTask { get; }
        Task<int> CompleteAsync();
    }
}

