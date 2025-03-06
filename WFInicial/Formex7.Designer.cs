namespace WFInicial
{
    partial class Formex7
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
            lbl1 = new Label();
            label2 = new Label();
            txtValorProduto = new TextBox();
            txtNomeProduto = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(19, 46);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(33, 15);
            lbl1.TabIndex = 0;
            lbl1.Text = "Valor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 109);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Produto";
            // 
            // txtValorProduto
            // 
            txtValorProduto.Location = new Point(85, 101);
            txtValorProduto.Name = "txtValorProduto";
            txtValorProduto.Size = new Size(153, 23);
            txtValorProduto.TabIndex = 2;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(85, 43);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(153, 23);
            txtNomeProduto.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(80, 158);
            button1.Name = "button1";
            button1.Size = new Size(113, 23);
            button1.TabIndex = 4;
            button1.Text = "b";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Formex7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 236);
            Controls.Add(button1);
            Controls.Add(txtNomeProduto);
            Controls.Add(txtValorProduto);
            Controls.Add(label2);
            Controls.Add(lbl1);
            Name = "Formex7";
            Text = "Formex7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label label2;
        private TextBox txtValorProduto;
        private TextBox txtNomeProduto;
        private Button button1;
    }
}