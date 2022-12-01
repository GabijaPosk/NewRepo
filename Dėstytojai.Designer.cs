
namespace Praktinis
{
    partial class Dėstytojai
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
            this.Grįžti1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DestPavarde = new System.Windows.Forms.TextBox();
            this.DestVardas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Vardas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DestMetai = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            
            this.dėstytojaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            
            this.IstrintiDest = new System.Windows.Forms.Button();
            this.RedaguotiDest = new System.Windows.Forms.Button();
            this.PridetiDest = new System.Windows.Forms.Button();
            this.DestDVG = new System.Windows.Forms.DataGridView();
            this.praktinisDataSet9 = new Praktinis.PraktinisDataSet9();
            this.destytTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.destytTBLTableAdapter = new Praktinis.PraktinisDataSet9TableAdapters.DestytTBLTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vardasDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pavardėDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dalykaiDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metaiDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DestDalykai = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
        
            ((System.ComponentModel.ISupportInitialize)(this.dėstytojaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DestDVG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinisDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destytTBLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Grįžti1
            // 
            this.Grįžti1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Grįžti1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grįžti1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Grįžti1.Location = new System.Drawing.Point(860, 13);
            this.Grįžti1.Name = "Grįžti1";
            this.Grįžti1.Size = new System.Drawing.Size(89, 37);
            this.Grįžti1.TabIndex = 6;
            this.Grįžti1.Text = "Grįžti";
            this.Grįžti1.UseVisualStyleBackColor = false;
            this.Grįžti1.Click += new System.EventHandler(this.Grįžti1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(361, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "DĖSTYTOJAI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.Grįžti1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 74);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // DestPavarde
            // 
            this.DestPavarde.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestPavarde.Location = new System.Drawing.Point(229, 154);
            this.DestPavarde.Name = "DestPavarde";
            this.DestPavarde.Size = new System.Drawing.Size(158, 28);
            this.DestPavarde.TabIndex = 18;
            // 
            // DestVardas
            // 
            this.DestVardas.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestVardas.Location = new System.Drawing.Point(28, 154);
            this.DestVardas.Name = "DestVardas";
            this.DestVardas.Size = new System.Drawing.Size(158, 28);
            this.DestVardas.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(275, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Pavardė";
            // 
            // Vardas
            // 
            this.Vardas.AutoSize = true;
            this.Vardas.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vardas.Location = new System.Drawing.Point(77, 117);
            this.Vardas.Name = "Vardas";
            this.Vardas.Size = new System.Drawing.Size(62, 21);
            this.Vardas.TabIndex = 15;
            this.Vardas.Text = "Vardas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(714, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Dėstomas Dalykas";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DestMetai
            // 
            this.DestMetai.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestMetai.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DestMetai.Location = new System.Drawing.Point(428, 154);
            this.DestMetai.Name = "DestMetai";
            this.DestMetai.Size = new System.Drawing.Size(158, 28);
            this.DestMetai.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(477, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Data";
            // 
            // praktinisDataSet3
            // 
        
            // 
            // dėstytojaiBindingSource
            // 
            this.dėstytojaiBindingSource.DataMember = "Dėstytojai";
           
            // 
            // dėstytojaiTableAdapter
            // 
           
            // 
            // IstrintiDest
            // 
            this.IstrintiDest.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.IstrintiDest.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IstrintiDest.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IstrintiDest.Location = new System.Drawing.Point(679, 213);
            this.IstrintiDest.Name = "IstrintiDest";
            this.IstrintiDest.Size = new System.Drawing.Size(122, 39);
            this.IstrintiDest.TabIndex = 26;
            this.IstrintiDest.Text = "Ištrinti";
            this.IstrintiDest.UseVisualStyleBackColor = false;
            this.IstrintiDest.Click += new System.EventHandler(this.IstrintiDest_Click);
            // 
            // RedaguotiDest
            // 
            this.RedaguotiDest.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RedaguotiDest.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedaguotiDest.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RedaguotiDest.Location = new System.Drawing.Point(428, 213);
            this.RedaguotiDest.Name = "RedaguotiDest";
            this.RedaguotiDest.Size = new System.Drawing.Size(122, 39);
            this.RedaguotiDest.TabIndex = 25;
            this.RedaguotiDest.Text = "Redaguoti";
            this.RedaguotiDest.UseVisualStyleBackColor = false;
            this.RedaguotiDest.Click += new System.EventHandler(this.RedaguotiDest_Click);
            // 
            // PridetiDest
            // 
            this.PridetiDest.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PridetiDest.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PridetiDest.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PridetiDest.Location = new System.Drawing.Point(163, 213);
            this.PridetiDest.Name = "PridetiDest";
            this.PridetiDest.Size = new System.Drawing.Size(122, 39);
            this.PridetiDest.TabIndex = 24;
            this.PridetiDest.Text = "Pridėti";
            this.PridetiDest.UseVisualStyleBackColor = false;
            this.PridetiDest.Click += new System.EventHandler(this.PridetiDest_Click);
            // 
            // DestDVG
            // 
            this.DestDVG.AutoGenerateColumns = false;
            this.DestDVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DestDVG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.vardasDDataGridViewTextBoxColumn,
            this.pavardėDDataGridViewTextBoxColumn,
            this.dalykaiDDataGridViewTextBoxColumn,
            this.metaiDDataGridViewTextBoxColumn});
            this.DestDVG.DataSource = this.destytTBLBindingSource;
            this.DestDVG.Location = new System.Drawing.Point(28, 276);
            this.DestDVG.Name = "DestDVG";
            this.DestDVG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DestDVG.Size = new System.Drawing.Size(907, 241);
            this.DestDVG.TabIndex = 28;
            this.DestDVG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DestDVG_CellContentClick);
            // 
            // praktinisDataSet9
            // 
            this.praktinisDataSet9.DataSetName = "PraktinisDataSet9";
            this.praktinisDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // destytTBLBindingSource
            // 
            this.destytTBLBindingSource.DataMember = "DestytTBL";
            this.destytTBLBindingSource.DataSource = this.praktinisDataSet9;
            // 
            // destytTBLTableAdapter
            // 
            this.destytTBLTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // vardasDDataGridViewTextBoxColumn
            // 
            this.vardasDDataGridViewTextBoxColumn.DataPropertyName = "VardasD";
            this.vardasDDataGridViewTextBoxColumn.HeaderText = "VardasD";
            this.vardasDDataGridViewTextBoxColumn.Name = "vardasDDataGridViewTextBoxColumn";
            this.vardasDDataGridViewTextBoxColumn.Width = 150;
            // 
            // pavardėDDataGridViewTextBoxColumn
            // 
            this.pavardėDDataGridViewTextBoxColumn.DataPropertyName = "PavardėD";
            this.pavardėDDataGridViewTextBoxColumn.HeaderText = "PavardėD";
            this.pavardėDDataGridViewTextBoxColumn.Name = "pavardėDDataGridViewTextBoxColumn";
            this.pavardėDDataGridViewTextBoxColumn.Width = 150;
            // 
            // dalykaiDDataGridViewTextBoxColumn
            // 
            this.dalykaiDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dalykaiDDataGridViewTextBoxColumn.DataPropertyName = "DalykaiD";
            this.dalykaiDDataGridViewTextBoxColumn.HeaderText = "DalykaiD";
            this.dalykaiDDataGridViewTextBoxColumn.Name = "dalykaiDDataGridViewTextBoxColumn";
            // 
            // metaiDDataGridViewTextBoxColumn
            // 
            this.metaiDDataGridViewTextBoxColumn.DataPropertyName = "MetaiD";
            this.metaiDDataGridViewTextBoxColumn.HeaderText = "MetaiD";
            this.metaiDDataGridViewTextBoxColumn.Name = "metaiDDataGridViewTextBoxColumn";
            this.metaiDDataGridViewTextBoxColumn.Width = 150;
            // 
            // DestDalykai
            // 
            this.DestDalykai.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestDalykai.Location = new System.Drawing.Point(627, 154);
            this.DestDalykai.Name = "DestDalykai";
            this.DestDalykai.Size = new System.Drawing.Size(308, 28);
            this.DestDalykai.TabIndex = 29;
            // 
            // Dėstytojai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 563);
            this.ControlBox = false;
            this.Controls.Add(this.DestDalykai);
            this.Controls.Add(this.DestDVG);
            this.Controls.Add(this.IstrintiDest);
            this.Controls.Add(this.RedaguotiDest);
            this.Controls.Add(this.PridetiDest);
            this.Controls.Add(this.DestMetai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DestPavarde);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DestVardas);
            this.Controls.Add(this.Vardas);
            this.Controls.Add(this.label6);
            this.Name = "Dėstytojai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dėstytojai";
            this.Load += new System.EventHandler(this.Dėstytojai_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dėstytojaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DestDVG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinisDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destytTBLBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Grįžti1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox DestPavarde;
        private System.Windows.Forms.TextBox DestVardas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Vardas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DestMetai;
        private System.Windows.Forms.Label label3;
        
        private System.Windows.Forms.BindingSource dėstytojaiBindingSource;
        
        private System.Windows.Forms.Button IstrintiDest;
        private System.Windows.Forms.Button RedaguotiDest;
        private System.Windows.Forms.Button PridetiDest;
        private System.Windows.Forms.DataGridView DestDVG;
        private PraktinisDataSet9 praktinisDataSet9;
        private System.Windows.Forms.BindingSource destytTBLBindingSource;
        private PraktinisDataSet9TableAdapters.DestytTBLTableAdapter destytTBLTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vardasDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pavardėDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dalykaiDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metaiDDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox DestDalykai;
    }
}