using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show($"The name 'example' is already used for another config. Press OK to overwrite the file or press CANCEL to rename it and try again.", "Error saving your config", MessageBoxButtons.OKCancel);
        }
    }
}
