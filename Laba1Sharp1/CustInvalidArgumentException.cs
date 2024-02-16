using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1Sharp1
{
     class CustInvalidArgumentException : Exception
    {
        public string Place { get; }
        public CustInvalidArgumentException(string message, string place) : base(message) {
        Place = place;
        }

        
    }
}
