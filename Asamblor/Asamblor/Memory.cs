using Asamblor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU
{
    public partial class Memory : Form
    {
        public Memory()
        {
            InitializeComponent();
            FillMem();
        }

        private void Memory_Load(object sender, EventArgs e)
        {

        }

        private void FillMem() 
        {
            foreach (var v in Emulator.fileContent)
            {
                string temp = Convert.ToString(v, 2);
                while (temp.Length < 8) 
                {
                    temp = "0" + temp;
                }
                listBox.Items.Add(temp);
            }
        }
    }
}
