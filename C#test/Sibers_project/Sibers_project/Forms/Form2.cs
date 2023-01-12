using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection.Emit;

namespace Sibers_project
{
    public partial class Employee_Form : Form
    {
        DataBaseConnection database = new DataBaseConnection();
        int selectedrow;

        public Employee_Form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            textBox1_id.Visible = false;
            label1.Visible = false; 
            comboBox1.KeyPress += OnKeyPress;
            comboBox1search.KeyPress += OnKeyPress;
        }


        //untouchable combobox
        void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }



        private void Employee_Form_Load(object sender, EventArgs e)
        {
            textBox2_firName.MaxLength = 50;
            textBox3_Name.MaxLength = 50;
            textBox4_SecName.MaxLength = 50;
            textBox5_Email.MaxLength = 50;
            CreateColumns();
            RefrashDataGrid(dataGridView1);
        }


        private void CreateColumns() 
        {
            dataGridView1.Columns.Add("Код_сотрудника", "id");
            dataGridView1.Columns.Add("Фамилия", "Фамилия");
            dataGridView1.Columns.Add("Имя", "Имя");
            dataGridView1.Columns.Add("Отчество", "Отчество");
            dataGridView1.Columns.Add("email", "e-mail");
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(
                record.GetInt32(0),
                record.GetString(1),
                record.GetString(2),
                record.GetString(3),
                record.GetString(4)
                );
        }

        private void RefrashDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string qer = $"select * from Employees";

            SqlCommand com = new SqlCommand(qer,database.getConnaction());

            database.openConnection();

            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }





        #region Сохранить
        private void button1_Click(object sender, EventArgs e)
        {
            string quer = $"";
            int code_emp = 0;
            var firName = textBox2_firName.Text == "" ? "NULL" : textBox2_firName.Text;
            var Name = textBox3_Name.Text == "" ? "NULL" : textBox3_Name.Text;
            var secName = textBox4_SecName.Text == "" ? "NULL" : textBox4_SecName.Text;
            var mail = textBox5_Email.Text == "" ? "NULL" : textBox5_Email.Text;
            bool b = true;


            switch (comboBox1.SelectedIndex)
            {
                case 0://add
                    {
                        quer = $"insert into Employees(Фамилия,Имя,Отчество,email) values ('{firName}','{Name}','{secName}','{mail}')";
                        break;
                    }
                case 1://update
                    {
                        if (textBox1_id.Text == "")
                        {
                            MessageBox.Show("поле \"код сотрудника\" надо заполнить", "!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        code_emp = int.Parse(textBox1_id.Text);

                        quer = $"UPDATE Employees set Фамилия = '{firName}',Имя='{Name}',Отчество='{secName}',email='{mail}' WHERE Код_сотрудника={code_emp};";
                        break;
                    }

                case 2://delete
                    {
                        if (textBox1_id.Text == "")
                        {
                            MessageBox.Show("поле \"код сотрудника\" надо заполнить", "!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        try { code_emp = int.Parse(textBox1_id.Text); }
                        catch
                        {
                            MessageBox.Show("код должен быть числом", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            b = false;
                        }

                        quer = $"delete FROM Employees where Код_сотрудника={code_emp};";
                        break;
                    }
            }
            if (b) { qerr(quer); }
            RefrashDataGrid(dataGridView1);
        }
        #endregion


        private void qerr(string qer)
        {
            database.openConnection();
            var command = new SqlCommand(qer, database.getConnaction());
            command.ExecuteNonQuery();
            database.closeConnection();
            MessageBox.Show("действие выполнено", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        
        private void button2_Click(object sender, EventArgs e)
        {
            RefrashDataGrid(dataGridView1);
        }
        
        //reset dgw1
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedrow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedrow];

                textBox1_id.Text = row.Cells[0].Value.ToString();
                textBox2_firName.Text = row.Cells[1].Value.ToString();
                textBox3_Name.Text = row.Cells[2].Value.ToString();
                textBox4_SecName.Text = row.Cells[3].Value.ToString();
                textBox5_Email.Text = row.Cells[4].Value.ToString();
            }
        }


        #region выбор действия
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBox1_id.Visible = false;
                textBox2_firName.Visible = true;
                textBox3_Name.Visible = true;
                textBox4_SecName.Visible = true;
                textBox5_Email.Visible = true;
                label1.Visible = false;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;

                textBox1_id.Text = "";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                textBox1_id.Visible = true;
                textBox2_firName.Visible = true;
                textBox3_Name.Visible = true;
                textBox4_SecName.Visible = true;
                textBox5_Email.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
            }
            else
            {
                textBox1_id.Visible = true;
                textBox2_firName.Visible = false;
                textBox3_Name.Visible = false;
                textBox4_SecName.Visible = false;
                textBox5_Email.Visible = false;
                label1.Visible = true;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
            }
        }
        #endregion

        private void button1Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1)запонляем\n" +
                "2)сохраняем\n\n" +
                "вы можете нажать на определенную строку и вся строка перепишется в поля для редактирования\n\n" +
                "для сортировки нажмите на название столбца"
                , "Справка сотрудники", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }





        private void textBox1Search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }
        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string search = whereSearch();

            string qer = $"SELECT  * " +
                $"FROM dbo.Employees ";
            if (comboBox1search.SelectedIndex == 1)
            { qer += $"where {search} like '%[{textBox1Search.Text}]%'"; }//для цифр
            else
            { qer += $"where {search} like '%{textBox1Search.Text}%'"; }//для строк



            SqlCommand com = new SqlCommand(qer, database.getConnaction());
            try
            {
                database.openConnection();
                SqlDataReader read = com.ExecuteReader();
                while (read.Read())
                {
                    ReadSingleRow(dgw, read);
                }
                read.Close();
            }
            catch { }
        }



        private string whereSearch()
        {
            string s = $"";
            switch (comboBox1search.SelectedIndex)
            {
                case 0://all
                    s = $"concat(Код_сотрудника,Фамилия,Имя,Отчество,email)";
                    break;
                case 1:
                    s = $"Код_сотрудника";
                    break;
                case 2:
                    s = $"Фамилия";
                    break;
                case 3:
                    s = $"Имя";
                    break;
                case 4:
                    s = $"Отчество";
                    break;
                case 5:
                    s = $"email";
                    break;
            }
            return s;
        }
    }
}
