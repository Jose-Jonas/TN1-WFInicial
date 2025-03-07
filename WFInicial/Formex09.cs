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
    public partial class Formex09 : Form
    {
        public Formex09()
        {
            InitializeComponent();
        }

        private void btnEntra_Click(object sender, EventArgs e)
        {
            Usuario us1 = new Usuario();
            bool entrou = true;
            us1.Nome = txtUsuario.Text;
            us1.Senha = txtSenha.Text;

            entrou = us1.Efetuarlogin();
            if (entrou == false)
            {
                txtUsuario.Text = "";
                txtSenha.Text = "";
            }
            else
            {
                MessageBox.Show("Bem Vindo ao Sistema!",
                    "Sucesso!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                //Fecha a Janela do Fornulário
                this.Dispose();
            }
        }
    }
}
