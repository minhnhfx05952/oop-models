using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_models.Models
{
    internal abstract class person
    {
        public int id { get; set; } 

        public string name { get; set; }
        public int age { get; set; }
        public string hometown { get; set; }
        public string score { get; set; }

    }
}
