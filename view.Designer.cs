namespace newlibrary1
{
    partial class view
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
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.newlibraryDataSet = new newlibrary1.newlibraryDataSet();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminTableAdapter = new newlibrary1.newlibraryDataSetTableAdapters.AdminTableAdapter();
            this.librarySystemDataSet = new newlibrary1.LibrarySystemDataSet();
            this.librarySystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentTableAdapter = new newlibrary1.LibrarySystemDataSetTableAdapters.DocumentTableAdapter();
            this.documentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.documentTableAdapter1 = new newlibrary1.newlibraryDataSetTableAdapters.DocumentTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.librarySystemDataSet1 = new newlibrary1.LibrarySystemDataSet1();
            this.documentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.documentTableAdapter2 = new newlibrary1.LibrarySystemDataSet1TableAdapters.DocumentTableAdapter();
            this.tittleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishyearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.newlibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarySystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarySystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarySystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(351, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 31);
            this.label6.TabIndex = 18;
            this.label6.Text = "view information";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(766, 237);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "view";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // newlibraryDataSet
            // 
            this.newlibraryDataSet.DataSetName = "newlibraryDataSet";
            this.newlibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "Admin";
            this.adminBindingSource.DataSource = this.newlibraryDataSet;
            // 
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
            // 
            // librarySystemDataSet
            // 
            this.librarySystemDataSet.DataSetName = "LibrarySystemDataSet";
            this.librarySystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // librarySystemDataSetBindingSource
            // 
            this.librarySystemDataSetBindingSource.DataSource = this.librarySystemDataSet;
            this.librarySystemDataSetBindingSource.Position = 0;
            // 
            // documentBindingSource
            // 
            this.documentBindingSource.DataMember = "Document";
            this.documentBindingSource.DataSource = this.librarySystemDataSetBindingSource;
            // 
            // documentTableAdapter
            // 
            this.documentTableAdapter.ClearBeforeFill = true;
            // 
            // documentBindingSource1
            // 
            this.documentBindingSource1.DataMember = "Document";
            this.documentBindingSource1.DataSource = this.newlibraryDataSet;
            // 
            // documentTableAdapter1
            // 
            this.documentTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tittleDataGridViewTextBoxColumn,
            this.bookidDataGridViewTextBoxColumn,
            this.sSNDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.authornameDataGridViewTextBoxColumn,
            this.publishyearDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.documentBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(116, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 150);
            this.dataGridView1.TabIndex = 24;
            // 
            // librarySystemDataSet1
            // 
            this.librarySystemDataSet1.DataSetName = "LibrarySystemDataSet1";
            this.librarySystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // documentBindingSource2
            // 
            this.documentBindingSource2.DataMember = "Document";
            this.documentBindingSource2.DataSource = this.librarySystemDataSet1;
            // 
            // documentTableAdapter2
            // 
            this.documentTableAdapter2.ClearBeforeFill = true;
            // 
            // tittleDataGridViewTextBoxColumn
            // 
            this.tittleDataGridViewTextBoxColumn.DataPropertyName = "tittle";
            this.tittleDataGridViewTextBoxColumn.HeaderText = "tittle";
            this.tittleDataGridViewTextBoxColumn.Name = "tittleDataGridViewTextBoxColumn";
            // 
            // bookidDataGridViewTextBoxColumn
            // 
            this.bookidDataGridViewTextBoxColumn.DataPropertyName = "book-id";
            this.bookidDataGridViewTextBoxColumn.HeaderText = "book-id";
            this.bookidDataGridViewTextBoxColumn.Name = "bookidDataGridViewTextBoxColumn";
            // 
            // sSNDataGridViewTextBoxColumn
            // 
            this.sSNDataGridViewTextBoxColumn.DataPropertyName = "SSN";
            this.sSNDataGridViewTextBoxColumn.HeaderText = "SSN";
            this.sSNDataGridViewTextBoxColumn.Name = "sSNDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // authornameDataGridViewTextBoxColumn
            // 
            this.authornameDataGridViewTextBoxColumn.DataPropertyName = "author-name";
            this.authornameDataGridViewTextBoxColumn.HeaderText = "author-name";
            this.authornameDataGridViewTextBoxColumn.Name = "authornameDataGridViewTextBoxColumn";
            // 
            // publishyearDataGridViewTextBoxColumn
            // 
            this.publishyearDataGridViewTextBoxColumn.DataPropertyName = "publish-year";
            this.publishyearDataGridViewTextBoxColumn.HeaderText = "publish-year";
            this.publishyearDataGridViewTextBoxColumn.Name = "publishyearDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "enter book tittle";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 45;
            this.button1.Text = "Buy";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 330);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 20);
            this.textBox1.TabIndex = 47;
            // 
            // view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.Name = "view";
            this.Text = "view";
            this.Load += new System.EventHandler(this.view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newlibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarySystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarySystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarySystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private newlibraryDataSet newlibraryDataSet;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private newlibraryDataSetTableAdapters.AdminTableAdapter adminTableAdapter;
        private System.Windows.Forms.BindingSource librarySystemDataSetBindingSource;
        private LibrarySystemDataSet librarySystemDataSet;
        private System.Windows.Forms.BindingSource documentBindingSource;
        private LibrarySystemDataSetTableAdapters.DocumentTableAdapter documentTableAdapter;
        private System.Windows.Forms.BindingSource documentBindingSource1;
        private newlibraryDataSetTableAdapters.DocumentTableAdapter documentTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LibrarySystemDataSet1 librarySystemDataSet1;
        private System.Windows.Forms.BindingSource documentBindingSource2;
        private LibrarySystemDataSet1TableAdapters.DocumentTableAdapter documentTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tittleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishyearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}