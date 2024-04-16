using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1Sharp1
{
    class LibraryCommandAdd : Command
    {
        private Library _lib;
        private string _name;

        public LibraryCommandAdd(string name,Library lib)
        {
            _lib = lib;
            _name = name;
        }

        public void Execute()
        {
            
            Library.AddInList(_name, _lib);
            File.AppendAllText("logs.txt", $"Пользователь добавил библиотеку с именем {_lib.Name}," +
                $" по адресу {_lib.Address} \n");
        }
    }
}
