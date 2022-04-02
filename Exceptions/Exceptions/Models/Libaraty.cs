using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Models
{
    internal class Libaraty
    {
       public static bool secim(string book,string[]massive)
        { bool a=false;
            foreach (var item in massive)
            {
                if (book.ToLower()==item.ToLower())
                {
                a = true;

                }

            }
            if (a==false)
            {
                Console.WriteLine("soz yoxdur");
            }
            return a;
        }

        
    }
}
