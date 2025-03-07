namespace WFInicial
{
    partial class Formex09
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
            btnEntra = new Button();
            lbl1 = new Label();
            lbl2 = new Label();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            SuspendLayout();
            // 
            // btnEntra
            // 
            btnEntra.Location = new Point(176, 194);
            btnEntra.Name = "btnEntra";
            btnEntra.Size = new Size(132, 41);
            btnEntra.TabIndex = 0;
            btnEntra.Text = "Entra";
            btnEntra.UseVisualStyleBackColor = true;
            btnEntra.Click += btnEntra_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(33, 49);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(50, 15);
            lbl1.TabIndex = 1;
            lbl1.Text = "Usúario:";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(33, 129);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(42, 15);
            lbl2.TabIndex = 2;
            lbl2.Text = "Senha:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(122, 46);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(144, 23);
            txtUsuario.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(122, 121);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(144, 23);
            txtSenha.TabIndex = 4;
            // 
            // Formex09
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 260);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(btnEntra);
            Name = "Formex09";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formex09";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntra;
        private Label lbl1;
        private Label lbl2;
        private TextBox txtUsuario;
        private TextBox txtSenha;
    }
}