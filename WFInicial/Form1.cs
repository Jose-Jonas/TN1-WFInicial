using System.Security.Permissions;

namespace WFInicial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btmCalcularM�dia_Click(object sender, EventArgs e)
        {
            double nota1 = double.Parse(txtnota1.Text);
            double nota2 = double.Parse(txtnota2.Text);

            double media = (nota1 + nota2) / 2;

            if (media >= 7)
            {
                MessageBox.Show(
                    "Aprovado",
                    "ok",
                    MessageBoxButtons.OK,
                MessageBoxIcon.Information);


            }
            else if (media < 5)
            {
                MessageBox.Show(
                    "Reprovado",
                    "Deu Ruim",
                    MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(
                    "Recupera��o",
                    "Aten��o",
                    MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }

        private void InitializeComponent()
        {

        }
    }
}
