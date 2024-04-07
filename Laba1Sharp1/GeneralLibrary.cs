using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1Sharp1
{
    class GeneralLibrary : LibraryFactory
    {
        public override Book CreateBook()
        {
            return new ArtisticBook();
        }

        public override Staff CreateStaff()
        {
            return new Bibliographer();
        }
    }
}
