using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: [" + FirstName + " " + LastName + "]");
        }

        public bool IsQuitting { get; set; }
        public void Quit()
        {
           if (IsQuitting == true)
            {
                Console.WriteLine(FirstName + LastName + " has put in their two weeks. Please speak with this employee, to discuss an exit interview.");
            }
           else
            {
                return;
            }
        }

    }
}
