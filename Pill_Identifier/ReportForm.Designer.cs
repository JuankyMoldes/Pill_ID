namespace Pill_Identifier
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pillimprintDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pillcolorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pillshapeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drugnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drugstrengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pillphotoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pharmaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmaDataSet = new Pill_Identifier.pharmaDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pillimprintDataGridViewTextBoxColumn,
            this.pillcolorDataGridViewTextBoxColumn,
            this.pillshapeDataGridViewTextBoxColumn,
            this.drugnameDataGridViewTextBoxColumn,
            this.drugstrengthDataGridViewTextBoxColumn,
            this.pillphotoDataGridViewTextBoxColumn,
            this.creationdateDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "pills";
            this.dataGridView1.DataSource = this.pharmaDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(746, 402);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pillimprintDataGridViewTextBoxColumn
            // 
            this.pillimprintDataGridViewTextBoxColumn.DataPropertyName = "pill_imprint";
            this.pillimprintDataGridViewTextBoxColumn.HeaderText = "pill_imprint";
            this.pillimprintDataGridViewTextBoxColumn.Name = "pillimprintDataGridViewTextBoxColumn";
            // 
            // pillcolorDataGridViewTextBoxColumn
            // 
            this.pillcolorDataGridViewTextBoxColumn.DataPropertyName = "pill_color";
            this.pillcolorDataGridViewTextBoxColumn.HeaderText = "pill_color";
            this.pillcolorDataGridViewTextBoxColumn.Name = "pillcolorDataGridViewTextBoxColumn";
            // 
            // pillshapeDataGridViewTextBoxColumn
            // 
            this.pillshapeDataGridViewTextBoxColumn.DataPropertyName = "pill_shape";
            this.pillshapeDataGridViewTextBoxColumn.HeaderText = "pill_shape";
            this.pillshapeDataGridViewTextBoxColumn.Name = "pillshapeDataGridViewTextBoxColumn";
            // 
            // drugnameDataGridViewTextBoxColumn
            // 
            this.drugnameDataGridViewTextBoxColumn.DataPropertyName = "drug_name";
            this.drugnameDataGridViewTextBoxColumn.HeaderText = "drug_name";
            this.drugnameDataGridViewTextBoxColumn.Name = "drugnameDataGridViewTextBoxColumn";
            // 
            // drugstrengthDataGridViewTextBoxColumn
            // 
            this.drugstrengthDataGridViewTextBoxColumn.DataPropertyName = "drug_strength";
            this.drugstrengthDataGridViewTextBoxColumn.HeaderText = "drug_strength";
            this.drugstrengthDataGridViewTextBoxColumn.Name = "drugstrengthDataGridViewTextBoxColumn";
            // 
            // pillphotoDataGridViewTextBoxColumn
            // 
            this.pillphotoDataGridViewTextBoxColumn.DataPropertyName = "pill_photo";
            this.pillphotoDataGridViewTextBoxColumn.HeaderText = "pill_photo";
            this.pillphotoDataGridViewTextBoxColumn.Name = "pillphotoDataGridViewTextBoxColumn";
            // 
            // creationdateDataGridViewTextBoxColumn
            // 
            this.creationdateDataGridViewTextBoxColumn.DataPropertyName = "creation_date";
            this.creationdateDataGridViewTextBoxColumn.HeaderText = "creation_date";
            this.creationdateDataGridViewTextBoxColumn.Name = "creationdateDataGridViewTextBoxColumn";
            // 
            // pharmaDataSetBindingSource
            // 
            this.pharmaDataSetBindingSource.DataSource = this.pharmaDataSet;
            this.pharmaDataSetBindingSource.Position = 0;
            // 
            // pharmaDataSet
            // 
            this.pharmaDataSet.DataSetName = "pharmaDataSet";
            this.pharmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(771, 431);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportForm";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pharmaDataSetBindingSource;
        private pharmaDataSet pharmaDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn pillimprintDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pillcolorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pillshapeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugstrengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pillphotoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationdateDataGridViewTextBoxColumn;
    }
}