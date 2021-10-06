using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariablesC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Nombre, Edad, ID, Telefono, Mostrar;

            Nombre = Convert.ToString(textBox1.Text);
            Edad = Convert.ToString(textBox2.Text);
            ID = Convert.ToString(textBox3.Text);
            Telefono = Convert.ToString(textBox4.Text);
            Mostrar = "Nombre:" + Nombre + "\r\n Edad:" + Edad + "\r\n ID:" + ID + "\r\n Telefono:" + Telefono;
            textBox5.Text = Convert.ToString(Mostrar);

        }
    }
}
