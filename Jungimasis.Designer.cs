
namespace Praktinis
{
    partial class Jungimasis
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Stud = new System.Windows.Forms.Button();
            this.Dest = new System.Windows.Forms.Button();
            this.Admin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(114, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRISIJUNGIMAS STUDENTAMS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(113, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "PRISIJUNGIMAS DĖSTYTOJAMS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(114, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "PRISIJUNGIMAS ADMINISTRATORIUI";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Stud
            // 
            this.Stud.BackColor = System.Drawing.Color.SteelBlue;
            this.Stud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stud.ForeColor = System.Drawing.Color.White;
            this.Stud.Location = new System.Drawing.Point(170, 47);
            this.Stud.Name = "Stud";
            this.Stud.Size = new System.Drawing.Size(83, 30);
            this.Stud.TabIndex = 3;
            this.Stud.Text = "Prisijungti";
            this.Stud.UseVisualStyleBackColor = false;
            this.Stud.Click += new System.EventHandler(this.Stud_Click);
            // 
            // Dest
            // 
            this.Dest.BackColor = System.Drawing.Color.SteelBlue;
            this.Dest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dest.ForeColor = System.Drawing.Color.White;
            this.Dest.Location = new System.Drawing.Point(170, 145);
            this.Dest.Name = "Dest";
            this.Dest.Size = new System.Drawing.Size(83, 30);
            this.Dest.TabIndex = 4;
            this.Dest.Text = "Prisijungti";
            this.Dest.UseVisualStyleBackColor = false;
            // 
            // Admin
            // 
            this.Admin.BackColor = System.Drawing.Color.SteelBlue;
            this.Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.ForeColor = System.Drawing.Color.White;
            this.Admin.Location = new System.Drawing.Point(170, 236);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(83, 30);
            this.Admin.TabIndex = 5;
            this.Admin.Text = "Prisijungti";
            this.Admin.UseVisualStyleBackColor = false;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // Jungimasis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(425, 303);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.Dest);
            this.Controls.Add(this.Stud);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Jungimasis";
            this.Text = "Jungimasis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Stud;
        private System.Windows.Forms.Button Dest;
        private System.Windows.Forms.Button Admin;
    }
}