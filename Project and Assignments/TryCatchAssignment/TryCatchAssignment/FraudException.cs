using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
  public class FraudException : Exception
    {
        public FraudException()
            : base()
        {

        }
        public FraudException(string message) //overloaded constructor that accepts a message
            : base("You lied about your age being " + message) //ouputs the error message if specific error is found
        {
        }
        
    }
}
