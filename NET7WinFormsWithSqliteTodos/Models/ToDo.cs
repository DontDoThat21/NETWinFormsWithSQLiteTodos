using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET7WinFormsWithSqliteTodos.Models
{
    public class ToDo
    {

        public ToDo()
        {
            Date = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Description { get; set; }

        [Required]        
        public DateTime Date { get; set; }
    }
}
