using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace prueba_SOLID.Models
{
    public class Password
    {
        private int DaysSinceChange = 0;
        private string Characters { get; set; }

        public Password(string characters)
        {
            Characters = characters;
            DaysSinceChange = 0;
        }
        
        public Password RSAencode()
        {

        }

        public Password AESencode()
        {

        }

        public void ChangePassword(string newPassword)
        {
            if (DaysSinceChange < 20)
            {
                throw new PasswordDaysException("Puedes cambiar la contraseña tras 20 días del último cambio");
            }
            else
            {
                Characters = newPassword;
                DaysSinceChange = 0;
            }
        }
    }
}
