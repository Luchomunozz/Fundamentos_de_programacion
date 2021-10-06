using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExposiciónCiclos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ejecut_Click(object sender, EventArgs e)
        {           
            for (int i = 1; i <= 10000; i++)
                Números.Items.Add(i);
 
        }
    }
}
