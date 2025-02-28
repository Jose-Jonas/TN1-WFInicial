namespace WFInicial
{
    partial class Formex2
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
            lblDia = new Label();
            btnCalcular = new Button();
            txtDia = new TextBox();
            SuspendLayout();
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Location = new Point(93, 71);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(144, 15);
            lblDia.TabIndex = 0;
            lblDia.Text = "Insira um numero de 1 a 7";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(119, 158);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(118, 36);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtDia
            // 
            txtDia.Location = new Point(103, 108);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(134, 23);
            txtDia.TabIndex = 2;
            // 
            // FormeEX2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 270);
            Controls.Add(txtDia);
            Controls.Add(btnCalcular);
            Controls.Add(lblDia);
            Name = "FormeEX2";
            Text = "FormeEX2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDia;
        private Button btnCalcular;
        private TextBox txtDia;
    }
}