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
    public partial class Form5_record : Form
    {
        DataBaseConnection database = new DataBaseConnection();
        MyComboboxMethods MyCbMethods = new MyComboboxMethods();
        int selectedrow;
        public Form5_record()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            textBox1_id.Visible = false;
            label1_id.Visible = false;
            comboBox1_action.KeyPress += OnKeyPress;
            comboBox2_role.KeyPress += OnKeyPress;
            comboBox1search.KeyPress += OnKeyPress;
        }

        //untouchable combobox
        void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefrashDataGrid(dataGridView1);

            string commText = "select Код_сотрудника from Employees";
            MyCbMethods.Fill(comboBoxIdEmp, commText, "Код_сотрудника", "Код_сотрудника");

            commText = "select Код_проекта from Projects";
            MyCbMethods.Fill(comboBoxIdProj, commText, "Код_проекта", "Код_проекта");

        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("код_назначения", "№");
            dataGridView1.Columns.Add("Код_проекта", "код проекта");
            dataGridView1.Columns.Add("Название_проекта", "Название");
            dataGridView1.Columns.Add("Код_сотрудника", "код сотр.");
            dataGridView1.Columns.Add("Фамилия", "Фамилия");
            dataGridView1.Columns.Add("роль_сотрудника", "роль");
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(
                record.GetInt32(0),
                record.GetInt32(1),
                record.GetString(2),
                record.GetInt32(3),
                record.GetString(4),
                record.GetInt32(5)
                );
        }


        
        private void RefrashDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string qer = $"SELECT " +
                $"dbo.RecordsPrEm.код_назначения," +
                $" dbo.RecordsPrEm.Код_проекта," +
                $" dbo.Projects.Название_проекта," +
                $" dbo.RecordsPrEm.Код_сотрудника," +
                $" dbo.Employees.Фамилия," +
                $" dbo.RecordsPrEm.роль_сотрудника" +
                $" FROM dbo.Employees INNER JOIN dbo.RecordsPrEm ON dbo.Employees.Код_сотрудника = dbo.RecordsPrEm.Код_сотрудника INNER JOIN dbo.Projects ON dbo.RecordsPrEm.Код_проекта = dbo.Projects.Код_проекта";
            SqlCommand com = new SqlCommand(qer, database.getConnaction());

            database.openConnection();

            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }



        #region копируем из дата грида в текст боксы
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedrow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedrow];
                textBox1_id.Text= row.Cells[0].Value.ToString();
                textBox1_proj.Text = row.Cells[1].Value.ToString();
                textBox2_emp.Text = row.Cells[3].Value.ToString();
                comboBox2_role.Text = row.Cells[5].Value.ToString();
                if (comboBox2_role.Text == "1")
                { comboBox2_role.Text = "Сотрудник"; }
                else if (comboBox2_role.Text == "2")
                { comboBox2_role.Text = "Руководитель"; }
                else { MessageBox.Show("eror in role", "error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
        #endregion


        
        private void button2_reset_Click(object sender, EventArgs e)
        {
            RefrashDataGrid(dataGridView1);
        }


        private void button1_save_Click(object sender, EventArgs e)
        {
            string quer = $"";
            int id;
            int code_proj ;
            int code_emp ;
            int role = comboBox2_role.SelectedIndex == 1 ? 1:2 ;//1=сотрудник а 2=руководитель по дефолту роль=1
            bool b = true;

            
            switch (comboBox1_action.SelectedIndex)
            {
                case 0://add
                    {
                        if((int.TryParse(comboBoxIdProj.Text,out code_proj)) & (int.TryParse(comboBoxIdEmp.Text, out code_emp))) 
                            {
                            quer = $"insert into RecordsPrEm(Код_проекта,Код_сотрудника,роль_сотрудника) values ({code_proj},{code_emp},{role})";
                            break;
                            }
                        break;
                    }
                case 1://update
                    {
                        if ((int.TryParse(comboBoxIdProj.Text, out code_proj)) & (int.TryParse(comboBoxIdEmp.Text, out code_emp)) & (int.TryParse(textBox1_id.Text, out id)))
                        {
                            quer = $"UPDATE RecordsPrEm set Код_проекта = {code_proj}, Код_сотрудника = {code_emp},роль_сотрудника={role}" +
                                $" WHERE код_назначения={id};";
                        }
                        else { MessageBox.Show("не верные значения", "!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

                        if (comboBoxIdProj.Text == "")
                        {
                            MessageBox.Show("поля \n\"код проекта и код сотрудника\" \nнадо заполнить", "!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                    }

                case 2://delete
                    {
                        //if all correct
                        if (int.TryParse(textBox1_id.Text, out id))
                        {
                            quer = $"delete FROM RecordsPrEm where код_назначения={id};";
                        }
                        else { MessageBox.Show("не верное значение в \"№\"", "!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                        
                        //if void text
                        if (textBox1_proj.Text == "")
                        {
                            MessageBox.Show("поле \"код\" надо заполнить", "!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                    }
            }
            if (b) { qerr(quer); }
            RefrashDataGrid(dataGridView1);
        }


        private void qerr(string qer)
        {
            if (qer != "")
            {
                database.openConnection();
                SqlCommand command = new SqlCommand(qer, database.getConnaction());
                command.ExecuteNonQuery();
                database.closeConnection();
                MessageBox.Show("действие выполнено", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        #region выбор действия
        //в зависимости от действия скрывает поля
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1_action.SelectedIndex == 0)
            {
                textBox1_id.Visible = false;
                label1_id.Visible = false;

                textBox1_proj.Visible = true;
                label1_proj.Visible = true;

                textBox2_emp.Visible = true;
                label2_emp.Visible = true;

                comboBox2_role.Visible = true;
                label3_role.Visible = true;

                comboBoxIdProj.Visible = true;
                comboBoxIdEmp.Visible = true;
                button1.Visible = true;

                textBox1_proj.Text = "";
            }
            else if (comboBox1_action.SelectedIndex == 1)
            {
                textBox1_id.Visible = true;
                label1_id.Visible = true;

                textBox1_proj.Visible = true;
                label1_proj.Visible = true;

                textBox2_emp.Visible = true;
                label2_emp.Visible = true;

                comboBox2_role.Visible = true;
                label3_role.Visible = true;

                comboBoxIdProj.Visible = true;
                comboBoxIdEmp.Visible = true;
                button1.Visible = true;
            }
            else
            {
                textBox1_id.Visible = true;
                label1_id.Visible = true;

                textBox1_proj.Visible = false;
                label1_proj.Visible = false;

                textBox2_emp.Visible = false;
                label2_emp.Visible = false;

                comboBox2_role.Visible = false;
                label3_role.Visible = false;

                comboBoxIdProj.Visible = false;
                comboBoxIdEmp.Visible = false;
                button1.Visible = false;
            }
        }
            #endregion


        #region fill combobox (proj and empl)
        //запонляем комбо боксы
        private void comboBoxIdEmp_DropDown(object sender, EventArgs e)
        {
            string commText = "select Код_сотрудника from Employees";
            MyCbMethods.Fill(comboBoxIdEmp, commText, "Код_сотрудника", "Код_сотрудника");
        }
        private void comboBoxIdProj_DropDown(object sender, EventArgs e)
        {
            string commText = "select Код_проекта from Projects";
            MyCbMethods.Fill(comboBoxIdProj, commText, "Код_проекта", "Код_проекта");
        }

        //поиск
        private void comboBoxIdProj_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyCbMethods.SearchInCombobox(comboBoxIdProj, e);
        }
        private void comboBoxIdEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyCbMethods.SearchInCombobox(comboBoxIdEmp, e);
        }
        #endregion



        //вывести фамилию по коду
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxIdProj.Text != "") 
            {
                string nc = comboBoxIdProj.Text;
                string snc = $"select Название_проекта from Projects where Код_проекта={nc}";

                MyCbMethods.IdToName(textBox1_proj, snc);
            }

            if (comboBoxIdEmp.Text != "") 
            {
                string nc = comboBoxIdEmp.Text;
                string sne = $"select Фамилия from Employees where Код_сотрудника={nc}";

                MyCbMethods.IdToName(textBox2_emp, sne);
            }
        }

        private void button1Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1)выбираем проект и сотрудника из выпадающего списка\n" +
                "2)нажав кнопку \"подробнее\" узнаем название проекта и фамилию сотрудника\n" +
                "3)выбираем ему роль\n" +
                "4)выбираем действие и нажимаем \"Сохранить\"\n\n" +
                "роль 1 = сотрудник \nроль 2 = руководитель\n\n" +
                "вы можете нажать на определенную строку и вся строка перепишется в поля для редактирования\n\n" +
                "для сортировки нажмите на название столбца",
                "Справка Назначение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }








        private void textBox1Search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string search = whereSearch();

            string qer = $"SELECT " +
                $"dbo.RecordsPrEm.код_назначения," +
                $" dbo.RecordsPrEm.Код_проекта," +
                $" dbo.Projects.Название_проекта," +
                $" dbo.RecordsPrEm.Код_сотрудника," +
                $" dbo.Employees.Фамилия," +
                $" dbo.RecordsPrEm.роль_сотрудника" +
                $" FROM dbo.Employees INNER JOIN dbo.RecordsPrEm ON dbo.Employees.Код_сотрудника = dbo.RecordsPrEm.Код_сотрудника INNER JOIN" +
                $" dbo.Projects ON dbo.RecordsPrEm.Код_проекта = dbo.Projects.Код_проекта ";

            if (comboBox1search.SelectedIndex == 1 || comboBox1search.SelectedIndex == 2 || comboBox1search.SelectedIndex == 4 || comboBox1search.SelectedIndex == 6)
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
            catch
            { }
        }

        private string whereSearch()
        {
            string s = $"";
            switch (comboBox1search.SelectedIndex)
            {
                case 0://all
                    s = $"concat(dbo.RecordsPrEm.код_назначения,dbo.RecordsPrEm.Код_проекта,dbo.Projects.Название_проекта,dbo.RecordsPrEm.Код_сотрудника,dbo.Employees.Фамилия,dbo.RecordsPrEm.роль_сотрудника)";
                    break;
                case 1:
                    s = $"dbo.RecordsPrEm.код_назначения";
                    break;
                case 2:
                    s = $"dbo.RecordsPrEm.Код_проекта";
                    break;
                case 3:
                    s = $"dbo.Projects.Название_проекта";
                    break;
                case 4:
                    s = $"dbo.RecordsPrEm.Код_сотрудника";
                    break;
                case 5:
                    s = $"dbo.Employees.Фамилия";
                    break;
                case 6:
                    s = $"dbo.RecordsPrEm.роль_сотрудника";
                    break;
            }
            return s;
        }
    }
}
