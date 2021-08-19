namespace WindowsFormsApp1
{
    partial class FormR
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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.курсоваяАэропорты_и_расписание_рейсов1SQLDataSet = new WindowsFormsApp1.КурсоваяАэропорты_и_расписание_рейсов1SQLDataSet();
            this.рейсыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.рейсыTableAdapter = new WindowsFormsApp1.КурсоваяАэропорты_и_расписание_рейсов1SQLDataSetTableAdapters.РейсыTableAdapter();
            this.кодРейсаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерРейсаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.колвоМестDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.забронировано1КлассDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.забронировано2КлассDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.забронировано3КлассDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.цена1КлассDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.цена2КлассDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.цена3КлассDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.курсоваяАэропорты_и_расписание_рейсов1SQLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рейсыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодРейсаDataGridViewTextBoxColumn,
            this.номерРейсаDataGridViewTextBoxColumn,
            this.колвоМестDataGridViewTextBoxColumn,
            this.забронировано1КлассDataGridViewTextBoxColumn,
            this.забронировано2КлассDataGridViewTextBoxColumn,
            this.забронировано3КлассDataGridViewTextBoxColumn,
            this.цена1КлассDataGridViewTextBoxColumn,
            this.цена2КлассDataGridViewTextBoxColumn,
            this.цена3КлассDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.рейсыBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(955, 327);
            this.dataGridView3.TabIndex = 5;
            // 
            // курсоваяАэропорты_и_расписание_рейсов1SQLDataSet
            // 
            this.курсоваяАэропорты_и_расписание_рейсов1SQLDataSet.DataSetName = "КурсоваяАэропорты_и_расписание_рейсов1SQLDataSet";
            this.курсоваяАэропорты_и_расписание_рейсов1SQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // рейсыBindingSource
            // 
            this.рейсыBindingSource.DataMember = "Рейсы";
            this.рейсыBindingSource.DataSource = this.курсоваяАэропорты_и_расписание_рейсов1SQLDataSet;
            // 
            // рейсыTableAdapter
            // 
            this.рейсыTableAdapter.ClearBeforeFill = true;
            // 
            // кодРейсаDataGridViewTextBoxColumn
            // 
            this.кодРейсаDataGridViewTextBoxColumn.DataPropertyName = "Код рейса";
            this.кодРейсаDataGridViewTextBoxColumn.HeaderText = "Код рейса";
            this.кодРейсаDataGridViewTextBoxColumn.Name = "кодРейсаDataGridViewTextBoxColumn";
            this.кодРейсаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // номерРейсаDataGridViewTextBoxColumn
            // 
            this.номерРейсаDataGridViewTextBoxColumn.DataPropertyName = "Номер рейса";
            this.номерРейсаDataGridViewTextBoxColumn.HeaderText = "Номер рейса";
            this.номерРейсаDataGridViewTextBoxColumn.Name = "номерРейсаDataGridViewTextBoxColumn";
            // 
            // колвоМестDataGridViewTextBoxColumn
            // 
            this.колвоМестDataGridViewTextBoxColumn.DataPropertyName = "Кол-во мест";
            this.колвоМестDataGridViewTextBoxColumn.HeaderText = "Кол-во мест";
            this.колвоМестDataGridViewTextBoxColumn.Name = "колвоМестDataGridViewTextBoxColumn";
            // 
            // забронировано1КлассDataGridViewTextBoxColumn
            // 
            this.забронировано1КлассDataGridViewTextBoxColumn.DataPropertyName = "Забронировано 1 класс";
            this.забронировано1КлассDataGridViewTextBoxColumn.HeaderText = "Забронировано 1 класс";
            this.забронировано1КлассDataGridViewTextBoxColumn.Name = "забронировано1КлассDataGridViewTextBoxColumn";
            // 
            // забронировано2КлассDataGridViewTextBoxColumn
            // 
            this.забронировано2КлассDataGridViewTextBoxColumn.DataPropertyName = "Забронировано 2 класс";
            this.забронировано2КлассDataGridViewTextBoxColumn.HeaderText = "Забронировано 2 класс";
            this.забронировано2КлассDataGridViewTextBoxColumn.Name = "забронировано2КлассDataGridViewTextBoxColumn";
            // 
            // забронировано3КлассDataGridViewTextBoxColumn
            // 
            this.забронировано3КлассDataGridViewTextBoxColumn.DataPropertyName = "Забронировано 3 класс";
            this.забронировано3КлассDataGridViewTextBoxColumn.HeaderText = "Забронировано 3 класс";
            this.забронировано3КлассDataGridViewTextBoxColumn.Name = "забронировано3КлассDataGridViewTextBoxColumn";
            // 
            // цена1КлассDataGridViewTextBoxColumn
            // 
            this.цена1КлассDataGridViewTextBoxColumn.DataPropertyName = "Цена 1 класс";
            this.цена1КлассDataGridViewTextBoxColumn.HeaderText = "Цена 1 класс";
            this.цена1КлассDataGridViewTextBoxColumn.Name = "цена1КлассDataGridViewTextBoxColumn";
            // 
            // цена2КлассDataGridViewTextBoxColumn
            // 
            this.цена2КлассDataGridViewTextBoxColumn.DataPropertyName = "Цена 2 класс";
            this.цена2КлассDataGridViewTextBoxColumn.HeaderText = "Цена 2 класс";
            this.цена2КлассDataGridViewTextBoxColumn.Name = "цена2КлассDataGridViewTextBoxColumn";
            // 
            // цена3КлассDataGridViewTextBoxColumn
            // 
            this.цена3КлассDataGridViewTextBoxColumn.DataPropertyName = "Цена 3 класс";
            this.цена3КлассDataGridViewTextBoxColumn.HeaderText = "Цена 3 класс";
            this.цена3КлассDataGridViewTextBoxColumn.Name = "цена3КлассDataGridViewTextBoxColumn";
            // 
            // FormR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 327);
            this.Controls.Add(this.dataGridView3);
            this.Name = "FormR";
            this.Text = "FormR";
            this.Load += new System.EventHandler(this.FormR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.курсоваяАэропорты_и_расписание_рейсов1SQLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рейсыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView3;
        private КурсоваяАэропорты_и_расписание_рейсов1SQLDataSet курсоваяАэропорты_и_расписание_рейсов1SQLDataSet;
        private System.Windows.Forms.BindingSource рейсыBindingSource;
        private КурсоваяАэропорты_и_расписание_рейсов1SQLDataSetTableAdapters.РейсыTableAdapter рейсыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодРейсаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерРейсаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn колвоМестDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn забронировано1КлассDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn забронировано2КлассDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn забронировано3КлассDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn цена1КлассDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn цена2КлассDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn цена3КлассDataGridViewTextBoxColumn;
    }
}