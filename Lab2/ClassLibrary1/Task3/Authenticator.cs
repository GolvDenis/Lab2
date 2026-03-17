using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Task3
{
    public sealed class Authenticator
    {
        private static readonly Authenticator instance = new Authenticator();

        private Authenticator() { }

        public static Authenticator Instance
        {
            get { return instance; }
        }

        public void Authenticate(string user)
        {
            Console.WriteLine($"User {user} authenticated");
        }
    }

}
