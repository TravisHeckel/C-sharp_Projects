using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    public class Employee <T> //allows for generic variable type
    {
        public List<T> Things { get; set; } //standard list that we can get and set items in an instance
    }
}
