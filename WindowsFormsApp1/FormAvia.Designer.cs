namespace WindowsFormsApp1
{
    partial class FormAvia
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
            this.курсоваяАэропорты_и_расписание_рейсов1SQLDataSet = new WindowsFormsApp1.КурсоваяАэропорты_и_расписание_рейсов1SQLDataSet();
            this.авиакомпанииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.авиакомпанииTableAdapter = new WindowsFormsApp1.КурсоваяАэропорты_и_расписание_рейсов1SQLDataSetTableAdapters.АвиакомпанииTableAdapter();
            this.кодАвиакомпанииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеАвиакомпанииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.странаАвиакомпанииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.курсоваяАэропорты_и_расписание_рейсов1SQLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.авиакомпанииBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодАвиакомпанииDataGridViewTextBoxColumn,
            this.названиеАвиакомпанииDataGridViewTextBoxColumn,
            this.странаАвиакомпанииDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.авиакомпанииBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(349, 327);
            this.dataGridView1.TabIndex = 2;
            // 
            // курсоваяАэропорты_и_расписание_рейсов1SQLDataSet
            // 
            this.курсоваяАэропорты_и_расписание_рейсов1SQLDataSet.DataSetName = "КурсоваяАэропорты_и_расписание_рейсов1SQLDataSet";
            this.курсоваяАэропорты_и_расписание_рейсов1SQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // авиакомпанииBindingSource
            // 
            this.авиакомпанииBindingSource.DataMember = "Авиакомпании";
            this.авиакомпанииBindingSource.DataSource = this.курсоваяАэропорты_и_расписание_рейсов1SQLDataSet;
            // 
            // авиакомпанииTableAdapter
            // 
            this.авиакомпанииTableAdapter.ClearBeforeFill = true;
            // 
            // кодАвиакомпанииDataGridViewTextBoxColumn
            // 
            this.кодАвиакомпанииDataGridViewTextBoxColumn.DataPropertyName = "Код авиакомпании";
            this.кодАвиакомпанииDataGridViewTextBoxColumn.HeaderText = "Код авиакомпании";
            this.кодАвиакомпанииDataGridViewTextBoxColumn.Name = "кодАвиакомпанииDataGridViewTextBoxColumn";
            this.кодАвиакомпанииDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиеАвиакомпанииDataGridViewTextBoxColumn
            // 
            this.названиеАвиакомпанииDataGridViewTextBoxColumn.DataPropertyName = "Название авиакомпании";
            this.названиеАвиакомпанииDataGridViewTextBoxColumn.HeaderText = "Название авиакомпании";
            this.названиеАвиакомпанииDataGridViewTextBoxColumn.Name = "названиеАвиакомпанииDataGridViewTextBoxColumn";
            // 
            // странаАвиакомпанииDataGridViewTextBoxColumn
            // 
            this.странаАвиакомпанииDataGridViewTextBoxColumn.DataPropertyName = "Страна авиакомпании";
            this.странаАвиакомпанииDataGridViewTextBoxColumn.HeaderText = "Страна авиакомпании";
            this.странаАвиакомпанииDataGridViewTextBoxColumn.Name = "странаАвиакомпанииDataGridViewTextBoxColumn";
            // 
            // FormAvia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 327);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormAvia";
            this.Text = "FormAvia";
            this.Load += new System.EventHandler(this.FormAvia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.курсоваяАэропорты_и_расписание_рейсов1SQLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.авиакомпанииBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private КурсоваяАэропорты_и_расписание_рейсов1SQLDataSet курсоваяАэропорты_и_расписание_рейсов1SQLDataSet;
        private System.Windows.Forms.BindingSource авиакомпанииBindingSource;
        private КурсоваяАэропорты_и_расписание_рейсов1SQLDataSetTableAdapters.АвиакомпанииTableAdapter авиакомпанииTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодАвиакомпанииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеАвиакомпанииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn странаАвиакомпанииDataGridViewTextBoxColumn;
    }
}