namespace WFInicial
{
    partial class Formex8
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
            lbl2 = new Label();
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            rdbSoma = new RadioButton();
            gpxOperacao = new GroupBox();
            rdbRadiacao = new RadioButton();
            rdbPotenciacao = new RadioButton();
            rdbDisao = new RadioButton();
            rdbMultiplicacao = new RadioButton();
            rdbSubtracao = new RadioButton();
            btnCalcular = new Button();
            gpxOperacao.SuspendLayout();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(23, 36);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(60, 15);
            lbl1.TabIndex = 0;
            lbl1.Text = "Número1:";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(23, 106);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(60, 15);
            lbl2.TabIndex = 1;
            lbl2.Text = "Número2:";
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(23, 58);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(100, 23);
            txtNumero1.TabIndex = 2;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(23, 138);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(100, 23);
            txtNumero2.TabIndex = 3;
            // 
            // rdbSoma
            // 
            rdbSoma.AutoSize = true;
            rdbSoma.Location = new Point(6, 22);
            rdbSoma.Name = "rdbSoma";
            rdbSoma.Size = new Size(55, 19);
            rdbSoma.TabIndex = 4;
            rdbSoma.TabStop = true;
            rdbSoma.Text = "Soma";
            rdbSoma.UseVisualStyleBackColor = true;
            // 
            // gpxOperacao
            // 
            gpxOperacao.Controls.Add(rdbRadiacao);
            gpxOperacao.Controls.Add(rdbPotenciacao);
            gpxOperacao.Controls.Add(rdbDisao);
            gpxOperacao.Controls.Add(rdbMultiplicacao);
            gpxOperacao.Controls.Add(rdbSubtracao);
            gpxOperacao.Controls.Add(rdbSoma);
            gpxOperacao.Location = new Point(163, 36);
            gpxOperacao.Name = "gpxOperacao";
            gpxOperacao.Size = new Size(113, 160);
            gpxOperacao.TabIndex = 5;
            gpxOperacao.TabStop = false;
            gpxOperacao.Text = "Operação";
            // 
            // rdbRadiacao
            // 
            rdbRadiacao.AutoSize = true;
            rdbRadiacao.Location = new Point(6, 141);
            rdbRadiacao.Name = "rdbRadiacao";
            rdbRadiacao.Size = new Size(73, 19);
            rdbRadiacao.TabIndex = 9;
            rdbRadiacao.TabStop = true;
            rdbRadiacao.Text = "Radiação";
            rdbRadiacao.UseVisualStyleBackColor = true;
            // 
            // rdbPotenciacao
            // 
            rdbPotenciacao.AutoSize = true;
            rdbPotenciacao.Location = new Point(6, 116);
            rdbPotenciacao.Name = "rdbPotenciacao";
            rdbPotenciacao.Size = new Size(90, 19);
            rdbPotenciacao.TabIndex = 8;
            rdbPotenciacao.TabStop = true;
            rdbPotenciacao.Text = "Potenciação";
            rdbPotenciacao.UseVisualStyleBackColor = true;
            // 
            // rdbDisao
            // 
            rdbDisao.AutoSize = true;
            rdbDisao.Location = new Point(6, 91);
            rdbDisao.Name = "rdbDisao";
            rdbDisao.Size = new Size(63, 19);
            rdbDisao.TabIndex = 7;
            rdbDisao.TabStop = true;
            rdbDisao.Text = "Divisão";
            rdbDisao.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplicacao
            // 
            rdbMultiplicacao.AutoSize = true;
            rdbMultiplicacao.Location = new Point(6, 66);
            rdbMultiplicacao.Name = "rdbMultiplicacao";
            rdbMultiplicacao.Size = new Size(97, 19);
            rdbMultiplicacao.TabIndex = 6;
            rdbMultiplicacao.TabStop = true;
            rdbMultiplicacao.Text = "Multiplicação";
            rdbMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // rdbSubtracao
            // 
            rdbSubtracao.AutoSize = true;
            rdbSubtracao.Location = new Point(6, 41);
            rdbSubtracao.Name = "rdbSubtracao";
            rdbSubtracao.Size = new Size(78, 19);
            rdbSubtracao.TabIndex = 5;
            rdbSubtracao.TabStop = true;
            rdbSubtracao.Text = "Subtração";
            rdbSubtracao.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(23, 187);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 10;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Formex8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 271);
            Controls.Add(btnCalcular);
            Controls.Add(gpxOperacao);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Name = "Formex8";
            Text = "Formex8";
            gpxOperacao.ResumeLayout(false);
            gpxOperacao.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label lbl2;
        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private RadioButton rdbSoma;
        private GroupBox gpxOperacao;
        private RadioButton rdbRadiacao;
        private RadioButton rdbPotenciacao;
        private RadioButton rdbDisao;
        private RadioButton rdbMultiplicacao;
        private RadioButton rdbSubtracao;
        private Button btnCalcular;
    }
}