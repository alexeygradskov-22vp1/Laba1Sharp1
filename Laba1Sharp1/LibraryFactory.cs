using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1Sharp1
{
    abstract class LibraryFactory
    {
        public abstract Book CreateBook();
        public abstract Staff CreateStaff();
    }
}
