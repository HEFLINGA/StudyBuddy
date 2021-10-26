using System;
using System.ComponentModel.DataAnnotations;

namespace MvcStudyBuddy.Models
{
    public class Assignment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }

         [Display(Name = "Due Date")]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }
        public int Points { get; set; }
        public string Description { get; set; }
    }
}