using ProjectItiTeam.Models.Identity;
using System;

namespace ProjectItiTeam.Models
{
    public class Enrollment
    {
        public Enrollment()
        {
            CourseDegree = 0;
        }
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int CourseId { get; set; }
        public Nullable<int> CourseDegree { get; set; }

        public string UserId { get; set; }
      
        public virtual Course Course { get; set; }
    }
}
