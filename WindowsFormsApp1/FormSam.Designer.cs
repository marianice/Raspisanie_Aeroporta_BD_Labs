namespace WindowsFormsApp1
{
    partial class FormSam
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
            this.самолетыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.самолетыTableAdapter = new WindowsFormsApp1.КурсоваяАэропорты_и_расписание_рейсов1SQLDataSetTableAdapters.СамолетыTableAdapter();
            this.кодСамолетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеСамолетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вместимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.курсоваяАэропорты_и_расписание_рейсов1SQLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.самолетыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодСамолетаDataGridViewTextBoxColumn,
            this.названиеСамолетаDataGridViewTextBoxColumn,
            this.вместимостьDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.самолетыBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(346, 310);
            this.dataGridView3.TabIndex = 6;
            // 
            // курсоваяАэропорты_и_расписание_рейсов1SQLDataSet
            // 
            this.курсоваяАэропорты_и_расписание_рейсов1SQLDataSet.DataSetName = "КурсоваяАэропорты_и_расписание_рейсов1SQLDataSet";
            this.курсоваяАэропорты_и_расписание_рейсов1SQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // самолетыBindingSource
            // 
            this.самолетыBindingSource.DataMember = "Самолеты";
            this.самолетыBindingSource.DataSource = this.курсоваяАэропорты_и_расписание_рейсов1SQLDataSet;
            // 
            // самолетыTableAdapter
            // 
            this.самолетыTableAdapter.ClearBeforeFill = true;
            // 
            // кодСамолетаDataGridViewTextBoxColumn
            // 
            this.кодСамолетаDataGridViewTextBoxColumn.DataPropertyName = "Код самолета";
            this.кодСамолетаDataGridViewTextBoxColumn.HeaderText = "Код самолета";
            this.кодСамолетаDataGridViewTextBoxColumn.Name = "кодСамолетаDataGridViewTextBoxColumn";
            this.кодСамолетаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиеСамолетаDataGridViewTextBoxColumn
            // 
            this.названиеСамолетаDataGridViewTextBoxColumn.DataPropertyName = "Название самолета";
            this.названиеСамолетаDataGridViewTextBoxColumn.HeaderText = "Название самолета";
            this.названиеСамолетаDataGridViewTextBoxColumn.Name = "названиеСамолетаDataGridViewTextBoxColumn";
            // 
            // вместимостьDataGridViewTextBoxColumn
            // 
            this.вместимостьDataGridViewTextBoxColumn.DataPropertyName = "Вместимость";
            this.вместимостьDataGridViewTextBoxColumn.HeaderText = "Вместимость";
            this.вместимостьDataGridViewTextBoxColumn.Name = "вместимостьDataGridViewTextBoxColumn";
            // 
            // FormSam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 310);
            this.Controls.Add(this.dataGridView3);
            this.Name = "FormSam";
            this.Text = "FormSam";
            this.Load += new System.EventHandler(this.FormSam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.курсоваяАэропорты_и_расписание_рейсов1SQLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.самолетыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView3;
        private КурсоваяАэропорты_и_расписание_рейсов1SQLDataSet курсоваяАэропорты_и_расписание_рейсов1SQLDataSet;
        private System.Windows.Forms.BindingSource самолетыBindingSource;
        private КурсоваяАэропорты_и_расписание_рейсов1SQLDataSetTableAdapters.СамолетыTableAdapter самолетыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСамолетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеСамолетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вместимостьDataGridViewTextBoxColumn;
    }
}