using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                DialogResult save_error_dialog = MessageBox.Show($"The name '{save_name}' is already used for another config. Press OK to overwrite the file or press CANCEL to rename it and try again.", "Error saving your config", MessageBoxButtons.OKCancel);
                if(save_error_dialog == DialogResult.Yes)
                {
                    write_settings(save_name, settings);
                }
                else if(save_error_dialog == DialogResult.Abort || save_error_dialog == DialogResult.Cancel)
                {

                }
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

        public void write_settings(string save_name, string[] settings)
        {

        }

        public string[] load_settings()
        {

            return new string[0];
        }
    }
}
