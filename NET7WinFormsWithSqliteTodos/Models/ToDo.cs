using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETWinFormsWithSqliteTodos.Models
{
    public class ToDo
    {

        public ToDo()
        {
            DateAdded = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string? TodoName { get; set; }

        [Required]
        public string? Description { get; set; }
        [Required]
        public string? Status { get; set; }

        [Required]        
        public DateTime DateToBeCompleted { get; set; }

        [Required]        
        public DateTime DateAdded { get; set; }

        public string Priority { get; set; } = "Medium"; // New field for task prioritization
        public bool IsRecurring { get; set; } = false; // New field for recurring tasks
        public TimeSpan? RecurrenceInterval { get; set; } // Optional recurrence interval
    }
}
