
namespace Praktinis
{
    partial class Form1
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
            this.txt_prisijungimas = new System.Windows.Forms.TextBox();
            this.Prisijungti = new System.Windows.Forms.Button();
            this.Uždaryti = new System.Windows.Forms.Button();
            this.txt_slaptazodis = new System.Windows.Forms.TextBox();
            this.chkMatytiSlepti = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_prisijungimasStud = new System.Windows.Forms.TextBox();
            this.txt_slaptazodisStud = new System.Windows.Forms.TextBox();
            this.txt_prisijungimasDest = new System.Windows.Forms.TextBox();
            this.txt_slaptazodisDest = new System.Windows.Forms.TextBox();
            this.PrisijungtiStud = new System.Windows.Forms.Button();
            this.chkMatytiSlepti3 = new System.Windows.Forms.CheckBox();
            this.chkMatytiSlepti2 = new System.Windows.Forms.CheckBox();
            this.PrisijungtiDest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(81, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "AKADEMINĖ SISTEMA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(30, 601);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PRISIJUNGIMO VARDAS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(30, 649);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SLAPTAŽODIS";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_prisijungimas
            // 
            this.txt_prisijungimas.BackColor = System.Drawing.Color.White;
            this.txt_prisijungimas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_prisijungimas.Location = new System.Drawing.Point(197, 593);
            this.txt_prisijungimas.Name = "txt_prisijungimas";
            this.txt_prisijungimas.Size = new System.Drawing.Size(228, 26);
            this.txt_prisijungimas.TabIndex = 3;
            this.txt_prisijungimas.TextChanged += new System.EventHandler(this.txt_prisijungimas_TextChanged);
            // 
            // Prisijungti
            // 
            this.Prisijungti.BackColor = System.Drawing.Color.SteelBlue;
            this.Prisijungti.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Prisijungti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Prisijungti.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Prisijungti.Location = new System.Drawing.Point(329, 681);
            this.Prisijungti.Name = "Prisijungti";
            this.Prisijungti.Size = new System.Drawing.Size(96, 39);
            this.Prisijungti.TabIndex = 5;
            this.Prisijungti.Text = "Prisijungti";
            this.Prisijungti.UseVisualStyleBackColor = false;
            this.Prisijungti.Click += new System.EventHandler(this.Prisijungti_Click);
            // 
            // Uždaryti
            // 
            this.Uždaryti.BackColor = System.Drawing.Color.LightCoral;
            this.Uždaryti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Uždaryti.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Uždaryti.Location = new System.Drawing.Point(447, 753);
            this.Uždaryti.Name = "Uždaryti";
            this.Uždaryti.Size = new System.Drawing.Size(96, 39);
            this.Uždaryti.TabIndex = 6;
            this.Uždaryti.Text = "Uždaryti";
            this.Uždaryti.UseVisualStyleBackColor = false;
            this.Uždaryti.Click += new System.EventHandler(this.Uždaryti_Click);
            // 
            // txt_slaptazodis
            // 
            this.txt_slaptazodis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_slaptazodis.Location = new System.Drawing.Point(197, 641);
            this.txt_slaptazodis.Name = "txt_slaptazodis";
            this.txt_slaptazodis.Size = new System.Drawing.Size(228, 26);
            this.txt_slaptazodis.TabIndex = 4;
            // 
            // chkMatytiSlepti
            // 
            this.chkMatytiSlepti.AutoSize = true;
            this.chkMatytiSlepti.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkMatytiSlepti.Location = new System.Drawing.Point(33, 693);
            this.chkMatytiSlepti.Name = "chkMatytiSlepti";
            this.chkMatytiSlepti.Size = new System.Drawing.Size(113, 17);
            this.chkMatytiSlepti.TabIndex = 10;
            this.chkMatytiSlepti.Text = "Paslėpti slaptažodį";
            this.chkMatytiSlepti.UseVisualStyleBackColor = true;
            this.chkMatytiSlepti.CheckedChanged += new System.EventHandler(this.chkMatytiSlepti_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(30, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "SLAPTAŽODIS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(30, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "PRISIJUNGIMO VARDAS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(30, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "SLAPTAŽODIS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(30, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "PRISIJUNGIMO VARDAS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(271, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "STUDENTUI";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(271, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "DĖSTYTOJUI";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(246, 553);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 19);
            this.label10.TabIndex = 17;
            this.label10.Text = "ADMINISTRATORIUI";
            // 
            // txt_prisijungimasStud
            // 
            this.txt_prisijungimasStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_prisijungimasStud.Location = new System.Drawing.Point(197, 138);
            this.txt_prisijungimasStud.Name = "txt_prisijungimasStud";
            this.txt_prisijungimasStud.Size = new System.Drawing.Size(228, 26);
            this.txt_prisijungimasStud.TabIndex = 18;
            // 
            // txt_slaptazodisStud
            // 
            this.txt_slaptazodisStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_slaptazodisStud.Location = new System.Drawing.Point(197, 186);
            this.txt_slaptazodisStud.Name = "txt_slaptazodisStud";
            this.txt_slaptazodisStud.Size = new System.Drawing.Size(228, 26);
            this.txt_slaptazodisStud.TabIndex = 19;
            // 
            // txt_prisijungimasDest
            // 
            this.txt_prisijungimasDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_prisijungimasDest.Location = new System.Drawing.Point(197, 347);
            this.txt_prisijungimasDest.Name = "txt_prisijungimasDest";
            this.txt_prisijungimasDest.Size = new System.Drawing.Size(228, 26);
            this.txt_prisijungimasDest.TabIndex = 20;
            // 
            // txt_slaptazodisDest
            // 
            this.txt_slaptazodisDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_slaptazodisDest.Location = new System.Drawing.Point(197, 395);
            this.txt_slaptazodisDest.Name = "txt_slaptazodisDest";
            this.txt_slaptazodisDest.Size = new System.Drawing.Size(228, 26);
            this.txt_slaptazodisDest.TabIndex = 21;
            // 
            // PrisijungtiStud
            // 
            this.PrisijungtiStud.BackColor = System.Drawing.Color.SteelBlue;
            this.PrisijungtiStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrisijungtiStud.ForeColor = System.Drawing.Color.White;
            this.PrisijungtiStud.Location = new System.Drawing.Point(329, 231);
            this.PrisijungtiStud.Name = "PrisijungtiStud";
            this.PrisijungtiStud.Size = new System.Drawing.Size(96, 39);
            this.PrisijungtiStud.TabIndex = 26;
            this.PrisijungtiStud.Text = "Prisijungti";
            this.PrisijungtiStud.UseVisualStyleBackColor = false;
            this.PrisijungtiStud.Click += new System.EventHandler(this.PrisijungtiStud_Click);
            // 
            // chkMatytiSlepti3
            // 
            this.chkMatytiSlepti3.AutoSize = true;
            this.chkMatytiSlepti3.Location = new System.Drawing.Point(33, 243);
            this.chkMatytiSlepti3.Name = "chkMatytiSlepti3";
            this.chkMatytiSlepti3.Size = new System.Drawing.Size(113, 17);
            this.chkMatytiSlepti3.TabIndex = 24;
            this.chkMatytiSlepti3.Text = "Paslėpti slaptažodį";
            this.chkMatytiSlepti3.UseVisualStyleBackColor = true;
            this.chkMatytiSlepti3.CheckedChanged += new System.EventHandler(this.chkMatytiSlepti3_CheckedChanged);
            // 
            // chkMatytiSlepti2
            // 
            this.chkMatytiSlepti2.AutoSize = true;
            this.chkMatytiSlepti2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkMatytiSlepti2.Location = new System.Drawing.Point(33, 450);
            this.chkMatytiSlepti2.Name = "chkMatytiSlepti2";
            this.chkMatytiSlepti2.Size = new System.Drawing.Size(113, 17);
            this.chkMatytiSlepti2.TabIndex = 25;
            this.chkMatytiSlepti2.Text = "Paslėpti slaptažodį";
            this.chkMatytiSlepti2.UseVisualStyleBackColor = true;
            this.chkMatytiSlepti2.CheckedChanged += new System.EventHandler(this.chkMatytiSlepti2_CheckedChanged);
            // 
            // PrisijungtiDest
            // 
            this.PrisijungtiDest.BackColor = System.Drawing.Color.SteelBlue;
            this.PrisijungtiDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.PrisijungtiDest.ForeColor = System.Drawing.Color.White;
            this.PrisijungtiDest.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PrisijungtiDest.Location = new System.Drawing.Point(329, 438);
            this.PrisijungtiDest.Name = "PrisijungtiDest";
            this.PrisijungtiDest.Size = new System.Drawing.Size(96, 39);
            this.PrisijungtiDest.TabIndex = 27;
            this.PrisijungtiDest.Text = "Prisijungti";
            this.PrisijungtiDest.UseVisualStyleBackColor = false;
            this.PrisijungtiDest.Click += new System.EventHandler(this.PrisijungtiDest_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(555, 804);
            this.ControlBox = false;
            this.Controls.Add(this.PrisijungtiDest);
            this.Controls.Add(this.chkMatytiSlepti2);
            this.Controls.Add(this.chkMatytiSlepti3);
            this.Controls.Add(this.PrisijungtiStud);
            this.Controls.Add(this.txt_slaptazodisDest);
            this.Controls.Add(this.txt_prisijungimasDest);
            this.Controls.Add(this.txt_slaptazodisStud);
            this.Controls.Add(this.txt_prisijungimasStud);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkMatytiSlepti);
            this.Controls.Add(this.txt_slaptazodis);
            this.Controls.Add(this.Uždaryti);
            this.Controls.Add(this.Prisijungti);
            this.Controls.Add(this.txt_prisijungimas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prisijungimas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_prisijungimas;
        private System.Windows.Forms.Button Prisijungti;
        private System.Windows.Forms.Button Uždaryti;
        private System.Windows.Forms.TextBox txt_slaptazodis;
        private System.Windows.Forms.CheckBox chkMatytiSlepti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_prisijungimasStud;
        private System.Windows.Forms.TextBox txt_slaptazodisStud;
        private System.Windows.Forms.TextBox txt_prisijungimasDest;
        private System.Windows.Forms.TextBox txt_slaptazodisDest;
        private System.Windows.Forms.Button PrisijungtiStud;
        private System.Windows.Forms.CheckBox chkMatytiSlepti3;
        private System.Windows.Forms.CheckBox chkMatytiSlepti2;
        private System.Windows.Forms.Button PrisijungtiDest;
    }
}

