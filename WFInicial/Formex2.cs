using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFInicial
{
    public partial class Formex2 : Form
    {
        public Formex2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(txtDia.Text);
            switch (dia)
            {
                case (1):
                    MessageBox.Show(
                    "Domingo",
                    "OK",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    break;
                case (2):
                    MessageBox.Show(
                    "Segunda",
                    "OK",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    break;
                case (3):
                    MessageBox.Show(
                    "Terça",
                    "OK",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    break;
                case (4):
                    MessageBox.Show(
                    "Quarta",
                    "OK",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    break;
                case (5):
                    MessageBox.Show(
                    "Quinta",
                    "OK",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    break;
                case (6):
                    MessageBox.Show(
                    "Sexta",
                    "OK",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    break;
                case (7):
                    MessageBox.Show(
                    "Sábado",
                    "OK",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    break;
                default:
                    MessageBox.Show(
                    "Número incorreto",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    break;
            }
        }
    }
}

