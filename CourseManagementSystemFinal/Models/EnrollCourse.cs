using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using CourseManagementSystemFinal.Models;

namespace CourseManagementSystemFinal.Models
{
    public class EnrollCourse
    {
        [Key]
        public long EnrollmentId { get; set; }


        [ForeignKey("CourseId")]
        public int? CourseId { get; set; }

        [ForeignKey("UserId")]
        public int? UserId { get; set; }
        public DateTime StartDate { get; set; }


        public string VideoLinks { get; set; }
        public virtual FindCourse Course { get; set; }
        public virtual SignUpModel User { get; set; }
    }
}
