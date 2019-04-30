using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Subjecting
    {
        public int SubjectingId { get; set; }
        public Subject SubjectId { get; set; }
        public List<Teacher> SubjectingTeachers { get; set; }//Один ко многим 
        public Group TeachingGroup { get; set; }
    }
}
