using System;
using System.ComponentModel.DataAnnotations;

namespace TaskManagementSystem.Models
{
	public class EmployeeTask
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DueDate { get; set; }

        public bool IsCompleted { get; set; }

        public User AssignedTo { get; set; }

        public string Notes { get; set; }

        public IEnumerable<TaskAttachment> Attachments { get; set; }

    }

}

