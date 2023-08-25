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
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void btnTicket_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Envio envio  = new Envio();

            envio.AgregarCosto(new TasaAduanera(23));
            envio.AgregarCosto(new Seguro(3000, 4));
            envio.AgregarCosto(new Transporte(100,1.3));
           
            for (int n = 0; n < envio.CantidadCostos; n++)
            {
                Costo costo = envio.VerCosto(n);
                 listBox1.Items.Add($"{costo,-40}{costo.Valor(),10:f2}");
               // listBox1.Items.Add(costo);
            }
            listBox1.Items.Add($"-------------------------------------------------------------");
            listBox1.Items.Add($"{"Costo Total$:",-40}{envio.ValorFinal(),10:f2}");
        }
    }
}
