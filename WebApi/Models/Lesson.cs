using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Lesson
    {
        public int LessonId;
        public Subjecting LessonSubject;
        public Hall LessonHall;
        public List<Group> LessonGroups;

    }
}
