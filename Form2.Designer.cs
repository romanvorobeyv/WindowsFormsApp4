namespace WindowsFormsApp4
{
    partial class Form2
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
            this.___Furniture_inventory_DataSet = new WindowsFormsApp4.@__Furniture_inventory_DataSet();
            this.nameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameTableAdapter = new WindowsFormsApp4.@__Furniture_inventory_DataSetTableAdapters.NameTableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nventorynumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initialcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.furniturenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.___Furniture_inventory_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.nventorynumberDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.initialcostDataGridViewTextBoxColumn,
            this.furniturenameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nameBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(679, 127);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ___Furniture_inventory_DataSet
            // 
            this.___Furniture_inventory_DataSet.DataSetName = "__Furniture_inventory_DataSet";
            this.___Furniture_inventory_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nameBindingSource
            // 
            this.nameBindingSource.DataMember = "Name";
            this.nameBindingSource.DataSource = this.___Furniture_inventory_DataSet;
            // 
            // nameTableAdapter
            // 
            this.nameTableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // nventorynumberDataGridViewTextBoxColumn
            // 
            this.nventorynumberDataGridViewTextBoxColumn.DataPropertyName = "nventory_number";
            this.nventorynumberDataGridViewTextBoxColumn.HeaderText = "nventory_number";
            this.nventorynumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nventorynumberDataGridViewTextBoxColumn.Name = "nventorynumberDataGridViewTextBoxColumn";
            this.nventorynumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // initialcostDataGridViewTextBoxColumn
            // 
            this.initialcostDataGridViewTextBoxColumn.DataPropertyName = "initial_cost";
            this.initialcostDataGridViewTextBoxColumn.HeaderText = "initial_cost";
            this.initialcostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.initialcostDataGridViewTextBoxColumn.Name = "initialcostDataGridViewTextBoxColumn";
            this.initialcostDataGridViewTextBoxColumn.Width = 125;
            // 
            // furniturenameDataGridViewTextBoxColumn
            // 
            this.furniturenameDataGridViewTextBoxColumn.DataPropertyName = "furniture_name";
            this.furniturenameDataGridViewTextBoxColumn.HeaderText = "furniture_name";
            this.furniturenameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.furniturenameDataGridViewTextBoxColumn.Name = "furniturenameDataGridViewTextBoxColumn";
            this.furniturenameDataGridViewTextBoxColumn.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Провести";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(137, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Печать ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(247, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "УдОлить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(353, 237);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "ВыхоДД";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 281);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.___Furniture_inventory_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private __Furniture_inventory_DataSet ___Furniture_inventory_DataSet;
        private System.Windows.Forms.BindingSource nameBindingSource;
        private __Furniture_inventory_DataSetTableAdapters.NameTableAdapter nameTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nventorynumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn initialcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn furniturenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}