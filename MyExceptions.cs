using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataToCSV
{
    class MyExceptions
    {
    }
    class InvalidCredentialsException : Exception
    {
        string MyMessage;
        public InvalidCredentialsException(string Messsage)
        {
            MyMessage = Message;            
        }
        public override string Message => MyMessage;

    }
}
