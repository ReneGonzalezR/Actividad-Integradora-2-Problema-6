using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_Integradora_2_Problema_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblTotal.Text = string.Empty;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            double total = 0;
            switch (txtSector.Text)
            {
                case "Sol Candente":
                    total = Convert.ToInt32(txtEntradas.Text) * 300;
                    lblTotal.Text = string.Format("Total: ${0} ",total );
                    break;
                case "Sol Luminoso":
                    total = Convert.ToInt32(txtEntradas.Text) * 530;
                    lblTotal.Text = string.Format("Total: ${0} ", total);
                    break;
                case "Sombrita":
                    total = Convert.ToInt32(txtEntradas.Text) * 610;
                    lblTotal.Text = string.Format("Total: ${0} ", total);
                    break;
                case "Tribuna":
                    total = Convert.ToInt32(txtEntradas.Text) * 820;
                    lblTotal.Text = string.Format("Total: ${0} ", total);
                    break;
                case "Silla Plastica":
                    total = Convert.ToInt32(txtEntradas.Text) * 930;
                    lblTotal.Text = string.Format("Total: ${0} ", total);
                    break;
            }
        }
    }
}
