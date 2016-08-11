using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeManager
{
    class Class1
    {
        public Class1()
        {

        }

        public void save_settings(string save_name, string[] settings)
        {
            if (save_name_exists(save_name))
            {
               
            }
        }

        public bool save_name_exists(string save_name)
        {
            if (File.Exists(save_name))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
