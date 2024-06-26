﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1Sharp1
{
    class CultureManagement : Management
    {
        List<String> extensionRequests = new List<String>();
        List<String> increaseBooksRequests = new List<String>();

        private String _name = "Министерство культуры";
        public void extensionRequest(string nameOfLibrary)
        {
            extensionRequests.Add(nameOfLibrary);
        }

        public void increaseBooksRequest(string nameOfLibrary)
        {
            increaseBooksRequests.Add(nameOfLibrary);
        }

        public String getName()
        {
            return _name;
        }
    }
}
