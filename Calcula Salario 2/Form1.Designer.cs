namespace Calcula_Salario_2
{
    partial class Calculadordesalario
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiasTrab = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorDiaria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblSalarioBase = new System.Windows.Forms.Label();
            this.lblValorIR = new System.Windows.Forms.Label();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.txtSalaBase = new System.Windows.Forms.MaskedTextBox();
            this.txtValorIR = new System.Windows.Forms.MaskedTextBox();
            this.txtSalarioLiquido = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(173, 99);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(299, 37);
            this.txtNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // txtDiasTrab
            // 
            this.txtDiasTrab.Location = new System.Drawing.Point(291, 164);
            this.txtDiasTrab.Name = "txtDiasTrab";
            this.txtDiasTrab.Size = new System.Drawing.Size(299, 37);
            this.txtDiasTrab.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dias trabalhados";
            // 
            // txtValorDiaria
            // 
            this.txtValorDiaria.Location = new System.Drawing.Point(291, 233);
            this.txtValorDiaria.Name = "txtValorDiaria";
            this.txtValorDiaria.Size = new System.Drawing.Size(299, 37);
            this.txtValorDiaria.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor da Diária";
            // 
            // mtxtCpf
            // 
            this.mtxtCpf.Location = new System.Drawing.Point(173, 34);
            this.mtxtCpf.Mask = "000.000.000-00";
            this.mtxtCpf.Name = "mtxtCpf";
            this.mtxtCpf.Size = new System.Drawing.Size(299, 37);
            this.mtxtCpf.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(676, 178);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(171, 92);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblSalarioBase
            // 
            this.lblSalarioBase.AutoSize = true;
            this.lblSalarioBase.Location = new System.Drawing.Point(23, 339);
            this.lblSalarioBase.Name = "lblSalarioBase";
            this.lblSalarioBase.Size = new System.Drawing.Size(193, 30);
            this.lblSalarioBase.TabIndex = 10;
            this.lblSalarioBase.Text = "Salário Base";
            this.lblSalarioBase.Visible = false;
            // 
            // lblValorIR
            // 
            this.lblValorIR.AutoSize = true;
            this.lblValorIR.Location = new System.Drawing.Point(23, 382);
            this.lblValorIR.Name = "lblValorIR";
            this.lblValorIR.Size = new System.Drawing.Size(178, 30);
            this.lblValorIR.TabIndex = 12;
            this.lblValorIR.Text = "Valor do IR";
            this.lblValorIR.Visible = false;
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Location = new System.Drawing.Point(23, 425);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(238, 30);
            this.lblSalarioLiquido.TabIndex = 14;
            this.lblSalarioLiquido.Text = "Salário Líquido";
            this.lblSalarioLiquido.Visible = false;
            // 
            // txtSalaBase
            // 
            this.txtSalaBase.Location = new System.Drawing.Point(291, 336);
            this.txtSalaBase.Mask = "$0000,00";
            this.txtSalaBase.Name = "txtSalaBase";
            this.txtSalaBase.ReadOnly = true;
            this.txtSalaBase.ShortcutsEnabled = false;
            this.txtSalaBase.Size = new System.Drawing.Size(299, 37);
            this.txtSalaBase.TabIndex = 15;
            this.txtSalaBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSalaBase.Visible = false;
            // 
            // txtValorIR
            // 
            this.txtValorIR.Location = new System.Drawing.Point(291, 379);
            this.txtValorIR.Mask = "$000,00";
            this.txtValorIR.Name = "txtValorIR";
            this.txtValorIR.ReadOnly = true;
            this.txtValorIR.ShortcutsEnabled = false;
            this.txtValorIR.Size = new System.Drawing.Size(299, 37);
            this.txtValorIR.TabIndex = 16;
            this.txtValorIR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValorIR.Visible = false;
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Location = new System.Drawing.Point(291, 425);
            this.txtSalarioLiquido.Mask = "$0000,00";
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.ReadOnly = true;
            this.txtSalarioLiquido.ShortcutsEnabled = false;
            this.txtSalarioLiquido.Size = new System.Drawing.Size(299, 37);
            this.txtSalarioLiquido.TabIndex = 17;
            this.txtSalarioLiquido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSalarioLiquido.Visible = false;
            // 
            // Calculadordesalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 507);
            this.Controls.Add(this.txtSalarioLiquido);
            this.Controls.Add(this.txtValorIR);
            this.Controls.Add(this.txtSalaBase);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.lblValorIR);
            this.Controls.Add(this.lblSalarioBase);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.mtxtCpf);
            this.Controls.Add(this.txtValorDiaria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDiasTrab);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculadordesalario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculador de Salário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtDiasTrab;
        private Label label3;
        private TextBox txtValorDiaria;
        private Label label4;
        private MaskedTextBox mtxtCpf;
        private Button btnCalcular;
        
        private Label lblSalarioBase;
        private Label lblValorIR;
        private Label lblSalarioLiquido;
        private MaskedTextBox txtSalaBase;
        private MaskedTextBox txtValorIR;
        private MaskedTextBox txtSalarioLiquido;
    }
}