
namespace PAtividade8
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
            this.btnExe1 = new System.Windows.Forms.Button();
            this.btnExe2 = new System.Windows.Forms.Button();
            this.btnExe3 = new System.Windows.Forms.Button();
            this.btnExe4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExe1
            // 
            this.btnExe1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExe1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExe1.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExe1.Location = new System.Drawing.Point(0, 0);
            this.btnExe1.Name = "btnExe1";
            this.btnExe1.Size = new System.Drawing.Size(150, 75);
            this.btnExe1.TabIndex = 0;
            this.btnExe1.Text = "Exercício 1";
            this.btnExe1.UseVisualStyleBackColor = true;
            this.btnExe1.Click += new System.EventHandler(this.btnExe1_Click);
            // 
            // btnExe2
            // 
            this.btnExe2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExe2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExe2.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExe2.Location = new System.Drawing.Point(0, 75);
            this.btnExe2.Name = "btnExe2";
            this.btnExe2.Size = new System.Drawing.Size(150, 75);
            this.btnExe2.TabIndex = 1;
            this.btnExe2.Text = "Exercício 2";
            this.btnExe2.UseVisualStyleBackColor = true;
            this.btnExe2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExe3
            // 
            this.btnExe3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExe3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExe3.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExe3.Location = new System.Drawing.Point(0, 150);
            this.btnExe3.Name = "btnExe3";
            this.btnExe3.Size = new System.Drawing.Size(150, 75);
            this.btnExe3.TabIndex = 2;
            this.btnExe3.Text = "Exercício 3";
            this.btnExe3.UseVisualStyleBackColor = true;
            this.btnExe3.Click += new System.EventHandler(this.btnExe3_Click);
            // 
            // btnExe4
            // 
            this.btnExe4.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExe4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExe4.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExe4.Location = new System.Drawing.Point(0, 225);
            this.btnExe4.Name = "btnExe4";
            this.btnExe4.Size = new System.Drawing.Size(150, 75);
            this.btnExe4.TabIndex = 3;
            this.btnExe4.Text = "Exercício 4";
            this.btnExe4.UseVisualStyleBackColor = true;
            this.btnExe4.Click += new System.EventHandler(this.btnExe4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExe4);
            this.panel1.Controls.Add(this.btnExe3);
            this.panel1.Controls.Add(this.btnExe2);
            this.panel1.Controls.Add(this.btnExe1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 361);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(182)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(884, 361);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExe1;
        private System.Windows.Forms.Button btnExe2;
        private System.Windows.Forms.Button btnExe3;
        private System.Windows.Forms.Button btnExe4;
        private System.Windows.Forms.Panel panel1;
    }
}

