using System;
using TaskManagementSystem.Data;
using TaskManagementSystem.Models;

namespace TaskManagementSystem.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public IRepository<User> Users { get; private set; }
        public IRepository<EmployeeTask> EmployeeTask { get; private set; }
        public IRepository<TaskAttachment> TaskAttachments { get; private set; }

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            Users = new Repository<User>(_context);
            EmployeeTask = new Repository<EmployeeTask>(_context);
            TaskAttachments = new Repository<TaskAttachment>(_context);
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

