using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_SOLID.Models
{
    public class User
    {
        public string Username { get; }
        public string Name { get; set; }

        public Password Password { get; }

        private bool _validCredentials = false;

        

        public bool IsAuthenticated
        {
            get
            {
                return _validCredentials;
            }
        }

        public User(string username, string name,  string password)
        {
            Username = username;
            Name = name;
           Password = password;
            
        }

        public void Authenticate()
        {
            // TODO: Validate with database data
            if (_validCredentials)
            {
                throw new Exception("El usuario ya está autenticado");
            }
            
        }
    }
}
