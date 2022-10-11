using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_SOLID.Models
{
    public class PasswordDaysException : Exception
    {
        public PasswordDaysException(string message) : base(message) { }
    }
}
