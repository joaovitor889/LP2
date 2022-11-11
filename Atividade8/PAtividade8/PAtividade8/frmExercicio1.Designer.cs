
namespace PAtividade8
{
    partial class frmExercicio1
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
            this.btnPares = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnEspaço = new System.Windows.Forms.Button();
            this.rchtxtFrase = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnPares
            // 
            this.btnPares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPares.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPares.Location = new System.Drawing.Point(542, 144);
            this.btnPares.Name = "btnPares";
            this.btnPares.Size = new System.Drawing.Size(180, 60);
            this.btnPares.TabIndex = 7;
            this.btnPares.Text = "Numeros de pares";
            this.btnPares.UseVisualStyleBackColor = true;
            this.btnPares.Click += new System.EventHandler(this.btnPares_Click);
            // 
            // btnR
            // 
            this.btnR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnR.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnR.Location = new System.Drawing.Point(542, 78);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(180, 60);
            this.btnR.TabIndex = 6;
            this.btnR.Text = "Numeros de R";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnEspaço
            // 
            this.btnEspaço.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEspaço.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEspaço.Location = new System.Drawing.Point(542, 12);
            this.btnEspaço.Name = "btnEspaço";
            this.btnEspaço.Size = new System.Drawing.Size(180, 60);
            this.btnEspaço.TabIndex = 5;
            this.btnEspaço.Text = "Espaços em Branco";
            this.btnEspaço.UseVisualStyleBackColor = true;
            this.btnEspaço.Click += new System.EventHandler(this.btnEspaço_Click);
            // 
            // rchtxtFrase
            // 
            this.rchtxtFrase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rchtxtFrase.Location = new System.Drawing.Point(12, 12);
            this.rchtxtFrase.Name = "rchtxtFrase";
            this.rchtxtFrase.Size = new System.Drawing.Size(524, 319);
            this.rchtxtFrase.TabIndex = 4;
            this.rchtxtFrase.Text = "";
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(734, 351);
            this.Controls.Add(this.btnPares);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnEspaço);
            this.Controls.Add(this.rchtxtFrase);
            this.Name = "frmExercicio1";
            this.Text = "frmExercicio1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPares;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnEspaço;
        private System.Windows.Forms.RichTextBox rchtxtFrase;
    }
}