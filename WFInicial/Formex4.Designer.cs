namespace WFInicial
{
    partial class Formex4
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
            btnMaior = new Button();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            lblnum1 = new Label();
            lblnum2 = new Label();
            lblnum3 = new Label();
            txtNum3 = new TextBox();
            SuspendLayout();
            // 
            // btnMaior
            // 
            btnMaior.Location = new Point(69, 155);
            btnMaior.Name = "btnMaior";
            btnMaior.Size = new Size(145, 38);
            btnMaior.TabIndex = 0;
            btnMaior.Text = "Confirmação";
            btnMaior.UseVisualStyleBackColor = true;
            btnMaior.Click += btnMaior_Click;
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(133, 43);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(107, 23);
            txtNum1.TabIndex = 1;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(133, 73);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(107, 23);
            txtNum2.TabIndex = 2;
            // 
            // lblnum1
            // 
            lblnum1.AutoSize = true;
            lblnum1.Location = new Point(51, 47);
            lblnum1.Name = "lblnum1";
            lblnum1.Size = new Size(65, 15);
            lblnum1.TabIndex = 3;
            lblnum1.Text = "1° Número";
            // 
            // lblnum2
            // 
            lblnum2.AutoSize = true;
            lblnum2.Location = new Point(51, 81);
            lblnum2.Name = "lblnum2";
            lblnum2.Size = new Size(65, 15);
            lblnum2.TabIndex = 4;
            lblnum2.Text = "2° Número";
            // 
            // lblnum3
            // 
            lblnum3.AutoSize = true;
            lblnum3.Location = new Point(51, 111);
            lblnum3.Name = "lblnum3";
            lblnum3.Size = new Size(62, 15);
            lblnum3.TabIndex = 5;
            lblnum3.Text = "3°Número";
            // 
            // txtNum3
            // 
            txtNum3.Location = new Point(130, 108);
            txtNum3.Name = "txtNum3";
            txtNum3.Size = new Size(110, 23);
            txtNum3.TabIndex = 6;
            // 
            // Formex4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 219);
            Controls.Add(txtNum3);
            Controls.Add(lblnum3);
            Controls.Add(lblnum2);
            Controls.Add(lblnum1);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(btnMaior);
            Name = "Formex4";
            Text = "Formex4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMaior;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private Label lblnum1;
        private Label lblnum2;
        private Label lblnum3;
        private TextBox txtNum3;
    }
}