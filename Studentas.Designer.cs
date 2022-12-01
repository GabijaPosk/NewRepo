
namespace Praktinis
{
    partial class Studentas
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
            this.AtsijungtiStud = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PažymiaiLentelė = new System.Windows.Forms.DataGridView();
            this.studentTBL2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.praktinisDataSet10 = new Praktinis.PraktinisDataSet10();
            this.pažymiaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTBL2TableAdapter = new Praktinis.PraktinisDataSet10TableAdapters.StudentTBL2TableAdapter();
            this.stdidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stVardasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stPavardėDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stGrupėDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stMetaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stDalykasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stPažymysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PažymiaiLentelė)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTBL2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinisDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pažymiaiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AtsijungtiStud
            // 
            this.AtsijungtiStud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.AtsijungtiStud.Location = new System.Drawing.Point(675, 12);
            this.AtsijungtiStud.Name = "AtsijungtiStud";
            this.AtsijungtiStud.Size = new System.Drawing.Size(88, 38);
            this.AtsijungtiStud.TabIndex = 0;
            this.AtsijungtiStud.Text = "Atsijungti";
            this.AtsijungtiStud.UseVisualStyleBackColor = false;
            this.AtsijungtiStud.Click += new System.EventHandler(this.AtsijungtiStud_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AtsijungtiStud);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 76);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(173, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "AKADEMINĖ SISTEMA";
            // 
            // PažymiaiLentelė
            // 
            this.PažymiaiLentelė.AllowUserToAddRows = false;
            this.PažymiaiLentelė.AllowUserToDeleteRows = false;
            this.PažymiaiLentelė.AutoGenerateColumns = false;
            this.PažymiaiLentelė.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PažymiaiLentelė.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stdidDataGridViewTextBoxColumn,
            this.stVardasDataGridViewTextBoxColumn,
            this.stPavardėDataGridViewTextBoxColumn,
            this.stGrupėDataGridViewTextBoxColumn,
            this.stMetaiDataGridViewTextBoxColumn,
            this.stDalykasDataGridViewTextBoxColumn,
            this.stPažymysDataGridViewTextBoxColumn});
            this.PažymiaiLentelė.DataSource = this.studentTBL2BindingSource;
            this.PažymiaiLentelė.Location = new System.Drawing.Point(27, 151);
            this.PažymiaiLentelė.Name = "PažymiaiLentelė";
            this.PažymiaiLentelė.ReadOnly = true;
            this.PažymiaiLentelė.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PažymiaiLentelė.Size = new System.Drawing.Size(717, 400);
            this.PažymiaiLentelė.TabIndex = 6;
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
            // pažymiaiBindingSource
            // 
            this.pažymiaiBindingSource.DataMember = "Pažymiai";
            // 
            // studentTBL2TableAdapter
            // 
            this.studentTBL2TableAdapter.ClearBeforeFill = true;
            // 
            // stdidDataGridViewTextBoxColumn
            // 
            this.stdidDataGridViewTextBoxColumn.DataPropertyName = "Stdid";
            this.stdidDataGridViewTextBoxColumn.HeaderText = "Stdid";
            this.stdidDataGridViewTextBoxColumn.Name = "stdidDataGridViewTextBoxColumn";
            this.stdidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stVardasDataGridViewTextBoxColumn
            // 
            this.stVardasDataGridViewTextBoxColumn.DataPropertyName = "StVardas";
            this.stVardasDataGridViewTextBoxColumn.HeaderText = "StVardas";
            this.stVardasDataGridViewTextBoxColumn.Name = "stVardasDataGridViewTextBoxColumn";
            this.stVardasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stPavardėDataGridViewTextBoxColumn
            // 
            this.stPavardėDataGridViewTextBoxColumn.DataPropertyName = "StPavardė";
            this.stPavardėDataGridViewTextBoxColumn.HeaderText = "StPavardė";
            this.stPavardėDataGridViewTextBoxColumn.Name = "stPavardėDataGridViewTextBoxColumn";
            this.stPavardėDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stGrupėDataGridViewTextBoxColumn
            // 
            this.stGrupėDataGridViewTextBoxColumn.DataPropertyName = "StGrupė";
            this.stGrupėDataGridViewTextBoxColumn.HeaderText = "StGrupė";
            this.stGrupėDataGridViewTextBoxColumn.Name = "stGrupėDataGridViewTextBoxColumn";
            this.stGrupėDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stMetaiDataGridViewTextBoxColumn
            // 
            this.stMetaiDataGridViewTextBoxColumn.DataPropertyName = "StMetai";
            this.stMetaiDataGridViewTextBoxColumn.HeaderText = "StMetai";
            this.stMetaiDataGridViewTextBoxColumn.Name = "stMetaiDataGridViewTextBoxColumn";
            this.stMetaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stDalykasDataGridViewTextBoxColumn
            // 
            this.stDalykasDataGridViewTextBoxColumn.DataPropertyName = "StDalykas";
            this.stDalykasDataGridViewTextBoxColumn.HeaderText = "StDalykas";
            this.stDalykasDataGridViewTextBoxColumn.Name = "stDalykasDataGridViewTextBoxColumn";
            this.stDalykasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stPažymysDataGridViewTextBoxColumn
            // 
            this.stPažymysDataGridViewTextBoxColumn.DataPropertyName = "StPažymys";
            this.stPažymysDataGridViewTextBoxColumn.HeaderText = "StPažymys";
            this.stPažymysDataGridViewTextBoxColumn.Name = "stPažymysDataGridViewTextBoxColumn";
            this.stPažymysDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Studentas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(770, 563);
            this.ControlBox = false;
            this.Controls.Add(this.PažymiaiLentelė);
            this.Controls.Add(this.panel1);
            this.Name = "Studentas";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Studentas";
            this.Load += new System.EventHandler(this.Studentas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PažymiaiLentelė)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTBL2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinisDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pažymiaiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AtsijungtiStud;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView PažymiaiLentelė;
       
        private System.Windows.Forms.BindingSource pažymiaiBindingSource;
        
        private PraktinisDataSet10 praktinisDataSet10;
        private System.Windows.Forms.BindingSource studentTBL2BindingSource;
        private PraktinisDataSet10TableAdapters.StudentTBL2TableAdapter studentTBL2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stVardasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stPavardėDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stGrupėDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stMetaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stDalykasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stPažymysDataGridViewTextBoxColumn;
    }
}