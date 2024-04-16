using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1Sharp1
{
    public partial class LogsForm : Form
    {
        public LogsForm()
        {
            InitializeComponent();
            string[] list = File.ReadAllLines("Logs.txt");
            foreach (string s in list)
            {
                var listViewItem = new ListViewItem(s);
                LogsLV.Items.Add(listViewItem);
            }
            
        }
    }
}
