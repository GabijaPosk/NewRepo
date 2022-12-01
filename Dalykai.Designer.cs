
namespace Praktinis
{
    partial class Dalykai
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Grįžti1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
           
            this.dėstytojaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
           
            this.vardasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pavardėDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gimimodataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dėstomasdalykasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
           
            ((System.ComponentModel.ISupportInitialize)(this.dėstytojaiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.Grįžti1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 74);
            this.panel1.TabIndex = 8;
            // 
            // Grįžti1
            // 
            this.Grįžti1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Grįžti1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grįžti1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Grįžti1.Location = new System.Drawing.Point(700, 17);
            this.Grįžti1.Name = "Grįžti1";
            this.Grįžti1.Size = new System.Drawing.Size(89, 37);
            this.Grįžti1.TabIndex = 6;
            this.Grįžti1.Text = "Grįžti";
            this.Grįžti1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(214, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "DĖSTOMI DALYKAI";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vardasDataGridViewTextBoxColumn,
            this.pavardėDataGridViewTextBoxColumn,
            this.gimimodataDataGridViewTextBoxColumn,
            this.dėstomasdalykasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dėstytojaiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 150);
            this.dataGridView1.TabIndex = 9;
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
            // vardasDataGridViewTextBoxColumn
            // 
            this.vardasDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vardasDataGridViewTextBoxColumn.DataPropertyName = "Vardas";
            this.vardasDataGridViewTextBoxColumn.HeaderText = "Vardas";
            this.vardasDataGridViewTextBoxColumn.Name = "vardasDataGridViewTextBoxColumn";
            // 
            // pavardėDataGridViewTextBoxColumn
            // 
            this.pavardėDataGridViewTextBoxColumn.DataPropertyName = "Pavardė";
            this.pavardėDataGridViewTextBoxColumn.HeaderText = "Pavardė";
            this.pavardėDataGridViewTextBoxColumn.Name = "pavardėDataGridViewTextBoxColumn";
            // 
            // gimimodataDataGridViewTextBoxColumn
            // 
            this.gimimodataDataGridViewTextBoxColumn.DataPropertyName = "Gimimo_data";
            this.gimimodataDataGridViewTextBoxColumn.HeaderText = "Gimimo_data";
            this.gimimodataDataGridViewTextBoxColumn.Name = "gimimodataDataGridViewTextBoxColumn";
            // 
            // dėstomasdalykasDataGridViewTextBoxColumn
            // 
            this.dėstomasdalykasDataGridViewTextBoxColumn.DataPropertyName = "Dėstomas_dalykas";
            this.dėstomasdalykasDataGridViewTextBoxColumn.HeaderText = "Dėstomas_dalykas";
            this.dėstomasdalykasDataGridViewTextBoxColumn.Name = "dėstomasdalykasDataGridViewTextBoxColumn";
            this.dėstomasdalykasDataGridViewTextBoxColumn.Width = 398;
            // 
            // Dalykai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Dalykai";
            this.Text = "Dalykai";
            this.Load += new System.EventHandler(this.Dalykai_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         
            ((System.ComponentModel.ISupportInitialize)(this.dėstytojaiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Grįžti1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
       
        private System.Windows.Forms.BindingSource dėstytojaiBindingSource;
     
        private System.Windows.Forms.DataGridViewTextBoxColumn vardasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pavardėDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gimimodataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dėstomasdalykasDataGridViewTextBoxColumn;
    }
}