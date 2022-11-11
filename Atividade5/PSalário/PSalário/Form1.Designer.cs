
namespace PSalário
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
            this.lblFunc = new System.Windows.Forms.Label();
            this.lblSalBruto = new System.Windows.Forms.Label();
            this.lblFilhos = new System.Windows.Forms.Label();
            this.lblDescontoINSS = new System.Windows.Forms.Label();
            this.lblDescontoIRPF = new System.Windows.Forms.Label();
            this.lblAliquotaINSS = new System.Windows.Forms.Label();
            this.lblAliquotaIRPF = new System.Windows.Forms.Label();
            this.lblSalFamilia = new System.Windows.Forms.Label();
            this.lblSalLiquido = new System.Windows.Forms.Label();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.ckbxCasado = new System.Windows.Forms.CheckBox();
            this.txtFunc = new System.Windows.Forms.TextBox();
            this.txtFilhos = new System.Windows.Forms.TextBox();
            this.mskbxSalBruto = new System.Windows.Forms.MaskedTextBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtDescontoINSS = new System.Windows.Forms.TextBox();
            this.txtDescontoIRPF = new System.Windows.Forms.TextBox();
            this.txtAliqINSS = new System.Windows.Forms.TextBox();
            this.txtAliqIRPF = new System.Windows.Forms.TextBox();
            this.txtSalFamilia = new System.Windows.Forms.TextBox();
            this.txtSalLiquido = new System.Windows.Forms.TextBox();
            this.txtResumo = new System.Windows.Forms.TextBox();
            this.gbxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFunc
            // 
            this.lblFunc.AutoSize = true;
            this.lblFunc.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblFunc.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFunc.Location = new System.Drawing.Point(12, 28);
            this.lblFunc.Name = "lblFunc";
            this.lblFunc.Size = new System.Drawing.Size(148, 20);
            this.lblFunc.TabIndex = 0;
            this.lblFunc.Text = "Nome do Funcionário:";
            // 
            // lblSalBruto
            // 
            this.lblSalBruto.AutoSize = true;
            this.lblSalBruto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblSalBruto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSalBruto.Location = new System.Drawing.Point(12, 101);
            this.lblSalBruto.Name = "lblSalBruto";
            this.lblSalBruto.Size = new System.Drawing.Size(151, 20);
            this.lblSalBruto.TabIndex = 1;
            this.lblSalBruto.Text = "Salário Bruto:              ";
            // 
            // lblFilhos
            // 
            this.lblFilhos.AutoSize = true;
            this.lblFilhos.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblFilhos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFilhos.Location = new System.Drawing.Point(12, 63);
            this.lblFilhos.Name = "lblFilhos";
            this.lblFilhos.Size = new System.Drawing.Size(152, 20);
            this.lblFilhos.TabIndex = 2;
            this.lblFilhos.Text = "Número de Filhos:       ";
            // 
            // lblDescontoINSS
            // 
            this.lblDescontoINSS.AutoSize = true;
            this.lblDescontoINSS.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblDescontoINSS.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescontoINSS.Location = new System.Drawing.Point(372, 149);
            this.lblDescontoINSS.Name = "lblDescontoINSS";
            this.lblDescontoINSS.Size = new System.Drawing.Size(110, 20);
            this.lblDescontoINSS.TabIndex = 3;
            this.lblDescontoINSS.Text = "Desconto INSS: ";
            // 
            // lblDescontoIRPF
            // 
            this.lblDescontoIRPF.AutoSize = true;
            this.lblDescontoIRPF.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblDescontoIRPF.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescontoIRPF.Location = new System.Drawing.Point(370, 188);
            this.lblDescontoIRPF.Name = "lblDescontoIRPF";
            this.lblDescontoIRPF.Size = new System.Drawing.Size(109, 20);
            this.lblDescontoIRPF.TabIndex = 4;
            this.lblDescontoIRPF.Text = "Desconto IRPF: ";
            // 
            // lblAliquotaINSS
            // 
            this.lblAliquotaINSS.AutoSize = true;
            this.lblAliquotaINSS.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblAliquotaINSS.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAliquotaINSS.Location = new System.Drawing.Point(371, 224);
            this.lblAliquotaINSS.Name = "lblAliquotaINSS";
            this.lblAliquotaINSS.Size = new System.Drawing.Size(108, 20);
            this.lblAliquotaINSS.TabIndex = 5;
            this.lblAliquotaINSS.Text = "Aliquota INSS  :";
            // 
            // lblAliquotaIRPF
            // 
            this.lblAliquotaIRPF.AutoSize = true;
            this.lblAliquotaIRPF.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblAliquotaIRPF.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAliquotaIRPF.Location = new System.Drawing.Point(372, 268);
            this.lblAliquotaIRPF.Name = "lblAliquotaIRPF";
            this.lblAliquotaIRPF.Size = new System.Drawing.Size(107, 20);
            this.lblAliquotaIRPF.TabIndex = 6;
            this.lblAliquotaIRPF.Text = "Aliquota IRPF  :";
            // 
            // lblSalFamilia
            // 
            this.lblSalFamilia.AutoSize = true;
            this.lblSalFamilia.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblSalFamilia.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSalFamilia.Location = new System.Drawing.Point(372, 315);
            this.lblSalFamilia.Name = "lblSalFamilia";
            this.lblSalFamilia.Size = new System.Drawing.Size(107, 20);
            this.lblSalFamilia.TabIndex = 7;
            this.lblSalFamilia.Text = "Salário Familia ";
            // 
            // lblSalLiquido
            // 
            this.lblSalLiquido.AutoSize = true;
            this.lblSalLiquido.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblSalLiquido.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSalLiquido.Location = new System.Drawing.Point(371, 359);
            this.lblSalLiquido.Name = "lblSalLiquido";
            this.lblSalLiquido.Size = new System.Drawing.Size(109, 20);
            this.lblSalLiquido.TabIndex = 8;
            this.lblSalLiquido.Text = "Salário Líquido:";
            // 
            // gbxSexo
            // 
            this.gbxSexo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gbxSexo.Controls.Add(this.rbtnFeminino);
            this.gbxSexo.Controls.Add(this.rbtnMasculino);
            this.gbxSexo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbxSexo.Location = new System.Drawing.Point(12, 146);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(165, 110);
            this.gbxSexo.TabIndex = 9;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Location = new System.Drawing.Point(6, 66);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(86, 24);
            this.rbtnFeminino.TabIndex = 1;
            this.rbtnFeminino.TabStop = true;
            this.rbtnFeminino.Text = "Feminino";
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(6, 36);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(91, 24);
            this.rbtnMasculino.TabIndex = 0;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // ckbxCasado
            // 
            this.ckbxCasado.AutoSize = true;
            this.ckbxCasado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ckbxCasado.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbxCasado.Location = new System.Drawing.Point(182, 146);
            this.ckbxCasado.Name = "ckbxCasado";
            this.ckbxCasado.Padding = new System.Windows.Forms.Padding(3, 40, 5, 40);
            this.ckbxCasado.Size = new System.Drawing.Size(180, 109);
            this.ckbxCasado.TabIndex = 10;
            this.ckbxCasado.Text = "Casado(a)           ";
            this.ckbxCasado.UseVisualStyleBackColor = false;
            this.ckbxCasado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textFunc_KeyPress);
            // 
            // txtFunc
            // 
            this.txtFunc.Location = new System.Drawing.Point(158, 28);
            this.txtFunc.Name = "txtFunc";
            this.txtFunc.Size = new System.Drawing.Size(204, 23);
            this.txtFunc.TabIndex = 11;
            this.txtFunc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textFunc_KeyPress);
            this.txtFunc.Validated += new System.EventHandler(this.txtFunc_Validated);
            // 
            // txtFilhos
            // 
            this.txtFilhos.Location = new System.Drawing.Point(158, 60);
            this.txtFilhos.Name = "txtFilhos";
            this.txtFilhos.Size = new System.Drawing.Size(204, 23);
            this.txtFilhos.TabIndex = 13;
            this.txtFilhos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFilhos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textFunc_KeyPress);
            this.txtFilhos.Validated += new System.EventHandler(this.txtFilhos_Validated);
            // 
            // mskbxSalBruto
            // 
            this.mskbxSalBruto.Location = new System.Drawing.Point(158, 98);
            this.mskbxSalBruto.Mask = "000000.00";
            this.mskbxSalBruto.Name = "mskbxSalBruto";
            this.mskbxSalBruto.Size = new System.Drawing.Size(204, 23);
            this.mskbxSalBruto.TabIndex = 14;
            this.mskbxSalBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mskbxSalBruto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textFunc_KeyPress);
            // 
            // btnValidar
            // 
            this.btnValidar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnValidar.Location = new System.Drawing.Point(9, 264);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(355, 71);
            this.btnValidar.TabIndex = 21;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            this.btnValidar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textFunc_KeyPress);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnLimpar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.Location = new System.Drawing.Point(184, 341);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(178, 45);
            this.btnLimpar.TabIndex = 22;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.button2_Click);
            this.btnLimpar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textFunc_KeyPress);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSair.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSair.Location = new System.Drawing.Point(9, 341);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(169, 45);
            this.btnSair.TabIndex = 23;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.button3_Click);
            this.btnSair.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textFunc_KeyPress);
            // 
            // txtDescontoINSS
            // 
            this.txtDescontoINSS.Location = new System.Drawing.Point(489, 146);
            this.txtDescontoINSS.Name = "txtDescontoINSS";
            this.txtDescontoINSS.Size = new System.Drawing.Size(272, 23);
            this.txtDescontoINSS.TabIndex = 24;
            // 
            // txtDescontoIRPF
            // 
            this.txtDescontoIRPF.Location = new System.Drawing.Point(489, 185);
            this.txtDescontoIRPF.Name = "txtDescontoIRPF";
            this.txtDescontoIRPF.Size = new System.Drawing.Size(272, 23);
            this.txtDescontoIRPF.TabIndex = 25;
            // 
            // txtAliqINSS
            // 
            this.txtAliqINSS.Location = new System.Drawing.Point(489, 221);
            this.txtAliqINSS.Name = "txtAliqINSS";
            this.txtAliqINSS.Size = new System.Drawing.Size(272, 23);
            this.txtAliqINSS.TabIndex = 26;
            // 
            // txtAliqIRPF
            // 
            this.txtAliqIRPF.Location = new System.Drawing.Point(489, 265);
            this.txtAliqIRPF.Name = "txtAliqIRPF";
            this.txtAliqIRPF.Size = new System.Drawing.Size(272, 23);
            this.txtAliqIRPF.TabIndex = 27;
            // 
            // txtSalFamilia
            // 
            this.txtSalFamilia.Location = new System.Drawing.Point(489, 312);
            this.txtSalFamilia.Name = "txtSalFamilia";
            this.txtSalFamilia.Size = new System.Drawing.Size(272, 23);
            this.txtSalFamilia.TabIndex = 28;
            // 
            // txtSalLiquido
            // 
            this.txtSalLiquido.Location = new System.Drawing.Point(489, 356);
            this.txtSalLiquido.Name = "txtSalLiquido";
            this.txtSalLiquido.Size = new System.Drawing.Size(272, 23);
            this.txtSalLiquido.TabIndex = 29;
            // 
            // txtResumo
            // 
            this.txtResumo.Location = new System.Drawing.Point(381, 29);
            this.txtResumo.Name = "txtResumo";
            this.txtResumo.Size = new System.Drawing.Size(380, 23);
            this.txtResumo.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::PSalário.Properties.Resources.branco____Artistas___Branco_Papel_de_Parede;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResumo);
            this.Controls.Add(this.txtSalLiquido);
            this.Controls.Add(this.txtSalFamilia);
            this.Controls.Add(this.txtAliqIRPF);
            this.Controls.Add(this.txtAliqINSS);
            this.Controls.Add(this.txtDescontoIRPF);
            this.Controls.Add(this.txtDescontoINSS);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.mskbxSalBruto);
            this.Controls.Add(this.txtFilhos);
            this.Controls.Add(this.txtFunc);
            this.Controls.Add(this.ckbxCasado);
            this.Controls.Add(this.gbxSexo);
            this.Controls.Add(this.lblSalLiquido);
            this.Controls.Add(this.lblSalFamilia);
            this.Controls.Add(this.lblAliquotaIRPF);
            this.Controls.Add(this.lblAliquotaINSS);
            this.Controls.Add(this.lblDescontoIRPF);
            this.Controls.Add(this.lblDescontoINSS);
            this.Controls.Add(this.lblFilhos);
            this.Controls.Add(this.lblSalBruto);
            this.Controls.Add(this.lblFunc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "App Salário";
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFunc;
        private System.Windows.Forms.Label lblSalBruto;
        private System.Windows.Forms.Label lblFilhos;
        private System.Windows.Forms.Label lblDescontoINSS;
        private System.Windows.Forms.Label lblDescontoIRPF;
        private System.Windows.Forms.Label lblAliquotaINSS;
        private System.Windows.Forms.Label lblAliquotaIRPF;
        private System.Windows.Forms.Label lblSalFamilia;
        private System.Windows.Forms.Label lblSalLiquido;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.RadioButton rbtnFeminino;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.CheckBox ckbxCasado;
        private System.Windows.Forms.TextBox txtFunc;
        private System.Windows.Forms.TextBox txtFilhos;
        private System.Windows.Forms.MaskedTextBox mskbxSalBruto;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtDescontoINSS;
        private System.Windows.Forms.TextBox txtDescontoIRPF;
        private System.Windows.Forms.TextBox txtAliqINSS;
        private System.Windows.Forms.TextBox txtAliqIRPF;
        private System.Windows.Forms.TextBox txtSalFamilia;
        private System.Windows.Forms.TextBox txtSalLiquido;
        private System.Windows.Forms.TextBox txtResumo;
    }
}

