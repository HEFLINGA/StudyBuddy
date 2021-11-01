using System;
using System.ComponentModel.DataAnnotations;

namespace MvcStudyBuddy.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int total_points { get; set; }
        public int current_points { get; set; }
        public string Desc { get; set; }
    }
}