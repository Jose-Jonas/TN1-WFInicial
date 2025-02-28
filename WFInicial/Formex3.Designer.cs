namespace WFInicial
{
    partial class Formex3
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
            lblnum1 = new Label();
            lblnum2 = new Label();
            btnMaior = new Button();
            txtnum1 = new TextBox();
            txtnum2 = new TextBox();
            SuspendLayout();
            // 
            // lblnum1
            // 
            lblnum1.AutoSize = true;
            lblnum1.Location = new Point(27, 43);
            lblnum1.Name = "lblnum1";
            lblnum1.Size = new Size(62, 15);
            lblnum1.TabIndex = 0;
            lblnum1.Text = "1°Número";
            // 
            // lblnum2
            // 
            lblnum2.AutoSize = true;
            lblnum2.Location = new Point(27, 75);
            lblnum2.Name = "lblnum2";
            lblnum2.Size = new Size(62, 15);
            lblnum2.TabIndex = 1;
            lblnum2.Text = "2°Número";
            // 
            // btnMaior
            // 
            btnMaior.Location = new Point(52, 125);
            btnMaior.Name = "btnMaior";
            btnMaior.Size = new Size(114, 39);
            btnMaior.TabIndex = 2;
            btnMaior.Text = "Confirmação";
            btnMaior.UseVisualStyleBackColor = true;
            btnMaior.Click += btnMaior_Click;
            // 
            // txtnum1
            // 
            txtnum1.Location = new Point(95, 40);
            txtnum1.Name = "txtnum1";
            txtnum1.Size = new Size(122, 23);
            txtnum1.TabIndex = 3;
            // 
            // txtnum2
            // 
            txtnum2.Location = new Point(98, 69);
            txtnum2.Name = "txtnum2";
            txtnum2.Size = new Size(119, 23);
            txtnum2.TabIndex = 4;
            // 
            // Formex3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(230, 207);
            Controls.Add(txtnum2);
            Controls.Add(txtnum1);
            Controls.Add(btnMaior);
            Controls.Add(lblnum2);
            Controls.Add(lblnum1);
            Name = "Formex3";
            Text = "Formex3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnum1;
        private Label lblnum2;
        private Button btnMaior;
        private TextBox txtnum1;
        private TextBox txtnum2;
    }
}