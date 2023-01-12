namespace Sibers_project
{
    partial class Employee_Form
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
            this.button1_save = new System.Windows.Forms.Button();
            this.textBox1_id = new System.Windows.Forms.TextBox();
            this.textBox2_firName = new System.Windows.Forms.TextBox();
            this.textBox3_Name = new System.Windows.Forms.TextBox();
            this.textBox4_SecName = new System.Windows.Forms.TextBox();
            this.textBox5_Email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2_reset = new System.Windows.Forms.Button();
            this.button1Help = new System.Windows.Forms.Button();
            this.comboBox1search = new System.Windows.Forms.ComboBox();
            this.textBox1Search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1_save
            // 
            this.button1_save.Location = new System.Drawing.Point(130, 403);
            this.button1_save.Name = "button1_save";
            this.button1_save.Size = new System.Drawing.Size(75, 23);
            this.button1_save.TabIndex = 0;
            this.button1_save.Text = "Сохранить";
            this.button1_save.UseVisualStyleBackColor = true;
            this.button1_save.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1_id
            // 
            this.textBox1_id.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox1_id.Location = new System.Drawing.Point(130, 257);
            this.textBox1_id.Name = "textBox1_id";
            this.textBox1_id.Size = new System.Drawing.Size(240, 20);
            this.textBox1_id.TabIndex = 1;
            this.textBox1_id.Tag = "";
            // 
            // textBox2_firName
            // 
            this.textBox2_firName.Location = new System.Drawing.Point(130, 283);
            this.textBox2_firName.Name = "textBox2_firName";
            this.textBox2_firName.Size = new System.Drawing.Size(240, 20);
            this.textBox2_firName.TabIndex = 2;
            // 
            // textBox3_Name
            // 
            this.textBox3_Name.Location = new System.Drawing.Point(130, 310);
            this.textBox3_Name.Name = "textBox3_Name";
            this.textBox3_Name.Size = new System.Drawing.Size(240, 20);
            this.textBox3_Name.TabIndex = 3;
            // 
            // textBox4_SecName
            // 
            this.textBox4_SecName.Location = new System.Drawing.Point(130, 336);
            this.textBox4_SecName.Name = "textBox4_SecName";
            this.textBox4_SecName.Size = new System.Drawing.Size(240, 20);
            this.textBox4_SecName.TabIndex = 4;
            // 
            // textBox5_Email
            // 
            this.textBox5_Email.Location = new System.Drawing.Point(130, 362);
            this.textBox5_Email.Name = "textBox5_Email";
            this.textBox5_Email.Size = new System.Drawing.Size(240, 20);
            this.textBox5_Email.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Код сотрудника:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Фамилия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Имя:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Отчество:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "e-mail:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Добавить",
            "Изменить",
            "Удалить"});
            this.comboBox1.Location = new System.Drawing.Point(249, 403);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "Добавить";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(627, 195);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2_reset
            // 
            this.button2_reset.Location = new System.Drawing.Point(299, 214);
            this.button2_reset.Name = "button2_reset";
            this.button2_reset.Size = new System.Drawing.Size(71, 29);
            this.button2_reset.TabIndex = 14;
            this.button2_reset.Text = "Обновить";
            this.button2_reset.UseVisualStyleBackColor = true;
            this.button2_reset.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1Help
            // 
            this.button1Help.Location = new System.Drawing.Point(568, 415);
            this.button1Help.Name = "button1Help";
            this.button1Help.Size = new System.Drawing.Size(75, 23);
            this.button1Help.TabIndex = 32;
            this.button1Help.Text = "Помощь";
            this.button1Help.UseVisualStyleBackColor = true;
            this.button1Help.Click += new System.EventHandler(this.button1Help_Click);
            // 
            // comboBox1search
            // 
            this.comboBox1search.FormattingEnabled = true;
            this.comboBox1search.Items.AddRange(new object[] {
            "Поиск по всем полям",
            "Поиск по id",
            "Поиск по фамилии",
            "Поиск по имени",
            "Поиск по отчеству",
            "Поиск по e-mail"});
            this.comboBox1search.Location = new System.Drawing.Point(396, 214);
            this.comboBox1search.Name = "comboBox1search";
            this.comboBox1search.Size = new System.Drawing.Size(159, 21);
            this.comboBox1search.TabIndex = 37;
            this.comboBox1search.Text = "Поиск по всем полям";
            // 
            // textBox1Search
            // 
            this.textBox1Search.Location = new System.Drawing.Point(396, 243);
            this.textBox1Search.Name = "textBox1Search";
            this.textBox1Search.Size = new System.Drawing.Size(159, 20);
            this.textBox1Search.TabIndex = 36;
            this.textBox1Search.TextChanged += new System.EventHandler(this.textBox1Search_TextChanged);
            // 
            // Employee_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.comboBox1search);
            this.Controls.Add(this.textBox1Search);
            this.Controls.Add(this.button1Help);
            this.Controls.Add(this.button2_reset);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5_Email);
            this.Controls.Add(this.textBox4_SecName);
            this.Controls.Add(this.textBox3_Name);
            this.Controls.Add(this.textBox2_firName);
            this.Controls.Add(this.textBox1_id);
            this.Controls.Add(this.button1_save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Employee_Form";
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.Employee_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_save;
        private System.Windows.Forms.TextBox textBox1_id;
        private System.Windows.Forms.TextBox textBox2_firName;
        private System.Windows.Forms.TextBox textBox3_Name;
        private System.Windows.Forms.TextBox textBox4_SecName;
        private System.Windows.Forms.TextBox textBox5_Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2_reset;
        private System.Windows.Forms.Button button1Help;
        private System.Windows.Forms.ComboBox comboBox1search;
        private System.Windows.Forms.TextBox textBox1Search;
    }
}