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
    public partial class Formex8 : Form
    {
        public Formex8()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double resultado, numero1, numero2 = 0;
            bool ehValidoNum1 = double.TryParse(txtNumero1.Text, out numero1);
            bool ehValidoNum2 = double.TryParse(txtNumero2.Text, out numero2);

            if (ehValidoNum1 == false || ehValidoNum2 == false)
            {
                MessageBox.Show("Os valores digitados não são números!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             if (rdbSoma.Checked == true)
            {
                resultado = numero1 + numero2;
                string mensagem = $"A Soma de {numero1} + {numero2} = {resultado}";
                MessageBox.Show(mensagem,"Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rdbDisao.Checked == true)
            {
                resultado = numero1 - numero2;
                string mensagem = $"A Divisão de {numero1} - {numero2} = {resultado}";
                MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rdbMultiplicacao.Checked == true)
            {
                resultado = numero1 * numero2;
                string mensagem = $"A Multiplicação de {numero1} * {numero2} = {resultado}";
                MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rdbPotenciacao.Checked == true)
            {
                resultado = numero1 % numero2;
                string mensagem = $"A soma de {numero1} % {numero2} = {resultado}";
                MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rdbSubtracao.Checked == true)
            {
                resultado = numero1 / numero2;
                string mensagem = $"A Subtração de {numero1} / {numero2} = {resultado}";
                MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rdbRadiacao.Checked == true)
            {
                if (numero2 == 0)
                    resultado = 1;
                else
                    resultado = Math.Pow(numero1, (1 / numero2));
              
                string mensagem = $"A Radiação de {numero1} ^ {numero2} = {resultado}";
                MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            kh


        }
    }
}
