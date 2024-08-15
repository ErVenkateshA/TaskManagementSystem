using System;
using System.ComponentModel.DataAnnotations;

namespace TaskManagementSystem.Models
{
	public class TaskAttachment
	{
        public int Id { get; set; }

        [Required]
        public string FilePath { get; set; }

        public string FileName { get; set; }
    }
}

