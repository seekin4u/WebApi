using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Subject
    {
        public int SubjectId {get;set;}
        public string SubjectName { get; set; }
        //TODO : добавить указание каким курсам она читается?
    }
}