using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peso_Ideal
{
    public partial class Tela : Form
    {
        public Tela()
        {
            InitializeComponent();
        }

        private void btnPesoIdeal_Click(object sender, EventArgs e)
        {
            double Altura = 0, PesoIdeal = 0;
            Altura = double.Parse(txtAltura.Text);
            if (cmbSexo.Text=="Feminino")

            {
                PesoIdeal = (62.7 * Altura) - 44.7;
                MessageBox.Show(txtNome.Text + " seu peso ideial é: " + PesoIdeal.ToString(),
                    "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (cmbSexo.Text=="Masculino")
            {
                PesoIdeal = (72.7 * Altura) - 58;
                MessageBox.Show(txtNome.Text + " seu peso ideial é: " + PesoIdeal.ToString(),
                    "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Escolha o sexo", "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtNome.Clear();
            cmbSexo.Text = "";
        }
    }
}
