using System.Security.Permissions;

namespace WFInicial
{
    public partial class Formex1 : Form
    {
        public Formex1()
        {
            InitializeComponent();
        }

        private void btmCalcularMédia_Click(object sender, EventArgs e)
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
                    "Recuperação",
                    "Atenção",
                    MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }

        private void InitializeComponent()
        {
            btnCalcular = new Button();
            label1 = new Label();
            txtnota1 = new TextBox();
            label2 = new Label();
            txtnota2 = new TextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(71, 122);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(111, 35);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 45);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Nota1";
            // 
            // txtnota1
            // 
            txtnota1.Location = new Point(87, 45);
            txtnota1.Name = "txtnota1";
            txtnota1.Size = new Size(81, 23);
            txtnota1.TabIndex = 2;
            txtnota1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 82);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 3;
            label2.Text = "nota2";
            // 
            // txtnota2
            // 
            txtnota2.Location = new Point(87, 80);
            txtnota2.Name = "txtnota2";
            txtnota2.Size = new Size(81, 23);
            txtnota2.TabIndex = 4;
            // 
            // Form1
            // 
            ClientSize = new Size(284, 261);
            Controls.Add(txtnota2);
            Controls.Add(label2);
            Controls.Add(txtnota1);
            Controls.Add(label1);
            Controls.Add(btnCalcular);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private Button btnCalcular;
        private Label label1;
        private Label label2;
        private TextBox txtnota2;
        private TextBox txtnota1;
    }
}
