using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace assignment_1_webapi.Entities
{
    public class SemesterCoursesModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public SemesterModel Semester { get; set; }
        public CourseModel Course { get; set; }
    }
}