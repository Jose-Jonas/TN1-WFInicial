namespace WFInicial
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ldlnota1 = new Label();
            btmCalcularMédia = new Button();
            txtnota1 = new TextBox();
            txtnota2 = new TextBox();
            ldlnota2 = new Label();
            SuspendLayout();
            // 
            // ldlnota1
            // 
            ldlnota1.AutoSize = true;
            ldlnota1.Location = new Point(70, 62);
            ldlnota1.Name = "ldlnota1";
            ldlnota1.Size = new Size(43, 15);
            ldlnota1.TabIndex = 0;
            ldlnota1.Text = "nota 1:";
            // 
            // btmCalcularMédia
            // 
            btmCalcularMédia.Location = new Point(117, 153);
            btmCalcularMédia.Name = "btmCalcularMédia";
            btmCalcularMédia.Size = new Size(100, 22);
            btmCalcularMédia.TabIndex = 2;
            btmCalcularMédia.Text = "Calcular ";
            btmCalcularMédia.UseVisualStyleBackColor = true;
            btmCalcularMédia.Click += btmCalcularMédia_Click;
            // 
            // txtnota1
            // 
            txtnota1.Location = new Point(131, 62);
            txtnota1.Name = "txtnota1";
            txtnota1.Size = new Size(86, 23);
            txtnota1.TabIndex = 3;
            // 
            // txtnota2
            // 
            txtnota2.Location = new Point(131, 107);
            txtnota2.Name = "txtnota2";
            txtnota2.Size = new Size(86, 23);
            txtnota2.TabIndex = 5;
            // 
            // ldlnota2
            // 
            ldlnota2.AutoSize = true;
            ldlnota2.Location = new Point(70, 110);
            ldlnota2.Name = "ldlnota2";
            ldlnota2.Size = new Size(43, 15);
            ldlnota2.TabIndex = 4;
            ldlnota2.Text = "nota 2:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 336);
            Controls.Add(txtnota2);
            Controls.Add(ldlnota2);
            Controls.Add(txtnota1);
            Controls.Add(btmCalcularMédia);
            Controls.Add(ldlnota1);
            Name = "Form1";
            Text = "Calcular Média das notas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ldlnota1;
        private Button btmCalcularMédia;
        private TextBox txtnota1;
        private TextBox txtnota2;
        private Label ldlnota2;
    }
}
