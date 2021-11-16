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
        public int Id { get; set; }
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            if (emp1.Id == emp2.Id)
                return true;

            return false;

        }
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            if (emp1.Id != emp2.Id)
                return true;

            return false;

        }
        public override bool Equals(object obj)
        {
            return (obj as Employee).Id.Equals(this.Id);
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
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
