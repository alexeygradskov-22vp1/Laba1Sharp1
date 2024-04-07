using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1Sharp1
{
    class LibraryDepartment : Management
    {
         static List<String> extensionRequests = new List<String>();
       static  List<String> increaseBooksRequests = new List<String>();
        public void extensionRequest(string nameOfLibrary)
        {
            extensionRequests.Add(nameOfLibrary);
        }

        public void increaseBooksRequest(string nameOfLibrary)
        {
            increaseBooksRequests.Add(nameOfLibrary);
        }
    }
}
