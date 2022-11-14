using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StudentDetail.Models
{
    public class StudentModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string StudentName { get; set; }
        [Required]
        public int StudentRollNumber { get; set; }
        [Required]
        public string StudentClass { get; set; }

        //public string studentsection { get; set; }

        [DefaultValue(2020)]
        public int YearOfEnrollement { get; set; }
    }
}
