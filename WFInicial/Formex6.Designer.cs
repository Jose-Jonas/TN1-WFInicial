namespace WFInicial
{
    partial class Formex6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNome = new TextBox();
            txtValorHora = new TextBox();
            txtQuantHoras = new TextBox();
            lblNum1 = new Label();
            lblNum2 = new Label();
            lblNum3 = new Label();
            btnConfirma = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(129, 55);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(187, 23);
            txtNome.TabIndex = 0;
            // 
            // txtValorHora
            // 
            txtValorHora.Location = new Point(130, 114);
            txtValorHora.Name = "txtValorHora";
            txtValorHora.Size = new Size(119, 23);
            txtValorHora.TabIndex = 1;
            // 
            // txtQuantHoras
            // 
            txtQuantHoras.Location = new Point(129, 162);
            txtQuantHoras.Name = "txtQuantHoras";
            txtQuantHoras.Size = new Size(120, 23);
            txtQuantHoras.TabIndex = 2;
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(48, 58);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(43, 15);
            lblNum1.TabIndex = 3;
            lblNum1.Text = "Nome:";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Location = new Point(35, 117);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(65, 15);
            lblNum2.TabIndex = 4;
            lblNum2.Text = "Valor Hora:";
            // 
            // lblNum3
            // 
            lblNum3.AutoSize = true;
            lblNum3.Location = new Point(35, 170);
            lblNum3.Name = "lblNum3";
            lblNum3.Size = new Size(88, 15);
            lblNum3.TabIndex = 5;
            lblNum3.Text = "Quantas Horas:";
            // 
            // btnConfirma
            // 
            btnConfirma.Location = new Point(275, 113);
            btnConfirma.Name = "btnConfirma";
            btnConfirma.Size = new Size(76, 73);
            btnConfirma.TabIndex = 6;
            btnConfirma.Text = "Verficar";
            btnConfirma.UseVisualStyleBackColor = true;
            btnConfirma.Click += btnConfirma_Click;
            // 
            // Formex6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 227);
            Controls.Add(btnConfirma);
            Controls.Add(lblNum3);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            Controls.Add(txtQuantHoras);
            Controls.Add(txtValorHora);
            Controls.Add(txtNome);
            Name = "Formex6";
            Text = "Formex6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtValorHora;
        private TextBox txtQuantHoras;
        private Label lblNum1;
        private Label lblNum2;
        private Label lblNum3;
        private Button btnConfirma;
    }
}