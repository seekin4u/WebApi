using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public Teacher GroupCurator { get; set; }
    }//TODO курс группа - принадлежность к какому-либо классу?

}
