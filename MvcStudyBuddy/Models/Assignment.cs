using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcStudyBuddy.Models
{
    public class Assignment : IComparable
    {
        // Properties
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Task")]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        [Display(Name = "Due Date")]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }

        // Default comparer sorts by Name of Assignment
        int IComparable.CompareTo(object obj){
            return this.Name.CompareTo(obj);
        }
        // Comparer for sorting by Due Date Ascending
        public static IComparer AssignmentDueDateAscending() {
            return (IComparer) new AssignmentDueDateAscendingComparer();
        }

        // Sort Assignments by ascending days until due
        private class AssignmentDueDateAscendingComparer : IComparer
        {
            int IComparer.Compare(object x, object y){
                Assignment t1 = (Assignment)x;
                Assignment t2 = (Assignment)y;
                // Check if the first due date is sooner
                if(t1.DueDate > t2.DueDate) 
                    return 1;
                // Check if the second Assignments due date is sooner
                if(t2.DueDate < t2.DueDate)
                    return -1;
                // Check if they are the same
                else
                    return 0;
            }
        }
    }
}