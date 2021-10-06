using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemplosDeFundamentosDeProgramacion
{
    public partial class Autos : Form
    {
        public Autos()
        {
            InitializeComponent();
        }

        private void lblnombre_Click(object sender, EventArgs e)
        {

        }

        private void chkAire_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            double costo = 0.0;
            string cotizacion = "";

            cotizacion = " Cotizacion de auto para " + txtnombre.Text;

            // Costo Inicial Del Vehiculo // 

            costo = Convert.ToDouble(txtCosto.Text);

            // Verificar Seguros // 

            if (rbnbasico.Checked == true) {
                costo = costo + 500.0;
                cotizacion += "LLeva Seguro Basico De $500 \r\n";
            }
            if (rbnTerceros.Checked == true) {
                costo += 700.0;
                cotizacion += "Lleva Seguro A Terceros de $700 \r\n";
            }
            if (rbnTotal.Checked == true) {
                costo += 1000.0;
                cotizacion += "Lleva Seguro Total de $1000 \r\n";
            }   

            // Verificar Equipo // 

            if(chkAire.Checked == true)
            {
                costo += 500.0;
                cotizacion += "Con Aire Acondicionado de $500 \r\n";
            }
            if (chkAudio.Checked == true)
            {
                costo += 1000.0;
                cotizacion += "Con Sistema de Audio $1000 \r\n";
            }
            if (chkAvanzada.Checked == true)
            {
                costo += 2000.0;
                cotizacion += "Con Un Sistema Avanzado $2000 \r\n";
            }

            // Mostrando Total //
            
            cotizacion += "El total a pagar es de " + costo.ToString();

            txtCotizacion.Text = cotizacion;
        }

    }
}
