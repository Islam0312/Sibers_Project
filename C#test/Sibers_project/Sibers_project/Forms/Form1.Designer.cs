namespace Sibers_project
{
    partial class Projects
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
            this.button1_reset = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1_id = new System.Windows.Forms.Label();
            this.button2_Employees = new System.Windows.Forms.Button();
            this.button_customers = new System.Windows.Forms.Button();
            this.button_doers = new System.Windows.Forms.Button();
            this.button_records = new System.Windows.Forms.Button();
            this.textBox1NameProj = new System.Windows.Forms.TextBox();
            this.dateTimePicker1START = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2END = new System.Windows.Forms.DateTimePicker();
            this.textBox1Priority = new System.Windows.Forms.TextBox();
            this.textBox1project_id = new System.Windows.Forms.TextBox();
            this.label2_NameProj = new System.Windows.Forms.Label();
            this.label3_NameCust = new System.Windows.Forms.Label();
            this.label4_NameDoer = new System.Windows.Forms.Label();
            this.label5_Priority = new System.Windows.Forms.Label();
            this.button1_save = new System.Windows.Forms.Button();
            this.comboBox1_action = new System.Windows.Forms.ComboBox();
            this.comboBox1_cust = new System.Windows.Forms.ComboBox();
            this.comboBox2_Doer = new System.Windows.Forms.ComboBox();
            this.button1сРуководителями = new System.Windows.Forms.Button();
            this.button1Help = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1Search = new System.Windows.Forms.TextBox();
            this.comboBox1search = new System.Windows.Forms.ComboBox();
            this.dateTimePickerBetweenStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBetweenEnd = new System.Windows.Forms.DateTimePicker();
            this.label3BetweenStart = new System.Windows.Forms.Label();
            this.label4BetweenEnd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1_reset
            // 
            this.button1_reset.Location = new System.Drawing.Point(398, 213);
            this.button1_reset.Name = "button1_reset";
            this.button1_reset.Size = new System.Drawing.Size(75, 23);
            this.button1_reset.TabIndex = 0;
            this.button1_reset.Text = "Обновить";
            this.button1_reset.UseVisualStyleBackColor = true;
            this.button1_reset.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1213, 196);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1_id
            // 
            this.label1_id.AutoSize = true;
            this.label1_id.Location = new System.Drawing.Point(21, 276);
            this.label1_id.Name = "label1_id";
            this.label1_id.Size = new System.Drawing.Size(15, 13);
            this.label1_id.TabIndex = 2;
            this.label1_id.Text = "id";
            // 
            // button2_Employees
            // 
            this.button2_Employees.Location = new System.Drawing.Point(1148, 225);
            this.button2_Employees.Name = "button2_Employees";
            this.button2_Employees.Size = new System.Drawing.Size(78, 23);
            this.button2_Employees.TabIndex = 3;
            this.button2_Employees.Text = "Сотрудники";
            this.button2_Employees.UseVisualStyleBackColor = true;
            this.button2_Employees.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_customers
            // 
            this.button_customers.Location = new System.Drawing.Point(1148, 272);
            this.button_customers.Name = "button_customers";
            this.button_customers.Size = new System.Drawing.Size(78, 23);
            this.button_customers.TabIndex = 4;
            this.button_customers.Text = "Заказчики";
            this.button_customers.UseVisualStyleBackColor = true;
            this.button_customers.Click += new System.EventHandler(this.button_customers_Click);
            // 
            // button_doers
            // 
            this.button_doers.Location = new System.Drawing.Point(1148, 313);
            this.button_doers.Name = "button_doers";
            this.button_doers.Size = new System.Drawing.Size(78, 23);
            this.button_doers.TabIndex = 5;
            this.button_doers.Text = "Исполнители";
            this.button_doers.UseVisualStyleBackColor = true;
            this.button_doers.Click += new System.EventHandler(this.button_doers_Click);
            // 
            // button_records
            // 
            this.button_records.Location = new System.Drawing.Point(1148, 358);
            this.button_records.Name = "button_records";
            this.button_records.Size = new System.Drawing.Size(78, 23);
            this.button_records.TabIndex = 6;
            this.button_records.Text = "Назначение";
            this.button_records.UseVisualStyleBackColor = true;
            this.button_records.Click += new System.EventHandler(this.button_records_Click);
            // 
            // textBox1NameProj
            // 
            this.textBox1NameProj.Location = new System.Drawing.Point(124, 300);
            this.textBox1NameProj.Name = "textBox1NameProj";
            this.textBox1NameProj.Size = new System.Drawing.Size(137, 20);
            this.textBox1NameProj.TabIndex = 7;
            // 
            // dateTimePicker1START
            // 
            this.dateTimePicker1START.Location = new System.Drawing.Point(124, 406);
            this.dateTimePicker1START.Name = "dateTimePicker1START";
            this.dateTimePicker1START.Size = new System.Drawing.Size(137, 20);
            this.dateTimePicker1START.TabIndex = 10;
            this.dateTimePicker1START.ValueChanged += new System.EventHandler(this.dateTimePicker1START_ValueChanged);
            // 
            // dateTimePicker2END
            // 
            this.dateTimePicker2END.Location = new System.Drawing.Point(124, 433);
            this.dateTimePicker2END.Name = "dateTimePicker2END";
            this.dateTimePicker2END.Size = new System.Drawing.Size(137, 20);
            this.dateTimePicker2END.TabIndex = 11;
            this.dateTimePicker2END.ValueChanged += new System.EventHandler(this.dateTimePicker2END_ValueChanged);
            // 
            // textBox1Priority
            // 
            this.textBox1Priority.Location = new System.Drawing.Point(124, 380);
            this.textBox1Priority.Name = "textBox1Priority";
            this.textBox1Priority.Size = new System.Drawing.Size(137, 20);
            this.textBox1Priority.TabIndex = 12;
            // 
            // textBox1project_id
            // 
            this.textBox1project_id.Location = new System.Drawing.Point(124, 273);
            this.textBox1project_id.Name = "textBox1project_id";
            this.textBox1project_id.Size = new System.Drawing.Size(137, 20);
            this.textBox1project_id.TabIndex = 13;
            // 
            // label2_NameProj
            // 
            this.label2_NameProj.AutoSize = true;
            this.label2_NameProj.Location = new System.Drawing.Point(21, 303);
            this.label2_NameProj.Name = "label2_NameProj";
            this.label2_NameProj.Size = new System.Drawing.Size(99, 13);
            this.label2_NameProj.TabIndex = 14;
            this.label2_NameProj.Text = "название проекта";
            // 
            // label3_NameCust
            // 
            this.label3_NameCust.AutoSize = true;
            this.label3_NameCust.Location = new System.Drawing.Point(21, 331);
            this.label3_NameCust.Name = "label3_NameCust";
            this.label3_NameCust.Size = new System.Drawing.Size(54, 13);
            this.label3_NameCust.TabIndex = 15;
            this.label3_NameCust.Text = "заказчик";
            // 
            // label4_NameDoer
            // 
            this.label4_NameDoer.AutoSize = true;
            this.label4_NameDoer.Location = new System.Drawing.Point(21, 357);
            this.label4_NameDoer.Name = "label4_NameDoer";
            this.label4_NameDoer.Size = new System.Drawing.Size(72, 13);
            this.label4_NameDoer.TabIndex = 16;
            this.label4_NameDoer.Text = "исполнитель";
            // 
            // label5_Priority
            // 
            this.label5_Priority.AutoSize = true;
            this.label5_Priority.Location = new System.Drawing.Point(21, 383);
            this.label5_Priority.Name = "label5_Priority";
            this.label5_Priority.Size = new System.Drawing.Size(59, 13);
            this.label5_Priority.TabIndex = 17;
            this.label5_Priority.Text = "приоритет";
            // 
            // button1_save
            // 
            this.button1_save.Location = new System.Drawing.Point(305, 432);
            this.button1_save.Name = "button1_save";
            this.button1_save.Size = new System.Drawing.Size(75, 23);
            this.button1_save.TabIndex = 19;
            this.button1_save.Text = "Сохранить";
            this.button1_save.UseVisualStyleBackColor = true;
            this.button1_save.Click += new System.EventHandler(this.button1_save_Click);
            // 
            // comboBox1_action
            // 
            this.comboBox1_action.FormattingEnabled = true;
            this.comboBox1_action.Items.AddRange(new object[] {
            "Добавить",
            "Изменить",
            "Удалить"});
            this.comboBox1_action.Location = new System.Drawing.Point(283, 405);
            this.comboBox1_action.Name = "comboBox1_action";
            this.comboBox1_action.Size = new System.Drawing.Size(121, 21);
            this.comboBox1_action.TabIndex = 27;
            this.comboBox1_action.Text = "Добавить";
            this.comboBox1_action.SelectedIndexChanged += new System.EventHandler(this.comboBox1_action_SelectedIndexChanged);
            // 
            // comboBox1_cust
            // 
            this.comboBox1_cust.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1_cust.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox1_cust.FormattingEnabled = true;
            this.comboBox1_cust.Location = new System.Drawing.Point(124, 326);
            this.comboBox1_cust.Name = "comboBox1_cust";
            this.comboBox1_cust.Size = new System.Drawing.Size(137, 21);
            this.comboBox1_cust.TabIndex = 28;
            this.comboBox1_cust.DropDown += new System.EventHandler(this.comboBox1_cust_DropDown);
            this.comboBox1_cust.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_cust_KeyPress);
            // 
            // comboBox2_Doer
            // 
            this.comboBox2_Doer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox2_Doer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox2_Doer.FormattingEnabled = true;
            this.comboBox2_Doer.Location = new System.Drawing.Point(124, 354);
            this.comboBox2_Doer.Name = "comboBox2_Doer";
            this.comboBox2_Doer.Size = new System.Drawing.Size(137, 21);
            this.comboBox2_Doer.TabIndex = 29;
            this.comboBox2_Doer.DropDown += new System.EventHandler(this.comboBox2_Doer_DropDown);
            this.comboBox2_Doer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox2_Doer_KeyPress);
            // 
            // button1сРуководителями
            // 
            this.button1сРуководителями.Location = new System.Drawing.Point(361, 241);
            this.button1сРуководителями.Name = "button1сРуководителями";
            this.button1сРуководителями.Size = new System.Drawing.Size(161, 23);
            this.button1сРуководителями.TabIndex = 30;
            this.button1сРуководителями.Text = "Проекты с руководителями";
            this.button1сРуководителями.UseVisualStyleBackColor = true;
            this.button1сРуководителями.Click += new System.EventHandler(this.button1сРуководителями_Click);
            // 
            // button1Help
            // 
            this.button1Help.Location = new System.Drawing.Point(1151, 448);
            this.button1Help.Name = "button1Help";
            this.button1Help.Size = new System.Drawing.Size(75, 23);
            this.button1Help.TabIndex = 31;
            this.button1Help.Text = "Помощь";
            this.button1Help.UseVisualStyleBackColor = true;
            this.button1Help.Click += new System.EventHandler(this.button1Help_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "начало";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "конец";
            // 
            // textBox1Search
            // 
            this.textBox1Search.Location = new System.Drawing.Point(682, 244);
            this.textBox1Search.Name = "textBox1Search";
            this.textBox1Search.Size = new System.Drawing.Size(159, 20);
            this.textBox1Search.TabIndex = 34;
            this.textBox1Search.TextChanged += new System.EventHandler(this.textBox1Search_TextChanged);
            // 
            // comboBox1search
            // 
            this.comboBox1search.FormattingEnabled = true;
            this.comboBox1search.Items.AddRange(new object[] {
            "Поиск по всем полям",
            "Поиск по коду проекта",
            "Поиск по названию проекта",
            "Поиск по заказчику",
            "Поиск по исполнителю",
            "Поиск по дате начала",
            "Поиск по дате окончания",
            "Поиск по приоритету",
            "Поиск по фамилии",
            "Поиск по имени",
            "Поиск по отчеству",
            "Поиск по email",
            "Поиск по роли сотрудника",
            "Поиск по диапозону дат"});
            this.comboBox1search.Location = new System.Drawing.Point(682, 215);
            this.comboBox1search.Name = "comboBox1search";
            this.comboBox1search.Size = new System.Drawing.Size(159, 21);
            this.comboBox1search.TabIndex = 35;
            this.comboBox1search.Text = "Поиск по всем полям";
            this.comboBox1search.SelectedIndexChanged += new System.EventHandler(this.comboBox1search_SelectedIndexChanged);
            // 
            // dateTimePickerBetweenStart
            // 
            this.dateTimePickerBetweenStart.Location = new System.Drawing.Point(660, 244);
            this.dateTimePickerBetweenStart.Name = "dateTimePickerBetweenStart";
            this.dateTimePickerBetweenStart.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerBetweenStart.TabIndex = 36;
            this.dateTimePickerBetweenStart.ValueChanged += new System.EventHandler(this.dateTimePickerBetweenStart_ValueChanged);
            // 
            // dateTimePickerBetweenEnd
            // 
            this.dateTimePickerBetweenEnd.Location = new System.Drawing.Point(660, 269);
            this.dateTimePickerBetweenEnd.Name = "dateTimePickerBetweenEnd";
            this.dateTimePickerBetweenEnd.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerBetweenEnd.TabIndex = 37;
            this.dateTimePickerBetweenEnd.ValueChanged += new System.EventHandler(this.dateTimePickerBetweenEnd_ValueChanged);
            // 
            // label3BetweenStart
            // 
            this.label3BetweenStart.AutoSize = true;
            this.label3BetweenStart.Location = new System.Drawing.Point(568, 247);
            this.label3BetweenStart.Name = "label3BetweenStart";
            this.label3BetweenStart.Size = new System.Drawing.Size(83, 13);
            this.label3BetweenStart.TabIndex = 38;
            this.label3BetweenStart.Text = "В диапозоне с:";
            // 
            // label4BetweenEnd
            // 
            this.label4BetweenEnd.AutoSize = true;
            this.label4BetweenEnd.Location = new System.Drawing.Point(629, 270);
            this.label4BetweenEnd.Name = "label4BetweenEnd";
            this.label4BetweenEnd.Size = new System.Drawing.Size(22, 13);
            this.label4BetweenEnd.TabIndex = 39;
            this.label4BetweenEnd.Text = "по:";
            // 
            // Projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 483);
            this.Controls.Add(this.label4BetweenEnd);
            this.Controls.Add(this.label3BetweenStart);
            this.Controls.Add(this.dateTimePickerBetweenEnd);
            this.Controls.Add(this.dateTimePickerBetweenStart);
            this.Controls.Add(this.comboBox1search);
            this.Controls.Add(this.textBox1Search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1Help);
            this.Controls.Add(this.button1сРуководителями);
            this.Controls.Add(this.comboBox2_Doer);
            this.Controls.Add(this.comboBox1_cust);
            this.Controls.Add(this.comboBox1_action);
            this.Controls.Add(this.button1_save);
            this.Controls.Add(this.label5_Priority);
            this.Controls.Add(this.label4_NameDoer);
            this.Controls.Add(this.label3_NameCust);
            this.Controls.Add(this.label2_NameProj);
            this.Controls.Add(this.textBox1project_id);
            this.Controls.Add(this.textBox1Priority);
            this.Controls.Add(this.dateTimePicker2END);
            this.Controls.Add(this.dateTimePicker1START);
            this.Controls.Add(this.textBox1NameProj);
            this.Controls.Add(this.button_records);
            this.Controls.Add(this.button_doers);
            this.Controls.Add(this.button_customers);
            this.Controls.Add(this.button2_Employees);
            this.Controls.Add(this.label1_id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1_reset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Projects";
            this.Text = "Проекты";
            this.Load += new System.EventHandler(this.Projects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_reset;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1_id;
        private System.Windows.Forms.Button button2_Employees;
        private System.Windows.Forms.Button button_customers;
        private System.Windows.Forms.Button button_doers;
        private System.Windows.Forms.Button button_records;
        private System.Windows.Forms.TextBox textBox1NameProj;
        private System.Windows.Forms.DateTimePicker dateTimePicker1START;
        private System.Windows.Forms.DateTimePicker dateTimePicker2END;
        private System.Windows.Forms.TextBox textBox1Priority;
        private System.Windows.Forms.TextBox textBox1project_id;
        private System.Windows.Forms.Label label2_NameProj;
        private System.Windows.Forms.Label label3_NameCust;
        private System.Windows.Forms.Label label4_NameDoer;
        private System.Windows.Forms.Label label5_Priority;
        private System.Windows.Forms.Button button1_save;
        private System.Windows.Forms.ComboBox comboBox1_action;
        private System.Windows.Forms.ComboBox comboBox1_cust;
        private System.Windows.Forms.ComboBox comboBox2_Doer;
        private System.Windows.Forms.Button button1сРуководителями;
        private System.Windows.Forms.Button button1Help;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1Search;
        private System.Windows.Forms.ComboBox comboBox1search;
        private System.Windows.Forms.DateTimePicker dateTimePickerBetweenStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerBetweenEnd;
        private System.Windows.Forms.Label label3BetweenStart;
        private System.Windows.Forms.Label label4BetweenEnd;
    }
}

