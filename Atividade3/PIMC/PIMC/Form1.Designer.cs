﻿
namespace PIMC
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAlt = new System.Windows.Forms.MaskedTextBox();
            this.txtPeso = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Altura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Script MT Bold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(5, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado";
            // 
            // txtAlt
            // 
            this.txtAlt.Location = new System.Drawing.Point(127, 53);
            this.txtAlt.Mask = "0.000";
            this.txtAlt.Name = "txtAlt";
            this.txtAlt.Size = new System.Drawing.Size(187, 23);
            this.txtAlt.TabIndex = 3;
            this.txtAlt.Validated += new System.EventHandler(this.txtAlt_Validated);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(127, 92);
            this.txtPeso.Mask = "900.00";
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(187, 23);
            this.txtPeso.TabIndex = 4;
            this.txtPeso.Validated += new System.EventHandler(this.txtPeso_Validated);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.Location = new System.Drawing.Point(326, 53);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(95, 33);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSair.Location = new System.Drawing.Point(326, 92);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(95, 34);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.Location = new System.Drawing.Point(326, 200);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(95, 35);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResult.Location = new System.Drawing.Point(127, 200);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(187, 39);
            this.txtResult.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 304);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtAlt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtAlt;
        private System.Windows.Forms.MaskedTextBox txtPeso;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtResult;
    }
}

