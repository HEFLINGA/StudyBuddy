using System;
using System.ComponentModel.DataAnnotations;

namespace MvcStudyBuddy.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name = "Total Points")]
        public int total_points { get; set; }
        [Display(Name = "Current Points")]
        public int current_points { get; set; }
        [Display(Name = "Possible Points")]
        public int possible_points { get; set; }
        [Display(Name = "Description")]
        public string Desc { get; set; }

        static string getGradeNeeded(Course c) {
            //Declare variables
            double neededToPass = 0;
            double neededForA = 0;

            //If they have 0 grades
            if(c.current_points == 0){
                return "You need to get some grades in before you worry about your final score!";
            }
            //If they have some grades
            else if(c.current_points > 0){
                neededToPass = c.total_points * .7;
                neededForA = c.total_points * .9;
            }
            return "";
        }
    }

}