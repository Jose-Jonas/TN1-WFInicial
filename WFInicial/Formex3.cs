using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFInicial
{
    public partial class Formex3 : Form
    {
        public Formex3()
        {
            InitializeComponent();
        }

        

        private void btnMaior_Click(object sender, EventArgs e)
        {
int num1 = int.Parse(txtnum1.Text);
            int num2 = int.Parse(txtnum2.Text);

            int maior = Math.Max(num1, num2);

            string mensagem = $"O Número {maior} é o maior!";

            MessageBox.Show(mensagem, "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
