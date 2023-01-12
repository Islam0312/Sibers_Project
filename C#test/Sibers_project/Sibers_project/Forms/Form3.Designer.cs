namespace Sibers_project
{
    partial class Form3_Customer
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1_save = new System.Windows.Forms.Button();
            this.button2_reset = new System.Windows.Forms.Button();
            this.textBox1_Code = new System.Windows.Forms.TextBox();
            this.label1_Code = new System.Windows.Forms.Label();
            this.textBox1_name = new System.Windows.Forms.TextBox();
            this.label1_name = new System.Windows.Forms.Label();
            this.button1Help = new System.Windows.Forms.Button();
            this.comboBox1search = new System.Windows.Forms.ComboBox();
            this.textBox1Search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(242, 172);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Добавить",
            "Изменить",
            "Удалить"});
            this.comboBox1.Location = new System.Drawing.Point(152, 384);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(77, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Добавить";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1_save
            // 
            this.button1_save.Location = new System.Drawing.Point(38, 382);
            this.button1_save.Name = "button1_save";
            this.button1_save.Size = new System.Drawing.Size(75, 23);
            this.button1_save.TabIndex = 2;
            this.button1_save.Text = "Сохранить";
            this.button1_save.UseVisualStyleBackColor = true;
            this.button1_save.Click += new System.EventHandler(this.button1_save_Click);
            // 
            // button2_reset
            // 
            this.button2_reset.Location = new System.Drawing.Point(94, 191);
            this.button2_reset.Name = "button2_reset";
            this.button2_reset.Size = new System.Drawing.Size(75, 23);
            this.button2_reset.TabIndex = 3;
            this.button2_reset.Text = "Обновить";
            this.button2_reset.UseVisualStyleBackColor = true;
            this.button2_reset.Click += new System.EventHandler(this.button2_reset_Click);
            // 
            // textBox1_Code
            // 
            this.textBox1_Code.Location = new System.Drawing.Point(129, 297);
            this.textBox1_Code.Name = "textBox1_Code";
            this.textBox1_Code.Size = new System.Drawing.Size(100, 20);
            this.textBox1_Code.TabIndex = 4;
            // 
            // label1_Code
            // 
            this.label1_Code.AutoSize = true;
            this.label1_Code.Location = new System.Drawing.Point(35, 300);
            this.label1_Code.Name = "label1_Code";
            this.label1_Code.Size = new System.Drawing.Size(82, 13);
            this.label1_Code.TabIndex = 5;
            this.label1_Code.Text = "Код заказчика";
            // 
            // textBox1_name
            // 
            this.textBox1_name.Location = new System.Drawing.Point(129, 335);
            this.textBox1_name.Name = "textBox1_name";
            this.textBox1_name.Size = new System.Drawing.Size(100, 20);
            this.textBox1_name.TabIndex = 6;
            // 
            // label1_name
            // 
            this.label1_name.AutoSize = true;
            this.label1_name.Location = new System.Drawing.Point(35, 338);
            this.label1_name.Name = "label1_name";
            this.label1_name.Size = new System.Drawing.Size(57, 13);
            this.label1_name.TabIndex = 7;
            this.label1_name.Text = "Название";
            // 
            // button1Help
            // 
            this.button1Help.Location = new System.Drawing.Point(182, 415);
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
            "Поиск по названию"});
            this.comboBox1search.Location = new System.Drawing.Point(52, 220);
            this.comboBox1search.Name = "comboBox1search";
            this.comboBox1search.Size = new System.Drawing.Size(159, 21);
            this.comboBox1search.TabIndex = 39;
            this.comboBox1search.Text = "Поиск по всем полям";
            // 
            // textBox1Search
            // 
            this.textBox1Search.Location = new System.Drawing.Point(52, 249);
            this.textBox1Search.Name = "textBox1Search";
            this.textBox1Search.Size = new System.Drawing.Size(159, 20);
            this.textBox1Search.TabIndex = 38;
            this.textBox1Search.TextChanged += new System.EventHandler(this.textBox1Search_TextChanged);
            // 
            // Form3_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 450);
            this.Controls.Add(this.comboBox1search);
            this.Controls.Add(this.textBox1Search);
            this.Controls.Add(this.button1Help);
            this.Controls.Add(this.label1_name);
            this.Controls.Add(this.textBox1_name);
            this.Controls.Add(this.label1_Code);
            this.Controls.Add(this.textBox1_Code);
            this.Controls.Add(this.button2_reset);
            this.Controls.Add(this.button1_save);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form3_Customer";
            this.Text = "Заказчики";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1_save;
        private System.Windows.Forms.Button button2_reset;
        private System.Windows.Forms.TextBox textBox1_Code;
        private System.Windows.Forms.Label label1_Code;
        private System.Windows.Forms.TextBox textBox1_name;
        private System.Windows.Forms.Label label1_name;
        private System.Windows.Forms.Button button1Help;
        private System.Windows.Forms.ComboBox comboBox1search;
        private System.Windows.Forms.TextBox textBox1Search;
    }
}