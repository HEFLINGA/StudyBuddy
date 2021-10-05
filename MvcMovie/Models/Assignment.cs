using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Assignments
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }
        public int Points { get; set; }
        public string Description { get; set; }
    }
}