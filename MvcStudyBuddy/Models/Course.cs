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
            int ptsRemaining = 0;
            double remainingUnscoredPass =0;
            double remainingUnscoredA =0;
            double gradeAverageNeeded_pass = 0;
            double gradeAverageNeeded_A = 0;

            //If they have 0 grades
            if(c.current_points == 0){
                return "You need to get some grades in before you worry about your final score!";
            }
            //If they have some grades
            else if(c.current_points > 0 && c.current_points <= c.total_points){
                //Determine grade needed for passing and getting an A
                neededToPass = c.total_points * .7;
                neededForA = c.total_points * .9;
                //Calculate points available for rest of semester
                ptsRemaining = c.total_points - c.possible_points;
                
                //Solve for passing grade average needed rest of semester
                remainingUnscoredPass = neededToPass - c.current_points;
                gradeAverageNeeded_pass = remainingUnscoredPass/ptsRemaining;
                
                //Solve for grade average needed for A
                remainingUnscoredA = neededForA - c.current_points;
                gradeAverageNeeded_A = remainingUnscoredA/ptsRemaining;
                return "To pass this class you need to average a " + gradeAverageNeeded_pass + " for the remainder of the semester.";
            }
            return "";
        }
    }

}