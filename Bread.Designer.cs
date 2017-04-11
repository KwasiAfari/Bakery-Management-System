namespace Bakery_Management_System
{
    partial class Bread
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.breadTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breadSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bakery = new Bakery_Management_System.bakery();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.Quantitytxt = new System.Windows.Forms.TextBox();
            this.btninsert = new System.Windows.Forms.Button();
            this.breadTableAdapter = new Bakery_Management_System.bakeryTableAdapters.BreadTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.breadBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bttxt = new System.Windows.Forms.TextBox();
            this.cbbs = new System.Windows.Forms.ComboBox();
            this.breadBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cbp = new System.Windows.Forms.ComboBox();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breadBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breadBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.breadTypeDataGridViewTextBoxColumn,
            this.breadSizeDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.Price});
            this.dataGridView1.DataSource = this.breadBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(408, 78);
            this.dataGridView1.TabIndex = 0;
            // 
            // breadTypeDataGridViewTextBoxColumn
            // 
            this.breadTypeDataGridViewTextBoxColumn.DataPropertyName = "BreadType";
            this.breadTypeDataGridViewTextBoxColumn.HeaderText = "BreadType";
            this.breadTypeDataGridViewTextBoxColumn.Name = "breadTypeDataGridViewTextBoxColumn";
            // 
            // breadSizeDataGridViewTextBoxColumn
            // 
            this.breadSizeDataGridViewTextBoxColumn.DataPropertyName = "BreadSize";
            this.breadSizeDataGridViewTextBoxColumn.HeaderText = "BreadSize";
            this.breadSizeDataGridViewTextBoxColumn.Name = "breadSizeDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // breadBindingSource
            // 
            this.breadBindingSource.DataMember = "Bread";
            this.breadBindingSource.DataSource = this.bakery;
            // 
            // bakery
            // 
            this.bakery.DataSetName = "bakery";
            this.bakery.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bread Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bread Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantity";
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(104, 279);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(107, 21);
            this.btnupdate.TabIndex = 4;
            this.btnupdate.Text = "Update Products ";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // Quantitytxt
            // 
            this.Quantitytxt.Location = new System.Drawing.Point(111, 183);
            this.Quantitytxt.Name = "Quantitytxt";
            this.Quantitytxt.Size = new System.Drawing.Size(197, 20);
            this.Quantitytxt.TabIndex = 7;
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(227, 279);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(107, 21);
            this.btninsert.TabIndex = 8;
            this.btninsert.Text = "Insert Products";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // breadTableAdapter
            // 
            this.breadTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Price";
            // 
            // breadBindingSource1
            // 
            this.breadBindingSource1.DataMember = "Bread";
            this.breadBindingSource1.DataSource = this.bakery;
            // 
            // bttxt
            // 
            this.bttxt.Location = new System.Drawing.Point(111, 119);
            this.bttxt.Name = "bttxt";
            this.bttxt.Size = new System.Drawing.Size(197, 20);
            this.bttxt.TabIndex = 11;
            // 
            // cbbs
            // 
            this.cbbs.DataSource = this.breadBindingSource2;
            this.cbbs.DisplayMember = "BreadSize";
            this.cbbs.FormattingEnabled = true;
            this.cbbs.Location = new System.Drawing.Point(111, 152);
            this.cbbs.Name = "cbbs";
            this.cbbs.Size = new System.Drawing.Size(197, 21);
            this.cbbs.TabIndex = 12;
            // 
            // breadBindingSource2
            // 
            this.breadBindingSource2.DataMember = "Bread";
            this.breadBindingSource2.DataSource = this.bakery;
            // 
            // cbp
            // 
            this.cbp.DataSource = this.breadBindingSource2;
            this.cbp.DisplayMember = "Price";
            this.cbp.FormattingEnabled = true;
            this.cbp.Location = new System.Drawing.Point(111, 212);
            this.cbp.Name = "cbp";
            this.cbp.Size = new System.Drawing.Size(148, 21);
            this.cbp.TabIndex = 13;
            this.cbp.ValueMember = "BreadSize";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Bread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 325);
            this.Controls.Add(this.cbp);
            this.Controls.Add(this.cbbs);
            this.Controls.Add(this.bttxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.Quantitytxt);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Bread";
            this.Text = "Bread";
            this.Load += new System.EventHandler(this.Bread_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breadBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breadBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox Quantitytxt;
        private System.Windows.Forms.Button btninsert;
        private bakery bakery;
        private System.Windows.Forms.BindingSource breadBindingSource;
        private bakeryTableAdapters.BreadTableAdapter breadTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn breadTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn breadSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource breadBindingSource1;
        private System.Windows.Forms.TextBox bttxt;
        private System.Windows.Forms.ComboBox cbbs;
        private System.Windows.Forms.BindingSource breadBindingSource2;
        private System.Windows.Forms.ComboBox cbp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}