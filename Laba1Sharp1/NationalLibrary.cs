using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1Sharp1
{
    class NationalLibrary : LibraryFactory
    {
        public override Book CreateBook()
        {
            return new EducateBook();
        }

        public override Staff CreateStaff()
        {
            return new Librarian();
        }
    }
}
