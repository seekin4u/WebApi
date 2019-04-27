using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public enum StudentGrade
    {
        Class1, Class2, Class3, Class4, Class5,
        Class6, Class7, Class8, Class9, Class10, Class11
    }
    public class Student
    {
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public List<Subject> Subjects { get; set; }

    }
}