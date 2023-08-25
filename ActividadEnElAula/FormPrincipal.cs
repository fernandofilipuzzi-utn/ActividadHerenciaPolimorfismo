using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActividadEnElAula
{
    public partial class FormPrincipal : Form
    {
        Envio envio = new Envio();

        public FormPrincipal()
        {
            InitializeComponent();

            cbxCostosPosibles.Items.Add(new TasaAduanera(23));
            cbxCostosPosibles.Items.Add(new Seguro(3000, 4));
            cbxCostosPosibles.Items.Add(new Transporte(100, 1.3));
        }

        private void btnAltaEnvio_Click(object sender, EventArgs e)
        {
            envio = new Envio();

            btnAltaEnvio.Enabled = false;
        }

        private void btnCostos_Click(object sender, EventArgs e)
        {
            Costo cost = (Costo)(cbxCostosPosibles.SelectedItem);

            #region caso especial - para flashear un poco!
            //el modelo es medio pobre para hacer mas.

            bool confirmado = true;
            if (cost is Transporte)
            {
                FormDatos fDatos = new FormDatos();
                fDatos.lbConcepto.Text = "Distancia a transportar";
                if (fDatos.ShowDialog() == DialogResult.OK)
                {
                    ((Transporte)cost).Distancia = Convert.ToDouble(fDatos.tbValorConcepto.Text);
                }
                else
                {
                    confirmado = false;
                }
            }
            #endregion

            if(confirmado)
                envio.AgregarCosto(cost);

            cbxCostosPosibles.SelectedIndex = -1;
        }
        private void btnTicket_Click(object sender, EventArgs e)
        {
            lbxTicket.Items.Clear();
            /*
            Envio envio = new Envio();
            envio.AgregarCosto(new TasaAduanera(23));
            envio.AgregarCosto(new Seguro(3000, 4));
            envio.AgregarCosto(new Transporte(100,1.3));
           */
            for (int n = 0; n < envio.CantidadCostos; n++)
            {
                Costo costo = envio.VerCosto(n);
                 lbxTicket.Items.Add($"{costo,-40}{costo.Valor(),10:f2}");
               // lbxTicket.Items.Add(costo);
            }
            lbxTicket.Items.Add($"-------------------------------------------------------------");
            lbxTicket.Items.Add($"{"Costo Total$:",-40}{envio.ValorFinal(),10:f2}");
        }

        
    }
}
