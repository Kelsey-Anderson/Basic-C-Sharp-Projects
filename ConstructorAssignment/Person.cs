using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class Person
    {
        public int id;
        public string Name;

        public Person(int id, string Name) //constructor
        {
            this.id = id;
            this.Name = Name;
        }


        public Person() : this(0, "") //constructor call chain
        {
        }



    }
}
