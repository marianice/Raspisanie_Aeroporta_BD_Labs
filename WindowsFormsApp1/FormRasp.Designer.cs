namespace WindowsFormsApp1
{
    partial class FormRasp
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
            this.расписаниеРейсовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.расписание_рейсовTableAdapter = new WindowsFormsApp1.КурсоваяАэропорты_и_расписание_рейсов1SQLDataSetTableAdapters.Расписание_рейсовTableAdapter();
            this.номерРейсаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодАвиакомпанииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСамолетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодНачальногоАэропортаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодКонечногоАэропортаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяОтправленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяПрибытияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.курсоваяАэропорты_и_расписание_рейсов1SQLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.расписаниеРейсовBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерРейсаDataGridViewTextBoxColumn,
            this.кодАвиакомпанииDataGridViewTextBoxColumn,
            this.кодСамолетаDataGridViewTextBoxColumn,
            this.кодНачальногоАэропортаDataGridViewTextBoxColumn,
            this.кодКонечногоАэропортаDataGridViewTextBoxColumn,
            this.времяОтправленияDataGridViewTextBoxColumn,
            this.времяПрибытияDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.расписаниеРейсовBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(761, 317);
            this.dataGridView3.TabIndex = 4;
            // 
            // курсоваяАэропорты_и_расписание_рейсов1SQLDataSet
            // 
            this.курсоваяАэропорты_и_расписание_рейсов1SQLDataSet.DataSetName = "КурсоваяАэропорты_и_расписание_рейсов1SQLDataSet";
            this.курсоваяАэропорты_и_расписание_рейсов1SQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // расписаниеРейсовBindingSource
            // 
            this.расписаниеРейсовBindingSource.DataMember = "Расписание рейсов";
            this.расписаниеРейсовBindingSource.DataSource = this.курсоваяАэропорты_и_расписание_рейсов1SQLDataSet;
            // 
            // расписание_рейсовTableAdapter
            // 
            this.расписание_рейсовTableAdapter.ClearBeforeFill = true;
            // 
            // номерРейсаDataGridViewTextBoxColumn
            // 
            this.номерРейсаDataGridViewTextBoxColumn.DataPropertyName = "Номер рейса";
            this.номерРейсаDataGridViewTextBoxColumn.HeaderText = "Номер рейса";
            this.номерРейсаDataGridViewTextBoxColumn.Name = "номерРейсаDataGridViewTextBoxColumn";
            this.номерРейсаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодАвиакомпанииDataGridViewTextBoxColumn
            // 
            this.кодАвиакомпанииDataGridViewTextBoxColumn.DataPropertyName = "Код авиакомпании";
            this.кодАвиакомпанииDataGridViewTextBoxColumn.HeaderText = "Код авиакомпании";
            this.кодАвиакомпанииDataGridViewTextBoxColumn.Name = "кодАвиакомпанииDataGridViewTextBoxColumn";
            // 
            // кодСамолетаDataGridViewTextBoxColumn
            // 
            this.кодСамолетаDataGridViewTextBoxColumn.DataPropertyName = "Код самолета";
            this.кодСамолетаDataGridViewTextBoxColumn.HeaderText = "Код самолета";
            this.кодСамолетаDataGridViewTextBoxColumn.Name = "кодСамолетаDataGridViewTextBoxColumn";
            // 
            // кодНачальногоАэропортаDataGridViewTextBoxColumn
            // 
            this.кодНачальногоАэропортаDataGridViewTextBoxColumn.DataPropertyName = "Код начального аэропорта";
            this.кодНачальногоАэропортаDataGridViewTextBoxColumn.HeaderText = "Код начального аэропорта";
            this.кодНачальногоАэропортаDataGridViewTextBoxColumn.Name = "кодНачальногоАэропортаDataGridViewTextBoxColumn";
            // 
            // кодКонечногоАэропортаDataGridViewTextBoxColumn
            // 
            this.кодКонечногоАэропортаDataGridViewTextBoxColumn.DataPropertyName = "Код конечного аэропорта";
            this.кодКонечногоАэропортаDataGridViewTextBoxColumn.HeaderText = "Код конечного аэропорта";
            this.кодКонечногоАэропортаDataGridViewTextBoxColumn.Name = "кодКонечногоАэропортаDataGridViewTextBoxColumn";
            // 
            // времяОтправленияDataGridViewTextBoxColumn
            // 
            this.времяОтправленияDataGridViewTextBoxColumn.DataPropertyName = "Время отправления";
            this.времяОтправленияDataGridViewTextBoxColumn.HeaderText = "Время отправления";
            this.времяОтправленияDataGridViewTextBoxColumn.Name = "времяОтправленияDataGridViewTextBoxColumn";
            // 
            // времяПрибытияDataGridViewTextBoxColumn
            // 
            this.времяПрибытияDataGridViewTextBoxColumn.DataPropertyName = "Время прибытия";
            this.времяПрибытияDataGridViewTextBoxColumn.HeaderText = "Время прибытия";
            this.времяПрибытияDataGridViewTextBoxColumn.Name = "времяПрибытияDataGridViewTextBoxColumn";
            // 
            // FormRasp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 317);
            this.Controls.Add(this.dataGridView3);
            this.Name = "FormRasp";
            this.Text = "FormRasp";
            this.Load += new System.EventHandler(this.FormRasp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.курсоваяАэропорты_и_расписание_рейсов1SQLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.расписаниеРейсовBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView3;
        private КурсоваяАэропорты_и_расписание_рейсов1SQLDataSet курсоваяАэропорты_и_расписание_рейсов1SQLDataSet;
        private System.Windows.Forms.BindingSource расписаниеРейсовBindingSource;
        private КурсоваяАэропорты_и_расписание_рейсов1SQLDataSetTableAdapters.Расписание_рейсовTableAdapter расписание_рейсовTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерРейсаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодАвиакомпанииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСамолетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодНачальногоАэропортаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКонечногоАэропортаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяОтправленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяПрибытияDataGridViewTextBoxColumn;
    }
}