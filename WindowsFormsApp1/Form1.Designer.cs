namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авиакомпанииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аэропортыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расписаниеРейсовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рейсыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.самолетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодАвиакомпанииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеАвиакомпанииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.странаАвиакомпанииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.авиакомпанииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.курсоваяАэропорты_и_расписание_рейсов1SQLDataSet = new WindowsFormsApp1.КурсоваяАэропорты_и_расписание_рейсов1SQLDataSet();
            this.авиакомпанииTableAdapter = new WindowsFormsApp1.КурсоваяАэропорты_и_расписание_рейсов1SQLDataSetTableAdapters.АвиакомпанииTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.кодАэропортаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеАэропортаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресАэропортаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонАэропортаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОНачальникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.аэропортыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.аэропортыTableAdapter = new WindowsFormsApp1.КурсоваяАэропорты_и_расписание_рейсов1SQLDataSetTableAdapters.АэропортыTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.номерРейсаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодАвиакомпанииDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСамолетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодНачальногоАэропортаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодКонечногоАэропортаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяОтправленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяПрибытияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.расписаниеРейсовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.расписание_рейсовTableAdapter = new WindowsFormsApp1.КурсоваяАэропорты_и_расписание_рейсов1SQLDataSetTableAdapters.Расписание_рейсовTableAdapter();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.кодРейсаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерРейсаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.колвоМестDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.забронировано1КлассDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.забронировано2КлассDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.забронировано3КлассDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.цена1КлассDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.цена2КлассDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.цена3КлассDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рейсыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.самолетыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.самолетыTableAdapter = new WindowsFormsApp1.КурсоваяАэропорты_и_расписание_рейсов1SQLDataSetTableAdapters.СамолетыTableAdapter();
            this.рейсыTableAdapter = new WindowsFormsApp1.КурсоваяАэропорты_и_расписание_рейсов1SQLDataSetTableAdapters.РейсыTableAdapter();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.кодСамолетаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеСамолетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вместимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.авиакомпанииBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.авиакомпанииBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.курсоваяАэропорты_и_расписание_рейсов1SQLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.аэропортыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.расписаниеРейсовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рейсыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.самолетыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.авиакомпанииBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицыToolStripMenuItem,
            this.запросыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1112, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.авиакомпанииToolStripMenuItem,
            this.аэропортыToolStripMenuItem,
            this.расписаниеРейсовToolStripMenuItem,
            this.рейсыToolStripMenuItem,
            this.самолетыToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // авиакомпанииToolStripMenuItem
            // 
            this.авиакомпанииToolStripMenuItem.Name = "авиакомпанииToolStripMenuItem";
            this.авиакомпанииToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.авиакомпанииToolStripMenuItem.Text = "Авиакомпании";
            this.авиакомпанииToolStripMenuItem.Click += new System.EventHandler(this.авиакомпанииToolStripMenuItem_Click);
            // 
            // аэропортыToolStripMenuItem
            // 
            this.аэропортыToolStripMenuItem.Name = "аэропортыToolStripMenuItem";
            this.аэропортыToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.аэропортыToolStripMenuItem.Text = "Аэропорты";
            this.аэропортыToolStripMenuItem.Click += new System.EventHandler(this.аэропортыToolStripMenuItem_Click);
            // 
            // расписаниеРейсовToolStripMenuItem
            // 
            this.расписаниеРейсовToolStripMenuItem.Name = "расписаниеРейсовToolStripMenuItem";
            this.расписаниеРейсовToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.расписаниеРейсовToolStripMenuItem.Text = "Расписание рейсов";
            this.расписаниеРейсовToolStripMenuItem.Click += new System.EventHandler(this.расписаниеРейсовToolStripMenuItem_Click);
            // 
            // рейсыToolStripMenuItem
            // 
            this.рейсыToolStripMenuItem.Name = "рейсыToolStripMenuItem";
            this.рейсыToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.рейсыToolStripMenuItem.Text = "Рейсы";
            this.рейсыToolStripMenuItem.Click += new System.EventHandler(this.рейсыToolStripMenuItem_Click);
            // 
            // самолетыToolStripMenuItem
            // 
            this.самолетыToolStripMenuItem.Name = "самолетыToolStripMenuItem";
            this.самолетыToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.самолетыToolStripMenuItem.Text = "Самолеты";
            this.самолетыToolStripMenuItem.Click += new System.EventHandler(this.самолетыToolStripMenuItem_Click);
            // 
            // запросыToolStripMenuItem
            // 
            this.запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            this.запросыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.запросыToolStripMenuItem.Text = "Запросы";
            this.запросыToolStripMenuItem.Click += new System.EventHandler(this.запросыToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодАвиакомпанииDataGridViewTextBoxColumn,
            this.названиеАвиакомпанииDataGridViewTextBoxColumn,
            this.странаАвиакомпанииDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.авиакомпанииBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1112, 114);
            this.dataGridView1.TabIndex = 1;
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
            this.названиеАвиакомпанииDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // странаАвиакомпанииDataGridViewTextBoxColumn
            // 
            this.странаАвиакомпанииDataGridViewTextBoxColumn.DataPropertyName = "Страна авиакомпании";
            this.странаАвиакомпанииDataGridViewTextBoxColumn.HeaderText = "Страна авиакомпании";
            this.странаАвиакомпанииDataGridViewTextBoxColumn.Name = "странаАвиакомпанииDataGridViewTextBoxColumn";
            this.странаАвиакомпанииDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // авиакомпанииBindingSource
            // 
            this.авиакомпанииBindingSource.DataMember = "Авиакомпании";
            this.авиакомпанииBindingSource.DataSource = this.курсоваяАэропорты_и_расписание_рейсов1SQLDataSet;
            // 
            // курсоваяАэропорты_и_расписание_рейсов1SQLDataSet
            // 
            this.курсоваяАэропорты_и_расписание_рейсов1SQLDataSet.DataSetName = "КурсоваяАэропорты_и_расписание_рейсов1SQLDataSet";
            this.курсоваяАэропорты_и_расписание_рейсов1SQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // авиакомпанииTableAdapter
            // 
            this.авиакомпанииTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодАэропортаDataGridViewTextBoxColumn,
            this.названиеАэропортаDataGridViewTextBoxColumn,
            this.адресАэропортаDataGridViewTextBoxColumn,
            this.телефонАэропортаDataGridViewTextBoxColumn,
            this.фИОНачальникаDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.аэропортыBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView2.Location = new System.Drawing.Point(0, 138);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(1112, 108);
            this.dataGridView2.TabIndex = 2;
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
            this.названиеАэропортаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // адресАэропортаDataGridViewTextBoxColumn
            // 
            this.адресАэропортаDataGridViewTextBoxColumn.DataPropertyName = "Адрес аэропорта";
            this.адресАэропортаDataGridViewTextBoxColumn.HeaderText = "Адрес аэропорта";
            this.адресАэропортаDataGridViewTextBoxColumn.Name = "адресАэропортаDataGridViewTextBoxColumn";
            this.адресАэропортаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // телефонАэропортаDataGridViewTextBoxColumn
            // 
            this.телефонАэропортаDataGridViewTextBoxColumn.DataPropertyName = "Телефон аэропорта";
            this.телефонАэропортаDataGridViewTextBoxColumn.HeaderText = "Телефон аэропорта";
            this.телефонАэропортаDataGridViewTextBoxColumn.Name = "телефонАэропортаDataGridViewTextBoxColumn";
            this.телефонАэропортаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фИОНачальникаDataGridViewTextBoxColumn
            // 
            this.фИОНачальникаDataGridViewTextBoxColumn.DataPropertyName = "ФИО начальника";
            this.фИОНачальникаDataGridViewTextBoxColumn.HeaderText = "ФИО начальника";
            this.фИОНачальникаDataGridViewTextBoxColumn.Name = "фИОНачальникаDataGridViewTextBoxColumn";
            this.фИОНачальникаDataGridViewTextBoxColumn.ReadOnly = true;
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
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерРейсаDataGridViewTextBoxColumn,
            this.кодАвиакомпанииDataGridViewTextBoxColumn1,
            this.кодСамолетаDataGridViewTextBoxColumn,
            this.кодНачальногоАэропортаDataGridViewTextBoxColumn,
            this.кодКонечногоАэропортаDataGridViewTextBoxColumn,
            this.времяОтправленияDataGridViewTextBoxColumn,
            this.времяПрибытияDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.расписаниеРейсовBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView3.Location = new System.Drawing.Point(0, 246);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(1112, 143);
            this.dataGridView3.TabIndex = 3;
            // 
            // номерРейсаDataGridViewTextBoxColumn
            // 
            this.номерРейсаDataGridViewTextBoxColumn.DataPropertyName = "Номер рейса";
            this.номерРейсаDataGridViewTextBoxColumn.HeaderText = "Номер рейса";
            this.номерРейсаDataGridViewTextBoxColumn.Name = "номерРейсаDataGridViewTextBoxColumn";
            this.номерРейсаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодАвиакомпанииDataGridViewTextBoxColumn1
            // 
            this.кодАвиакомпанииDataGridViewTextBoxColumn1.DataPropertyName = "Код авиакомпании";
            this.кодАвиакомпанииDataGridViewTextBoxColumn1.HeaderText = "Код авиакомпании";
            this.кодАвиакомпанииDataGridViewTextBoxColumn1.Name = "кодАвиакомпанииDataGridViewTextBoxColumn1";
            this.кодАвиакомпанииDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // кодСамолетаDataGridViewTextBoxColumn
            // 
            this.кодСамолетаDataGridViewTextBoxColumn.DataPropertyName = "Код самолета";
            this.кодСамолетаDataGridViewTextBoxColumn.HeaderText = "Код самолета";
            this.кодСамолетаDataGridViewTextBoxColumn.Name = "кодСамолетаDataGridViewTextBoxColumn";
            this.кодСамолетаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодНачальногоАэропортаDataGridViewTextBoxColumn
            // 
            this.кодНачальногоАэропортаDataGridViewTextBoxColumn.DataPropertyName = "Код начального аэропорта";
            this.кодНачальногоАэропортаDataGridViewTextBoxColumn.HeaderText = "Код начального аэропорта";
            this.кодНачальногоАэропортаDataGridViewTextBoxColumn.Name = "кодНачальногоАэропортаDataGridViewTextBoxColumn";
            this.кодНачальногоАэропортаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодКонечногоАэропортаDataGridViewTextBoxColumn
            // 
            this.кодКонечногоАэропортаDataGridViewTextBoxColumn.DataPropertyName = "Код конечного аэропорта";
            this.кодКонечногоАэропортаDataGridViewTextBoxColumn.HeaderText = "Код конечного аэропорта";
            this.кодКонечногоАэропортаDataGridViewTextBoxColumn.Name = "кодКонечногоАэропортаDataGridViewTextBoxColumn";
            this.кодКонечногоАэропортаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // времяОтправленияDataGridViewTextBoxColumn
            // 
            this.времяОтправленияDataGridViewTextBoxColumn.DataPropertyName = "Время отправления";
            this.времяОтправленияDataGridViewTextBoxColumn.HeaderText = "Время отправления";
            this.времяОтправленияDataGridViewTextBoxColumn.Name = "времяОтправленияDataGridViewTextBoxColumn";
            this.времяОтправленияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // времяПрибытияDataGridViewTextBoxColumn
            // 
            this.времяПрибытияDataGridViewTextBoxColumn.DataPropertyName = "Время прибытия";
            this.времяПрибытияDataGridViewTextBoxColumn.HeaderText = "Время прибытия";
            this.времяПрибытияDataGridViewTextBoxColumn.Name = "времяПрибытияDataGridViewTextBoxColumn";
            this.времяПрибытияDataGridViewTextBoxColumn.ReadOnly = true;
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
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодРейсаDataGridViewTextBoxColumn,
            this.номерРейсаDataGridViewTextBoxColumn1,
            this.колвоМестDataGridViewTextBoxColumn,
            this.забронировано1КлассDataGridViewTextBoxColumn,
            this.забронировано2КлассDataGridViewTextBoxColumn,
            this.забронировано3КлассDataGridViewTextBoxColumn,
            this.цена1КлассDataGridViewTextBoxColumn,
            this.цена2КлассDataGridViewTextBoxColumn,
            this.цена3КлассDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.рейсыBindingSource;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView4.Location = new System.Drawing.Point(0, 389);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(1112, 150);
            this.dataGridView4.TabIndex = 4;
            // 
            // кодРейсаDataGridViewTextBoxColumn
            // 
            this.кодРейсаDataGridViewTextBoxColumn.DataPropertyName = "Код рейса";
            this.кодРейсаDataGridViewTextBoxColumn.HeaderText = "Код рейса";
            this.кодРейсаDataGridViewTextBoxColumn.Name = "кодРейсаDataGridViewTextBoxColumn";
            this.кодРейсаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // номерРейсаDataGridViewTextBoxColumn1
            // 
            this.номерРейсаDataGridViewTextBoxColumn1.DataPropertyName = "Номер рейса";
            this.номерРейсаDataGridViewTextBoxColumn1.HeaderText = "Номер рейса";
            this.номерРейсаDataGridViewTextBoxColumn1.Name = "номерРейсаDataGridViewTextBoxColumn1";
            this.номерРейсаDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // колвоМестDataGridViewTextBoxColumn
            // 
            this.колвоМестDataGridViewTextBoxColumn.DataPropertyName = "Кол-во мест";
            this.колвоМестDataGridViewTextBoxColumn.HeaderText = "Кол-во мест";
            this.колвоМестDataGridViewTextBoxColumn.Name = "колвоМестDataGridViewTextBoxColumn";
            this.колвоМестDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // забронировано1КлассDataGridViewTextBoxColumn
            // 
            this.забронировано1КлассDataGridViewTextBoxColumn.DataPropertyName = "Забронировано 1 класс";
            this.забронировано1КлассDataGridViewTextBoxColumn.HeaderText = "Забронировано 1 класс";
            this.забронировано1КлассDataGridViewTextBoxColumn.Name = "забронировано1КлассDataGridViewTextBoxColumn";
            this.забронировано1КлассDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // забронировано2КлассDataGridViewTextBoxColumn
            // 
            this.забронировано2КлассDataGridViewTextBoxColumn.DataPropertyName = "Забронировано 2 класс";
            this.забронировано2КлассDataGridViewTextBoxColumn.HeaderText = "Забронировано 2 класс";
            this.забронировано2КлассDataGridViewTextBoxColumn.Name = "забронировано2КлассDataGridViewTextBoxColumn";
            this.забронировано2КлассDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // забронировано3КлассDataGridViewTextBoxColumn
            // 
            this.забронировано3КлассDataGridViewTextBoxColumn.DataPropertyName = "Забронировано 3 класс";
            this.забронировано3КлассDataGridViewTextBoxColumn.HeaderText = "Забронировано 3 класс";
            this.забронировано3КлассDataGridViewTextBoxColumn.Name = "забронировано3КлассDataGridViewTextBoxColumn";
            this.забронировано3КлассDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // цена1КлассDataGridViewTextBoxColumn
            // 
            this.цена1КлассDataGridViewTextBoxColumn.DataPropertyName = "Цена 1 класс";
            this.цена1КлассDataGridViewTextBoxColumn.HeaderText = "Цена 1 класс";
            this.цена1КлассDataGridViewTextBoxColumn.Name = "цена1КлассDataGridViewTextBoxColumn";
            this.цена1КлассDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // цена2КлассDataGridViewTextBoxColumn
            // 
            this.цена2КлассDataGridViewTextBoxColumn.DataPropertyName = "Цена 2 класс";
            this.цена2КлассDataGridViewTextBoxColumn.HeaderText = "Цена 2 класс";
            this.цена2КлассDataGridViewTextBoxColumn.Name = "цена2КлассDataGridViewTextBoxColumn";
            this.цена2КлассDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // цена3КлассDataGridViewTextBoxColumn
            // 
            this.цена3КлассDataGridViewTextBoxColumn.DataPropertyName = "Цена 3 класс";
            this.цена3КлассDataGridViewTextBoxColumn.HeaderText = "Цена 3 класс";
            this.цена3КлассDataGridViewTextBoxColumn.Name = "цена3КлассDataGridViewTextBoxColumn";
            this.цена3КлассDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // рейсыBindingSource
            // 
            this.рейсыBindingSource.DataMember = "Рейсы";
            this.рейсыBindingSource.DataSource = this.курсоваяАэропорты_и_расписание_рейсов1SQLDataSet;
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
            // рейсыTableAdapter
            // 
            this.рейсыTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодСамолетаDataGridViewTextBoxColumn1,
            this.названиеСамолетаDataGridViewTextBoxColumn,
            this.вместимостьDataGridViewTextBoxColumn});
            this.dataGridView5.DataSource = this.самолетыBindingSource;
            this.dataGridView5.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView5.Location = new System.Drawing.Point(0, 539);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(1112, 150);
            this.dataGridView5.TabIndex = 5;
            // 
            // кодСамолетаDataGridViewTextBoxColumn1
            // 
            this.кодСамолетаDataGridViewTextBoxColumn1.DataPropertyName = "Код самолета";
            this.кодСамолетаDataGridViewTextBoxColumn1.HeaderText = "Код самолета";
            this.кодСамолетаDataGridViewTextBoxColumn1.Name = "кодСамолетаDataGridViewTextBoxColumn1";
            this.кодСамолетаDataGridViewTextBoxColumn1.ReadOnly = true;
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
            // авиакомпанииBindingSource1
            // 
            this.авиакомпанииBindingSource1.DataMember = "Авиакомпании";
            this.авиакомпанииBindingSource1.DataSource = this.курсоваяАэропорты_и_расписание_рейсов1SQLDataSet;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 705);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Расписание аэропорта";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.авиакомпанииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.курсоваяАэропорты_и_расписание_рейсов1SQLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аэропортыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.расписаниеРейсовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рейсыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.самолетыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.авиакомпанииBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem авиакомпанииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аэропортыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расписаниеРейсовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рейсыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem самолетыToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private КурсоваяАэропорты_и_расписание_рейсов1SQLDataSet курсоваяАэропорты_и_расписание_рейсов1SQLDataSet;
        private System.Windows.Forms.BindingSource авиакомпанииBindingSource;
        private КурсоваяАэропорты_и_расписание_рейсов1SQLDataSetTableAdapters.АвиакомпанииTableAdapter авиакомпанииTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодАвиакомпанииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеАвиакомпанииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn странаАвиакомпанииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource аэропортыBindingSource;
        private КурсоваяАэропорты_и_расписание_рейсов1SQLDataSetTableAdapters.АэропортыTableAdapter аэропортыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодАэропортаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеАэропортаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресАэропортаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонАэропортаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОНачальникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource расписаниеРейсовBindingSource;
        private КурсоваяАэропорты_и_расписание_рейсов1SQLDataSetTableAdapters.Расписание_рейсовTableAdapter расписание_рейсовTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерРейсаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодАвиакомпанииDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСамолетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодНачальногоАэропортаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКонечногоАэропортаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяОтправленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяПрибытияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.BindingSource самолетыBindingSource;
        private КурсоваяАэропорты_и_расписание_рейсов1SQLDataSetTableAdapters.СамолетыTableAdapter самолетыTableAdapter;
        private System.Windows.Forms.BindingSource рейсыBindingSource;
        private КурсоваяАэропорты_и_расписание_рейсов1SQLDataSetTableAdapters.РейсыTableAdapter рейсыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодРейсаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерРейсаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn колвоМестDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn забронировано1КлассDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn забронировано2КлассDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn забронировано3КлассDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn цена1КлассDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn цена2КлассDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn цена3КлассDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСамолетаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеСамолетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вместимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource авиакомпанииBindingSource1;
    }
}

