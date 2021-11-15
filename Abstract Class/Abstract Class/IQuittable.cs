using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    interface IQuittable
    {
        public bool IsQuitting { get; set; }
        public abstract void Quit();
        

        
    }
}
