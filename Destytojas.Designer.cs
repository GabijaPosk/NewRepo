
namespace Praktinis
{
    partial class Destytojas
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
            this.components = new System.ComponentModel.Container();
            this.AtsijungtiDest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.studentaipažymiaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pažymiaiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pažymiaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StudentsDVG = new System.Windows.Forms.DataGridView();
            this.studentTBL2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.praktinisDataSet10 = new Praktinis.PraktinisDataSet10();
            this.studentTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTBL2TableAdapter = new Praktinis.PraktinisDataSet10TableAdapters.StudentTBL2TableAdapter();
            this.PažymysDest = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StudDalykas = new System.Windows.Forms.TextBox();
            this.StudGrupė = new System.Windows.Forms.TextBox();
            this.StudPavarde = new System.Windows.Forms.TextBox();
            this.StudVardas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Vardas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stdidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stVardasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stPavardėDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stGrupėDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stMetaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stDalykasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stPažymysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.StudMetai = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentaipažymiaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pažymiaiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pažymiaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDVG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTBL2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinisDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AtsijungtiDest
            // 
            this.AtsijungtiDest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.AtsijungtiDest.Location = new System.Drawing.Point(1038, 21);
            this.AtsijungtiDest.Name = "AtsijungtiDest";
            this.AtsijungtiDest.Size = new System.Drawing.Size(88, 39);
            this.AtsijungtiDest.TabIndex = 1;
            this.AtsijungtiDest.Text = "Atsijungti";
            this.AtsijungtiDest.UseVisualStyleBackColor = false;
            this.AtsijungtiDest.Click += new System.EventHandler(this.AtsijungtiDest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(387, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "AKADEMINĖ SISTEMA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AtsijungtiDest);
            this.panel1.Location = new System.Drawing.Point(-1, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1153, 76);
            this.panel1.TabIndex = 5;
            // 
            // studentaipažymiaiBindingSource
            // 
            this.studentaipažymiaiBindingSource.DataMember = "Studentai/pažymiai";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(824, 174);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 39);
            this.button3.TabIndex = 29;
            this.button3.Text = "Ištrinti";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(534, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 39);
            this.button2.TabIndex = 28;
            this.button2.Text = "Redaguoti";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(214, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 39);
            this.button1.TabIndex = 27;
            this.button1.Text = "Pridėti";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pažymiaiBindingSource1
            // 
            this.pažymiaiBindingSource1.DataMember = "Pažymiai";
            // 
            // pažymiaiBindingSource
            // 
            this.pažymiaiBindingSource.DataMember = "Pažymiai";
            // 
            // StudentsDVG
            // 
            this.StudentsDVG.AutoGenerateColumns = false;
            this.StudentsDVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsDVG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stdidDataGridViewTextBoxColumn,
            this.stVardasDataGridViewTextBoxColumn,
            this.stPavardėDataGridViewTextBoxColumn,
            this.stGrupėDataGridViewTextBoxColumn,
            this.stMetaiDataGridViewTextBoxColumn,
            this.stDalykasDataGridViewTextBoxColumn,
            this.stPažymysDataGridViewTextBoxColumn});
            this.StudentsDVG.DataSource = this.studentTBL2BindingSource;
            this.StudentsDVG.Location = new System.Drawing.Point(27, 293);
            this.StudentsDVG.Name = "StudentsDVG";
            this.StudentsDVG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentsDVG.Size = new System.Drawing.Size(1098, 234);
            this.StudentsDVG.TabIndex = 30;
            this.StudentsDVG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsDVG_CellContentClick);
            // 
            // studentTBL2BindingSource
            // 
            this.studentTBL2BindingSource.DataMember = "StudentTBL2";
            this.studentTBL2BindingSource.DataSource = this.praktinisDataSet10;
            // 
            // praktinisDataSet10
            // 
            this.praktinisDataSet10.DataSetName = "PraktinisDataSet10";
            this.praktinisDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTblBindingSource
            // 
            this.studentTblBindingSource.DataMember = "StudentTbl";
            // 
            // studentTBL2TableAdapter
            // 
            this.studentTBL2TableAdapter.ClearBeforeFill = true;
            // 
            // PažymysDest
            // 
            this.PažymysDest.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PažymysDest.Location = new System.Drawing.Point(1005, 116);
            this.PažymysDest.Name = "PažymysDest";
            this.PažymysDest.Size = new System.Drawing.Size(120, 32);
            this.PažymysDest.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(804, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 39;
            this.label2.Text = "Dalykas";
            // 
            // StudDalykas
            // 
            this.StudDalykas.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudDalykas.Location = new System.Drawing.Point(729, 119);
            this.StudDalykas.Name = "StudDalykas";
            this.StudDalykas.Size = new System.Drawing.Size(240, 28);
            this.StudDalykas.TabIndex = 38;
            // 
            // StudGrupė
            // 
            this.StudGrupė.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudGrupė.Location = new System.Drawing.Point(410, 120);
            this.StudGrupė.Name = "StudGrupė";
            this.StudGrupė.Size = new System.Drawing.Size(126, 28);
            this.StudGrupė.TabIndex = 37;
            // 
            // StudPavarde
            // 
            this.StudPavarde.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudPavarde.Location = new System.Drawing.Point(184, 120);
            this.StudPavarde.Name = "StudPavarde";
            this.StudPavarde.Size = new System.Drawing.Size(193, 28);
            this.StudPavarde.TabIndex = 36;
            // 
            // StudVardas
            // 
            this.StudVardas.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudVardas.Location = new System.Drawing.Point(27, 120);
            this.StudVardas.Name = "StudVardas";
            this.StudVardas.Size = new System.Drawing.Size(124, 28);
            this.StudVardas.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(238, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 21);
            this.label6.TabIndex = 34;
            this.label6.Text = "Pavardė";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(445, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 33;
            this.label4.Text = "Grupė";
            // 
            // Vardas
            // 
            this.Vardas.AutoSize = true;
            this.Vardas.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vardas.Location = new System.Drawing.Point(49, 83);
            this.Vardas.Name = "Vardas";
            this.Vardas.Size = new System.Drawing.Size(62, 21);
            this.Vardas.TabIndex = 32;
            this.Vardas.Text = "Vardas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1033, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 40;
            this.label3.Text = "Pažymys";
            // 
            // stdidDataGridViewTextBoxColumn
            // 
            this.stdidDataGridViewTextBoxColumn.DataPropertyName = "Stdid";
            this.stdidDataGridViewTextBoxColumn.HeaderText = "Id";
            this.stdidDataGridViewTextBoxColumn.Name = "stdidDataGridViewTextBoxColumn";
            this.stdidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stVardasDataGridViewTextBoxColumn
            // 
            this.stVardasDataGridViewTextBoxColumn.DataPropertyName = "StVardas";
            this.stVardasDataGridViewTextBoxColumn.HeaderText = "Vardas";
            this.stVardasDataGridViewTextBoxColumn.Name = "stVardasDataGridViewTextBoxColumn";
            // 
            // stPavardėDataGridViewTextBoxColumn
            // 
            this.stPavardėDataGridViewTextBoxColumn.DataPropertyName = "StPavardė";
            this.stPavardėDataGridViewTextBoxColumn.HeaderText = "Pavardė";
            this.stPavardėDataGridViewTextBoxColumn.Name = "stPavardėDataGridViewTextBoxColumn";
            // 
            // stGrupėDataGridViewTextBoxColumn
            // 
            this.stGrupėDataGridViewTextBoxColumn.DataPropertyName = "StGrupė";
            this.stGrupėDataGridViewTextBoxColumn.HeaderText = "Grupė";
            this.stGrupėDataGridViewTextBoxColumn.Name = "stGrupėDataGridViewTextBoxColumn";
            // 
            // stMetaiDataGridViewTextBoxColumn
            // 
            this.stMetaiDataGridViewTextBoxColumn.DataPropertyName = "StMetai";
            this.stMetaiDataGridViewTextBoxColumn.HeaderText = "Metai";
            this.stMetaiDataGridViewTextBoxColumn.Name = "stMetaiDataGridViewTextBoxColumn";
            // 
            // stDalykasDataGridViewTextBoxColumn
            // 
            this.stDalykasDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stDalykasDataGridViewTextBoxColumn.DataPropertyName = "StDalykas";
            this.stDalykasDataGridViewTextBoxColumn.HeaderText = "Dalykas";
            this.stDalykasDataGridViewTextBoxColumn.Name = "stDalykasDataGridViewTextBoxColumn";
            // 
            // stPažymysDataGridViewTextBoxColumn
            // 
            this.stPažymysDataGridViewTextBoxColumn.DataPropertyName = "StPažymys";
            this.stPažymysDataGridViewTextBoxColumn.HeaderText = "Pažymys";
            this.stPažymysDataGridViewTextBoxColumn.Name = "stPažymysDataGridViewTextBoxColumn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(602, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 21);
            this.label5.TabIndex = 42;
            this.label5.Text = "Metai";
            // 
            // StudMetai
            // 
            this.StudMetai.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudMetai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudMetai.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StudMetai.Location = new System.Drawing.Point(571, 122);
            this.StudMetai.Name = "StudMetai";
            this.StudMetai.Size = new System.Drawing.Size(122, 26);
            this.StudMetai.TabIndex = 43;
            // 
            // Destytojas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1150, 563);
            this.ControlBox = false;
            this.Controls.Add(this.StudMetai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StudDalykas);
            this.Controls.Add(this.StudGrupė);
            this.Controls.Add(this.StudPavarde);
            this.Controls.Add(this.StudVardas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Vardas);
            this.Controls.Add(this.PažymysDest);
            this.Controls.Add(this.StudentsDVG);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Destytojas";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Destytojas";
            this.Load += new System.EventHandler(this.Destytojas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentaipažymiaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pažymiaiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pažymiaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDVG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTBL2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinisDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AtsijungtiDest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
     
        private System.Windows.Forms.BindingSource studentaipažymiaiBindingSource;
       
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
     
        private System.Windows.Forms.BindingSource pažymiaiBindingSource;
       
        private System.Windows.Forms.BindingSource pažymiaiBindingSource1;
       
        private System.Windows.Forms.DataGridView StudentsDVG;
      
        private System.Windows.Forms.BindingSource studentTblBindingSource;
     
        private PraktinisDataSet10 praktinisDataSet10;
        private System.Windows.Forms.BindingSource studentTBL2BindingSource;
        private PraktinisDataSet10TableAdapters.StudentTBL2TableAdapter studentTBL2TableAdapter;
        private System.Windows.Forms.TextBox PažymysDest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StudDalykas;
        private System.Windows.Forms.TextBox StudGrupė;
        private System.Windows.Forms.TextBox StudPavarde;
        private System.Windows.Forms.TextBox StudVardas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Vardas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stVardasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stPavardėDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stGrupėDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stMetaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stDalykasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stPažymysDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker StudMetai;
    }
}