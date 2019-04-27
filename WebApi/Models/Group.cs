using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Group
    {
        public int GroupId;
        public string GroupName;
        public Teacher TeacherId;
    }//TODO курс группа - принадлежность к какому-либо классу?

}
