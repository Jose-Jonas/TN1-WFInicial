namespace WFInicial
{
    partial class Formex5
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
            lblNum1 = new Label();
            lblNum2 = new Label();
            lblNum3 = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            txtNum3 = new TextBox();
            btnConfirmação = new Button();
            SuspendLayout();
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(31, 45);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(62, 15);
            lblNum1.TabIndex = 0;
            lblNum1.Text = "1°Número";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Location = new Point(31, 82);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(62, 15);
            lblNum2.TabIndex = 1;
            lblNum2.Text = "2°Número";
            // 
            // lblNum3
            // 
            lblNum3.AutoSize = true;
            lblNum3.Location = new Point(31, 117);
            lblNum3.Name = "lblNum3";
            lblNum3.Size = new Size(62, 15);
            lblNum3.TabIndex = 2;
            lblNum3.Text = "3°Número";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(119, 42);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(124, 23);
            txtNum1.TabIndex = 3;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(119, 78);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(124, 23);
            txtNum2.TabIndex = 4;
            // 
            // txtNum3
            // 
            txtNum3.Location = new Point(119, 109);
            txtNum3.Name = "txtNum3";
            txtNum3.Size = new Size(130, 23);
            txtNum3.TabIndex = 5;
            // 
            // btnConfirmação
            // 
            btnConfirmação.Location = new Point(68, 183);
            btnConfirmação.Name = "btnConfirmação";
            btnConfirmação.Size = new Size(166, 39);
            btnConfirmação.TabIndex = 6;
            btnConfirmação.Text = "Confirmação";
            btnConfirmação.UseVisualStyleBackColor = true;
            btnConfirmação.Click += btnConfirmação_Click;
            // 
            // Formex5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 296);
            Controls.Add(btnConfirmação);
            Controls.Add(txtNum3);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(lblNum3);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            Name = "Formex5";
            Text = "Formex5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNum1;
        private Label lblNum2;
        private Label lblNum3;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private TextBox txtNum3;
        private Button btnConfirmação;
    }
}