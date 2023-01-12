namespace Sibers_project
{
    partial class Form5_record
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
            this.button2_reset = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1_action = new System.Windows.Forms.ComboBox();
            this.label3_role = new System.Windows.Forms.Label();
            this.label2_emp = new System.Windows.Forms.Label();
            this.label1_proj = new System.Windows.Forms.Label();
            this.textBox2_emp = new System.Windows.Forms.TextBox();
            this.textBox1_proj = new System.Windows.Forms.TextBox();
            this.button1_save = new System.Windows.Forms.Button();
            this.comboBox2_role = new System.Windows.Forms.ComboBox();
            this.textBox1_id = new System.Windows.Forms.TextBox();
            this.label1_id = new System.Windows.Forms.Label();
            this.comboBoxIdProj = new System.Windows.Forms.ComboBox();
            this.comboBoxIdEmp = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button1Help = new System.Windows.Forms.Button();
            this.comboBox1search = new System.Windows.Forms.ComboBox();
            this.textBox1Search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2_reset
            // 
            this.button2_reset.Location = new System.Drawing.Point(259, 214);
            this.button2_reset.Name = "button2_reset";
            this.button2_reset.Size = new System.Drawing.Size(71, 29);
            this.button2_reset.TabIndex = 28;
            this.button2_reset.Text = "Обновить";
            this.button2_reset.UseVisualStyleBackColor = true;
            this.button2_reset.Click += new System.EventHandler(this.button2_reset_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 195);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboBox1_action
            // 
            this.comboBox1_action.FormattingEnabled = true;
            this.comboBox1_action.Items.AddRange(new object[] {
            "Добавить",
            "Изменить",
            "Удалить"});
            this.comboBox1_action.Location = new System.Drawing.Point(339, 371);
            this.comboBox1_action.Name = "comboBox1_action";
            this.comboBox1_action.Size = new System.Drawing.Size(121, 21);
            this.comboBox1_action.TabIndex = 26;
            this.comboBox1_action.Text = "Добавить";
            this.comboBox1_action.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3_role
            // 
            this.label3_role.AutoSize = true;
            this.label3_role.Location = new System.Drawing.Point(121, 331);
            this.label3_role.Name = "label3_role";
            this.label3_role.Size = new System.Drawing.Size(35, 13);
            this.label3_role.TabIndex = 23;
            this.label3_role.Text = "Роль:";
            // 
            // label2_emp
            // 
            this.label2_emp.AutoSize = true;
            this.label2_emp.Location = new System.Drawing.Point(121, 304);
            this.label2_emp.Name = "label2_emp";
            this.label2_emp.Size = new System.Drawing.Size(90, 13);
            this.label2_emp.TabIndex = 22;
            this.label2_emp.Text = "Код сотрудника:";
            // 
            // label1_proj
            // 
            this.label1_proj.AutoSize = true;
            this.label1_proj.Location = new System.Drawing.Point(121, 278);
            this.label1_proj.Name = "label1_proj";
            this.label1_proj.Size = new System.Drawing.Size(73, 13);
            this.label1_proj.TabIndex = 21;
            this.label1_proj.Text = "Код проекта:";
            // 
            // textBox2_emp
            // 
            this.textBox2_emp.Location = new System.Drawing.Point(220, 301);
            this.textBox2_emp.Name = "textBox2_emp";
            this.textBox2_emp.ReadOnly = true;
            this.textBox2_emp.Size = new System.Drawing.Size(240, 20);
            this.textBox2_emp.TabIndex = 17;
            // 
            // textBox1_proj
            // 
            this.textBox1_proj.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox1_proj.Location = new System.Drawing.Point(220, 275);
            this.textBox1_proj.Name = "textBox1_proj";
            this.textBox1_proj.ReadOnly = true;
            this.textBox1_proj.Size = new System.Drawing.Size(240, 20);
            this.textBox1_proj.TabIndex = 16;
            this.textBox1_proj.Tag = "";
            // 
            // button1_save
            // 
            this.button1_save.Location = new System.Drawing.Point(220, 371);
            this.button1_save.Name = "button1_save";
            this.button1_save.Size = new System.Drawing.Size(75, 23);
            this.button1_save.TabIndex = 15;
            this.button1_save.Text = "Сохранить";
            this.button1_save.UseVisualStyleBackColor = true;
            this.button1_save.Click += new System.EventHandler(this.button1_save_Click);
            // 
            // comboBox2_role
            // 
            this.comboBox2_role.FormattingEnabled = true;
            this.comboBox2_role.Items.AddRange(new object[] {
            "Руководитель",
            "Сотрудник"});
            this.comboBox2_role.Location = new System.Drawing.Point(220, 328);
            this.comboBox2_role.Name = "comboBox2_role";
            this.comboBox2_role.Size = new System.Drawing.Size(240, 21);
            this.comboBox2_role.TabIndex = 29;
            this.comboBox2_role.Text = "Сотрудник";
            // 
            // textBox1_id
            // 
            this.textBox1_id.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox1_id.Location = new System.Drawing.Point(220, 249);
            this.textBox1_id.Name = "textBox1_id";
            this.textBox1_id.Size = new System.Drawing.Size(240, 20);
            this.textBox1_id.TabIndex = 30;
            this.textBox1_id.Tag = "";
            // 
            // label1_id
            // 
            this.label1_id.AutoSize = true;
            this.label1_id.Location = new System.Drawing.Point(121, 252);
            this.label1_id.Name = "label1_id";
            this.label1_id.Size = new System.Drawing.Size(21, 13);
            this.label1_id.TabIndex = 31;
            this.label1_id.Text = "№:";
            // 
            // comboBoxIdProj
            // 
            this.comboBoxIdProj.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxIdProj.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBoxIdProj.FormattingEnabled = true;
            this.comboBoxIdProj.Location = new System.Drawing.Point(487, 274);
            this.comboBoxIdProj.Name = "comboBoxIdProj";
            this.comboBoxIdProj.Size = new System.Drawing.Size(69, 21);
            this.comboBoxIdProj.TabIndex = 32;
            this.comboBoxIdProj.DropDown += new System.EventHandler(this.comboBoxIdProj_DropDown);
            this.comboBoxIdProj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxIdProj_KeyPress);
            // 
            // comboBoxIdEmp
            // 
            this.comboBoxIdEmp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxIdEmp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBoxIdEmp.FormattingEnabled = true;
            this.comboBoxIdEmp.Location = new System.Drawing.Point(487, 304);
            this.comboBoxIdEmp.Name = "comboBoxIdEmp";
            this.comboBoxIdEmp.Size = new System.Drawing.Size(69, 21);
            this.comboBoxIdEmp.TabIndex = 33;
            this.comboBoxIdEmp.DropDown += new System.EventHandler(this.comboBoxIdEmp_DropDown);
            this.comboBoxIdEmp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxIdEmp_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(562, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 52);
            this.button1.TabIndex = 34;
            this.button1.Text = "подробнее";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1Help
            // 
            this.button1Help.Location = new System.Drawing.Point(577, 364);
            this.button1Help.Name = "button1Help";
            this.button1Help.Size = new System.Drawing.Size(75, 23);
            this.button1Help.TabIndex = 35;
            this.button1Help.Text = "Помощь";
            this.button1Help.UseVisualStyleBackColor = true;
            this.button1Help.Click += new System.EventHandler(this.button1Help_Click);
            // 
            // comboBox1search
            // 
            this.comboBox1search.FormattingEnabled = true;
            this.comboBox1search.Items.AddRange(new object[] {
            "Поиск по всем полям",
            "Поиск по номеру",
            "Поиск по коду проекта",
            "Поиск по названию",
            "Поиск по коду сотрудника",
            "Поиск по фамилии",
            "Поиск по роли сотрудника"});
            this.comboBox1search.Location = new System.Drawing.Point(487, 213);
            this.comboBox1search.Name = "comboBox1search";
            this.comboBox1search.Size = new System.Drawing.Size(164, 21);
            this.comboBox1search.TabIndex = 39;
            this.comboBox1search.Text = "Поиск по всем полям";
            // 
            // textBox1Search
            // 
            this.textBox1Search.Location = new System.Drawing.Point(487, 242);
            this.textBox1Search.Name = "textBox1Search";
            this.textBox1Search.Size = new System.Drawing.Size(164, 20);
            this.textBox1Search.TabIndex = 38;
            this.textBox1Search.TextChanged += new System.EventHandler(this.textBox1Search_TextChanged);
            // 
            // Form5_record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 399);
            this.Controls.Add(this.comboBox1search);
            this.Controls.Add(this.textBox1Search);
            this.Controls.Add(this.button1Help);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxIdEmp);
            this.Controls.Add(this.comboBoxIdProj);
            this.Controls.Add(this.label1_id);
            this.Controls.Add(this.textBox1_id);
            this.Controls.Add(this.comboBox2_role);
            this.Controls.Add(this.button2_reset);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1_action);
            this.Controls.Add(this.label3_role);
            this.Controls.Add(this.label2_emp);
            this.Controls.Add(this.label1_proj);
            this.Controls.Add(this.textBox2_emp);
            this.Controls.Add(this.textBox1_proj);
            this.Controls.Add(this.button1_save);
            this.Name = "Form5_record";
            this.Text = "Назначение";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2_reset;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1_action;
        private System.Windows.Forms.Label label3_role;
        private System.Windows.Forms.Label label2_emp;
        private System.Windows.Forms.Label label1_proj;
        private System.Windows.Forms.TextBox textBox2_emp;
        private System.Windows.Forms.TextBox textBox1_proj;
        private System.Windows.Forms.Button button1_save;
        private System.Windows.Forms.ComboBox comboBox2_role;
        private System.Windows.Forms.TextBox textBox1_id;
        private System.Windows.Forms.Label label1_id;
        private System.Windows.Forms.ComboBox comboBoxIdProj;
        private System.Windows.Forms.ComboBox comboBoxIdEmp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button1Help;
        private System.Windows.Forms.ComboBox comboBox1search;
        private System.Windows.Forms.TextBox textBox1Search;
    }
}