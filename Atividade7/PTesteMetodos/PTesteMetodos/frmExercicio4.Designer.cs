
namespace PTesteMetodos
{
    partial class frmExercicio4
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
            this.rchtxtFrase = new System.Windows.Forms.RichTextBox();
            this.btnNumeros = new System.Windows.Forms.Button();
            this.btnEspaco = new System.Windows.Forms.Button();
            this.btnLetras = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rchtxtFrase
            // 
            this.rchtxtFrase.Location = new System.Drawing.Point(157, 12);
            this.rchtxtFrase.Name = "rchtxtFrase";
            this.rchtxtFrase.Size = new System.Drawing.Size(515, 387);
            this.rchtxtFrase.TabIndex = 0;
            this.rchtxtFrase.Text = "";
            // 
            // btnNumeros
            // 
            this.btnNumeros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNumeros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumeros.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNumeros.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNumeros.Location = new System.Drawing.Point(0, 130);
            this.btnNumeros.Name = "btnNumeros";
            this.btnNumeros.Size = new System.Drawing.Size(151, 65);
            this.btnNumeros.TabIndex = 1;
            this.btnNumeros.Text = "Quantidade de Numeros";
            this.btnNumeros.UseVisualStyleBackColor = true;
            this.btnNumeros.Click += new System.EventHandler(this.btnNumeros_Click);
            // 
            // btnEspaco
            // 
            this.btnEspaco.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEspaco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEspaco.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEspaco.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEspaco.Location = new System.Drawing.Point(0, 65);
            this.btnEspaco.Name = "btnEspaco";
            this.btnEspaco.Size = new System.Drawing.Size(151, 65);
            this.btnEspaco.TabIndex = 2;
            this.btnEspaco.Text = "Primeiro Caracter em Branco";
            this.btnEspaco.UseVisualStyleBackColor = true;
            this.btnEspaco.Click += new System.EventHandler(this.btnEspaco_Click);
            // 
            // btnLetras
            // 
            this.btnLetras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLetras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetras.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLetras.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLetras.Location = new System.Drawing.Point(0, 0);
            this.btnLetras.Name = "btnLetras";
            this.btnLetras.Size = new System.Drawing.Size(151, 65);
            this.btnLetras.TabIndex = 3;
            this.btnLetras.Text = "Quantidade de Letras";
            this.btnLetras.UseVisualStyleBackColor = true;
            this.btnLetras.Click += new System.EventHandler(this.btnLetras_Click);
            // 
            // Limpar
            // 
            this.Limpar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Limpar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Limpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Limpar.Location = new System.Drawing.Point(0, 346);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(151, 65);
            this.Limpar.TabIndex = 4;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnNumeros);
            this.panel1.Controls.Add(this.Limpar);
            this.panel1.Controls.Add(this.btnEspaco);
            this.panel1.Controls.Add(this.btnLetras);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 411);
            this.panel1.TabIndex = 5;
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rchtxtFrase);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtFrase;
        private System.Windows.Forms.Button btnNumeros;
        private System.Windows.Forms.Button btnEspaco;
        private System.Windows.Forms.Button btnLetras;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Panel panel1;
    }
}