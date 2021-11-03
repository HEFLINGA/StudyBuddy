using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcStudyBuddy.Api.Models
{
    public class Todo
    {
        public int ToDoId { get; set; }
        public Assignment AnAssignment { get; set; }
        public bool Completed { get; set; }
    }
}