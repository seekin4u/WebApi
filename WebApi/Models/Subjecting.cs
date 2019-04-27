using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Subjecting
    {
        public int SubjectingId;
        public List<Teacher> SubjectingTeachers;//Один ко многим
        public Group GroupId;
    }
}
