namespace WindowsFormsApp1
{
    partial class FormAero
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.курсоваяАэропорты_и_расписание_рейсов1SQLDataSet = new WindowsFormsApp1.КурсоваяАэропорты_и_расписание_рейсов1SQLDataSet();
            this.аэропортыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.аэропортыTableAdapter = new WindowsFormsApp1.КурсоваяАэропорты_и_расписание_рейсов1SQLDataSetTableAdapters.АэропортыTableAdapter();
            this.кодАэропортаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеАэропортаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресАэропортаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонАэропортаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОНачальникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.курсоваяАэропорты_и_расписание_рейсов1SQLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.аэропортыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодАэропортаDataGridViewTextBoxColumn,
            this.названиеАэропортаDataGridViewTextBoxColumn,
            this.адресАэропортаDataGridViewTextBoxColumn,
            this.телефонАэропортаDataGridViewTextBoxColumn,
            this.фИОНачальникаDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.аэропортыBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(546, 307);
            this.dataGridView2.TabIndex = 3;
            // 
            // курсоваяАэропорты_и_расписание_рейсов1SQLDataSet
            // 
            this.курсоваяАэропорты_и_расписание_рейсов1SQLDataSet.DataSetName = "КурсоваяАэропорты_и_расписание_рейсов1SQLDataSet";
            this.курсоваяАэропорты_и_расписание_рейсов1SQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // аэропортыBindingSource
            // 
            this.аэропортыBindingSource.DataMember = "Аэропорты";
            this.аэропортыBindingSource.DataSource = this.курсоваяАэропорты_и_расписание_рейсов1SQLDataSet;
            // 
            // аэропортыTableAdapter
            // 
            this.аэропортыTableAdapter.ClearBeforeFill = true;
            // 
            // кодАэропортаDataGridViewTextBoxColumn
            // 
            this.кодАэропортаDataGridViewTextBoxColumn.DataPropertyName = "Код аэропорта";
            this.кодАэропортаDataGridViewTextBoxColumn.HeaderText = "Код аэропорта";
            this.кодАэропортаDataGridViewTextBoxColumn.Name = "кодАэропортаDataGridViewTextBoxColumn";
            this.кодАэропортаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиеАэропортаDataGridViewTextBoxColumn
            // 
            this.названиеАэропортаDataGridViewTextBoxColumn.DataPropertyName = "Название аэропорта";
            this.названиеАэропортаDataGridViewTextBoxColumn.HeaderText = "Название аэропорта";
            this.названиеАэропортаDataGridViewTextBoxColumn.Name = "названиеАэропортаDataGridViewTextBoxColumn";
            // 
            // адресАэропортаDataGridViewTextBoxColumn
            // 
            this.адресАэропортаDataGridViewTextBoxColumn.DataPropertyName = "Адрес аэропорта";
            this.адресАэропортаDataGridViewTextBoxColumn.HeaderText = "Адрес аэропорта";
            this.адресАэропортаDataGridViewTextBoxColumn.Name = "адресАэропортаDataGridViewTextBoxColumn";
            // 
            // телефонАэропортаDataGridViewTextBoxColumn
            // 
            this.телефонАэропортаDataGridViewTextBoxColumn.DataPropertyName = "Телефон аэропорта";
            this.телефонАэропортаDataGridViewTextBoxColumn.HeaderText = "Телефон аэропорта";
            this.телефонАэропортаDataGridViewTextBoxColumn.Name = "телефонАэропортаDataGridViewTextBoxColumn";
            // 
            // фИОНачальникаDataGridViewTextBoxColumn
            // 
            this.фИОНачальникаDataGridViewTextBoxColumn.DataPropertyName = "ФИО начальника";
            this.фИОНачальникаDataGridViewTextBoxColumn.HeaderText = "ФИО начальника";
            this.фИОНачальникаDataGridViewTextBoxColumn.Name = "фИОНачальникаDataGridViewTextBoxColumn";
            // 
            // FormAero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 307);
            this.Controls.Add(this.dataGridView2);
            this.Name = "FormAero";
            this.Text = "FormAero";
            this.Load += new System.EventHandler(this.FormAero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.курсоваяАэропорты_и_расписание_рейсов1SQLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аэропортыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private КурсоваяАэропорты_и_расписание_рейсов1SQLDataSet курсоваяАэропорты_и_расписание_рейсов1SQLDataSet;
        private System.Windows.Forms.BindingSource аэропортыBindingSource;
        private КурсоваяАэропорты_и_расписание_рейсов1SQLDataSetTableAdapters.АэропортыTableAdapter аэропортыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодАэропортаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеАэропортаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресАэропортаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонАэропортаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОНачальникаDataGridViewTextBoxColumn;
    }
}