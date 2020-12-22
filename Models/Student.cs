using CodeFirst.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Student: Entity
    {
        public int Age { get; set; }

        public int Role { get; set; }

        public string Name { get; set; }

        public int Class { get; set; }

        public string Section { get; set; }
    }
}
