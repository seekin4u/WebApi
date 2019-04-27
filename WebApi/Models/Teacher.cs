using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string TeacherNameSurname { get; set; }
        public string TeacherGrade { get; set; } //TODO: replace to GRADES ENUM
    }
}
