using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Models
{
    internal class Not:Exception
    {
        public Not(string message) : base(message)
        {
          
        }
    }
}
