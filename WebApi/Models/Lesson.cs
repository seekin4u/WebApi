using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Lesson
    {
        public int LessonId { get; set; }
        public Subjecting SubjectingId { get; set; }
        public Hall HallId { get; set; }
        public List<Group> LessonGroups { get; set; }

    }
}
