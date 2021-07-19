namespace Pill_Identifier
{
    partial class Pill_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pill_Form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyPillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pillIdentifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pillReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpContentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pillimprintDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pillcolorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pillshapeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drugnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drugstrengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pillphotoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pillsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmaDataSet = new Pill_Identifier.pharmaDataSet();
            this.pillsTableAdapter = new Pill_Identifier.pharmaDataSetTableAdapters.pillsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.imprint_txtbox = new System.Windows.Forms.TextBox();
            this.color_txtbox = new System.Windows.Forms.TextBox();
            this.shape_txtbox = new System.Windows.Forms.TextBox();
            this.drugName_txtbox = new System.Windows.Forms.TextBox();
            this.strength_txtbox = new System.Windows.Forms.TextBox();
            this.photo_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(780, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPillToolStripMenuItem,
            this.modifyPillToolStripMenuItem,
            this.pillIdentifierToolStripMenuItem,
            this.pillReportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addPillToolStripMenuItem
            // 
            this.addPillToolStripMenuItem.Name = "addPillToolStripMenuItem";
            this.addPillToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.addPillToolStripMenuItem.Text = "Add Pill";
            this.addPillToolStripMenuItem.Click += new System.EventHandler(this.addPillToolStripMenuItem_Click);
            // 
            // modifyPillToolStripMenuItem
            // 
            this.modifyPillToolStripMenuItem.Name = "modifyPillToolStripMenuItem";
            this.modifyPillToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.modifyPillToolStripMenuItem.Text = "Modify Pill";
            this.modifyPillToolStripMenuItem.Click += new System.EventHandler(this.modifyPillToolStripMenuItem_Click);
            // 
            // pillIdentifierToolStripMenuItem
            // 
            this.pillIdentifierToolStripMenuItem.Name = "pillIdentifierToolStripMenuItem";
            this.pillIdentifierToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.pillIdentifierToolStripMenuItem.Text = "Pill Identifier ";
            this.pillIdentifierToolStripMenuItem.Click += new System.EventHandler(this.pillIdentifierToolStripMenuItem_Click);
            // 
            // pillReportToolStripMenuItem
            // 
            this.pillReportToolStripMenuItem.Name = "pillReportToolStripMenuItem";
            this.pillReportToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.pillReportToolStripMenuItem.Text = "Pill Report";
            this.pillReportToolStripMenuItem.Click += new System.EventHandler(this.pillReportToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpContentsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.helpToolStripMenuItem.Text = "Help ";
            // 
            // helpContentsToolStripMenuItem
            // 
            this.helpContentsToolStripMenuItem.Name = "helpContentsToolStripMenuItem";
            this.helpContentsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.helpContentsToolStripMenuItem.Text = "Help Contents";
            this.helpContentsToolStripMenuItem.Click += new System.EventHandler(this.helpContentsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
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
            this.dataGridView1.DataSource = this.pillsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(745, 247);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pillimprintDataGridViewTextBoxColumn
            // 
            this.pillimprintDataGridViewTextBoxColumn.DataPropertyName = "pill_imprint";
            this.pillimprintDataGridViewTextBoxColumn.HeaderText = "pill_imprint";
            this.pillimprintDataGridViewTextBoxColumn.Name = "pillimprintDataGridViewTextBoxColumn";
            this.pillimprintDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pillcolorDataGridViewTextBoxColumn
            // 
            this.pillcolorDataGridViewTextBoxColumn.DataPropertyName = "pill_color";
            this.pillcolorDataGridViewTextBoxColumn.HeaderText = "pill_color";
            this.pillcolorDataGridViewTextBoxColumn.Name = "pillcolorDataGridViewTextBoxColumn";
            this.pillcolorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pillshapeDataGridViewTextBoxColumn
            // 
            this.pillshapeDataGridViewTextBoxColumn.DataPropertyName = "pill_shape";
            this.pillshapeDataGridViewTextBoxColumn.HeaderText = "pill_shape";
            this.pillshapeDataGridViewTextBoxColumn.Name = "pillshapeDataGridViewTextBoxColumn";
            this.pillshapeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // drugnameDataGridViewTextBoxColumn
            // 
            this.drugnameDataGridViewTextBoxColumn.DataPropertyName = "drug_name";
            this.drugnameDataGridViewTextBoxColumn.HeaderText = "drug_name";
            this.drugnameDataGridViewTextBoxColumn.Name = "drugnameDataGridViewTextBoxColumn";
            this.drugnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // drugstrengthDataGridViewTextBoxColumn
            // 
            this.drugstrengthDataGridViewTextBoxColumn.DataPropertyName = "drug_strength";
            this.drugstrengthDataGridViewTextBoxColumn.HeaderText = "drug_strength";
            this.drugstrengthDataGridViewTextBoxColumn.Name = "drugstrengthDataGridViewTextBoxColumn";
            this.drugstrengthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pillphotoDataGridViewTextBoxColumn
            // 
            this.pillphotoDataGridViewTextBoxColumn.DataPropertyName = "pill_photo";
            this.pillphotoDataGridViewTextBoxColumn.HeaderText = "pill_photo";
            this.pillphotoDataGridViewTextBoxColumn.Name = "pillphotoDataGridViewTextBoxColumn";
            this.pillphotoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // creationdateDataGridViewTextBoxColumn
            // 
            this.creationdateDataGridViewTextBoxColumn.DataPropertyName = "creation_date";
            this.creationdateDataGridViewTextBoxColumn.HeaderText = "creation_date";
            this.creationdateDataGridViewTextBoxColumn.Name = "creationdateDataGridViewTextBoxColumn";
            this.creationdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pillsBindingSource
            // 
            this.pillsBindingSource.DataMember = "pills";
            this.pillsBindingSource.DataSource = this.pharmaDataSet;
            // 
            // pharmaDataSet
            // 
            this.pharmaDataSet.DataSetName = "pharmaDataSet";
            this.pharmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pillsTableAdapter
            // 
            this.pillsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Imprint #:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Color:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Shape:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Drug Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Strength: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Photo:";
            // 
            // imprint_txtbox
            // 
            this.imprint_txtbox.Enabled = false;
            this.imprint_txtbox.Location = new System.Drawing.Point(78, 32);
            this.imprint_txtbox.Name = "imprint_txtbox";
            this.imprint_txtbox.Size = new System.Drawing.Size(121, 20);
            this.imprint_txtbox.TabIndex = 13;
            // 
            // color_txtbox
            // 
            this.color_txtbox.Enabled = false;
            this.color_txtbox.Location = new System.Drawing.Point(78, 69);
            this.color_txtbox.Name = "color_txtbox";
            this.color_txtbox.Size = new System.Drawing.Size(121, 20);
            this.color_txtbox.TabIndex = 14;
            // 
            // shape_txtbox
            // 
            this.shape_txtbox.Enabled = false;
            this.shape_txtbox.Location = new System.Drawing.Point(78, 105);
            this.shape_txtbox.Name = "shape_txtbox";
            this.shape_txtbox.Size = new System.Drawing.Size(121, 20);
            this.shape_txtbox.TabIndex = 15;
            // 
            // drugName_txtbox
            // 
            this.drugName_txtbox.Enabled = false;
            this.drugName_txtbox.Location = new System.Drawing.Point(95, 142);
            this.drugName_txtbox.Name = "drugName_txtbox";
            this.drugName_txtbox.Size = new System.Drawing.Size(121, 20);
            this.drugName_txtbox.TabIndex = 16;
            // 
            // strength_txtbox
            // 
            this.strength_txtbox.Enabled = false;
            this.strength_txtbox.Location = new System.Drawing.Point(95, 185);
            this.strength_txtbox.Name = "strength_txtbox";
            this.strength_txtbox.Size = new System.Drawing.Size(121, 20);
            this.strength_txtbox.TabIndex = 17;
            // 
            // photo_btn
            // 
            this.photo_btn.Enabled = false;
            this.photo_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.photo_btn.Location = new System.Drawing.Point(78, 222);
            this.photo_btn.Name = "photo_btn";
            this.photo_btn.Size = new System.Drawing.Size(82, 24);
            this.photo_btn.TabIndex = 18;
            this.photo_btn.Text = "select";
            this.photo_btn.UseVisualStyleBackColor = true;
            this.photo_btn.Click += new System.EventHandler(this.photo_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(403, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(274, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 40);
            this.button1.TabIndex = 20;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(274, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 37);
            this.button2.TabIndex = 21;
            this.button2.Text = "Check";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(274, 161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 40);
            this.button3.TabIndex = 22;
            this.button3.Text = "Modify";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(274, 85);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 37);
            this.button4.TabIndex = 23;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Pill_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(780, 531);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.photo_btn);
            this.Controls.Add(this.strength_txtbox);
            this.Controls.Add(this.drugName_txtbox);
            this.Controls.Add(this.shape_txtbox);
            this.Controls.Add(this.color_txtbox);
            this.Controls.Add(this.imprint_txtbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pill_Form";
            this.Text = "PharmaPedia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyPillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pillIdentifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pillReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpContentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private pharmaDataSet pharmaDataSet;
        private System.Windows.Forms.BindingSource pillsBindingSource;
        private pharmaDataSetTableAdapters.pillsTableAdapter pillsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pillimprintDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pillcolorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pillshapeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugstrengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pillphotoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox imprint_txtbox;
        private System.Windows.Forms.TextBox color_txtbox;
        private System.Windows.Forms.TextBox shape_txtbox;
        private System.Windows.Forms.TextBox drugName_txtbox;
        private System.Windows.Forms.TextBox strength_txtbox;
        private System.Windows.Forms.Button photo_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

