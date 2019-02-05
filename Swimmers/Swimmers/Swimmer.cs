using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swimmers
{
    class Swimmer
    {

        public string name { get; set; }
        public string sex { get; set; }
        public int age { get; set; }
        public float DisplayTime { get; set; }

        public List<Race> races =  new List<Race>();

        public Swimmer(string name, string sex, int age)
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
        }
        
    }
}
