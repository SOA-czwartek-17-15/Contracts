using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountRepository
{
    class Program
    {
        static void Main(string[] args)
        {
            string serviceRepository = "net.tcp://localhost:54321/ServiceRepo";//to powinno byc odczytane z app.config
            //strworzenie clienta do service repo
            //zarejestrowanie swojej uslugi
            //odpalenie timera w celu wysylania Alive
            //stworznie AccountRepository i przekazanie mu serviceRepository zeby odpytac o potrzebne sewisy

            // logowanie
        }
    }

    public class AccountRepository : IAccountRepository
    {
        public Account CreateAccount(Guid clientId)
        {
            return null;
        }

    }
}
