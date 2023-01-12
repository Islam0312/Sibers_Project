using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sibers_project
{
    public partial class Projects : Form
    {
        DataBaseConnection database = new DataBaseConnection(); //строка подключения к бд
        MyComboboxMethods MyCbMethods = new MyComboboxMethods();
        MySQLconstructs mySQLconstructs = new MySQLconstructs();
        int selectedrow;

        public Projects()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            comboBox1_action.KeyPress += OnKeyPress;
            comboBox1search.KeyPress += OnKeyPress;
            label1_id.Visible = false;
            textBox1project_id.Visible = false;

            dtfrmt(dateTimePicker1START);
            dtfrmt(dateTimePicker2END);
            dtfrmt(dateTimePickerBetweenStart);
            dtfrmt(dateTimePickerBetweenEnd);

            dateTimePickerBetweenStart.Visible = false;
            dateTimePickerBetweenEnd.Visible = false;
            label3BetweenStart.Visible = false;
            label4BetweenEnd.Visible = false;
        }
        void OnKeyPress(object sender, KeyPressEventArgs e) { e.Handled = true; }//for untouchable comboboxs


        //устанавливаем формат даты
        private void dtfrmt(DateTimePicker dt)
        {
            dt.CustomFormat = "dd/MM/yyyy";
            dt.Format = DateTimePickerFormat.Custom;
        }


        private void Projects_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefrashDataGrid(dataGridView1);

            //заполняет комбобокс данными из бд
            string commText = "select код_заказчика,название_компании_заказчика from Сustomers"; //читать все данные из таблицы Table
            SqlCommand comm = new SqlCommand(commText, database.getConnaction()); //создаем команду
            DataTable table = new DataTable();//данные будут записаны в этот объект DataTable 
            SqlDataAdapter adapter = new SqlDataAdapter(comm); //создаем адаптер
            adapter.Fill(table); //заполняем DataTable
            comboBox1_cust.DisplayMember = "название_компании_заказчика"; //отображаемое поле (данные из поля будут отображаться в комбобоксе)
            comboBox1_cust.ValueMember = "код_заказчика"; //поле-значение (данные из этого поля будут записываться в свойство SelectedValue)
            comboBox1_cust.DataSource = table; //устанавливаем для комбобокса источник данных

            commText = "select код_исполнителя,название_компании_исполнителя from Doer"; //читать все данные из таблицы Table
            comm = new SqlCommand(commText, database.getConnaction()); //создаем команду
            table = new DataTable();//данные будут записаны в этот объект DataTable 
            adapter = new SqlDataAdapter(comm); //создаем адаптер
            adapter.Fill(table); //заполняем DataTable
            comboBox2_Doer.DisplayMember = "название_компании_исполнителя"; //отображаемое поле (данные из поля будут отображаться в комбобоксе)
            comboBox2_Doer.ValueMember = "код_исполнителя"; //поле-значение (данные из этого поля будут записываться в свойство SelectedValue)
            comboBox2_Doer.DataSource = table; //устанавливаем для комбобокса источник данных
        }


        private void CreateColumns()
        {
            dataGridView1.Columns.Add("Код_проекта", "Код проекта");
            dataGridView1.Columns.Add("Название_проекта", "Название проекта");

            dataGridView1.Columns.Add("название_компании_заказчика", "заказчик");
            dataGridView1.Columns.Add("название_компании_исполнителя", "Исполнитель");

            dataGridView1.Columns.Add("Дата_Начала_проекта", "Дата начала");
            dataGridView1.Columns.Add("Дата_окончания_проекта", "Дата окончания");

            dataGridView1.Columns.Add("Приоритет_проекта", "Приоритет");
            dataGridView1.Columns.Add("Фамилия", "Фамилия");
            dataGridView1.Columns.Add("Имя", "Имя");
            dataGridView1.Columns.Add("Отчество", "Отчество");
            dataGridView1.Columns.Add("email", "email");

            dataGridView1.Columns.Add("роль_сотрудника", "роль сотрудника");
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add
                (record.GetInt32(0),//code
                record.GetString(1),//Название_проекта

                record.GetString(2),//название_компании_заказчика
                record.GetString(3),//название_компании_исполнителя

                record.GetDateTime(4),//Дата_Начала_проекта
                record.GetDateTime(5),//Дата_окончания_проекта

                record.GetInt32(6),//Приоритет_проекта
                record.GetString(7),//Фамилия
                record.GetString(8),//Имя
                record.GetString(9),//Отчество
                record.GetString(10),//email

                record.GetInt32(11)//роль
                );
        }
        private void RefrashDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string qer = $"	SELECT  dbo.Projects.Код_проекта,dbo.Projects.Название_проекта," +
                $"dbo.Сustomers.название_компании_заказчика," +
                $" dbo.Doer.название_компании_исполнителя," +
                $"dbo.Projects.Дата_Начала_проекта, dbo.Projects.Дата_окончания_проекта,dbo.Projects.Приоритет_проекта," +
                $"dbo.Employees.Фамилия,dbo.Employees.Имя, dbo.Employees.Отчество,dbo.Employees.email, dbo.RecordsPrEm.роль_сотрудника " +
                $"FROM            dbo.Doer INNER JOIN " +
                $"dbo.Projects ON dbo.Doer.код_исполнителя = dbo.Projects.код_исполнителя INNER JOIN dbo.RecordsPrEm ON " +
                $"dbo.Projects.Код_проекта = dbo.RecordsPrEm.Код_проекта INNER JOIN " +
                $"dbo.Employees ON dbo.RecordsPrEm.Код_сотрудника = dbo.Employees.Код_сотрудника INNER JOIN dbo.Сustomers ON " +
                $"dbo.Projects.код_заказчика = dbo.Сustomers.код_заказчика ";

            SqlCommand com = new SqlCommand(qer, database.getConnaction());

            database.openConnection();

            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }




        //данные из dataGridView1 копируем в текст боксы
        #region 
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedrow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedrow];
                textBox1project_id.Text = row.Cells[0].Value.ToString();
                textBox1NameProj.Text = row.Cells[1].Value.ToString();
                comboBox1_cust.Text = row.Cells[2].Value.ToString();
                comboBox2_Doer.Text = row.Cells[3].Value.ToString();
                dateTimePicker1START.Text = row.Cells[4].Value.ToString();
                dateTimePicker2END.Text = row.Cells[5].Value.ToString();
                textBox1Priority.Text = row.Cells[6].Value.ToString();
            }
        }
        #endregion




        #region ссылки на формы
        private void button2_Click(object sender, EventArgs e)
        { new Employee_Form().Show(); }
        private void button_customers_Click(object sender, EventArgs e)
        { new Form3_Customer().Show(); }
        private void button_doers_Click(object sender, EventArgs e)
        { new Form4_doer().Show(); }
        private void button_records_Click(object sender, EventArgs e)
        { new Form5_record().Show(); }
        #endregion



        //обновить
        private void button1_Click(object sender, EventArgs e)
        {
            RefrashDataGrid(dataGridView1);
        }

        //вывести проекты где назначены руководители
        private void button1сРуководителями_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string qer = $"	SELECT  dbo.Projects.Код_проекта,dbo.Projects.Название_проекта," +
                $"dbo.Сustomers.название_компании_заказчика," +
                $" dbo.Doer.название_компании_исполнителя," +
                $"dbo.Projects.Дата_Начала_проекта, dbo.Projects.Дата_окончания_проекта,dbo.Projects.Приоритет_проекта," +
                $"dbo.Employees.Фамилия,dbo.Employees.Имя, dbo.Employees.Отчество,dbo.Employees.email, dbo.RecordsPrEm.роль_сотрудника  " +
                $"FROM            dbo.Doer INNER JOIN " +
                $"dbo.Projects ON dbo.Doer.код_исполнителя = dbo.Projects.код_исполнителя INNER JOIN dbo.RecordsPrEm ON " +
                $"dbo.Projects.Код_проекта = dbo.RecordsPrEm.Код_проекта INNER JOIN " +
                $"dbo.Employees ON dbo.RecordsPrEm.Код_сотрудника = dbo.Employees.Код_сотрудника INNER JOIN dbo.Сustomers ON " +
                $"dbo.Projects.код_заказчика = dbo.Сustomers.код_заказчика " +
                $"WHERE dbo.RecordsPrEm.роль_сотрудника = 2";
            SqlCommand com = new SqlCommand(qer, database.getConnaction());
            database.openConnection();
            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dataGridView1, reader);
            }
            reader.Close();
        }


        private void button1_save_Click(object sender, EventArgs e)
        {
            string quer = $"";
            int id;
            string name_proj = textBox1NameProj.Text == "" ? "NULL" : textBox1NameProj.Text;
            string name_cust = "NULL";
            string name_doer = "NULL";
            string dtStart = dateTimePicker1START.Text;
            string dtEnd = dateTimePicker2END.Text;
            int prior;
            bool access = true;


            //если таблицы (cust или doer) будут пусты то:
            if (comboBox1_cust.SelectedValue == null || comboBox2_Doer.SelectedValue == null)
            { MessageBox.Show("заполните разделы заказчики и исполнители", "!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else
            {
                try
                {
                    name_cust = comboBox1_cust.SelectedValue.ToString();
                    name_doer = comboBox2_Doer.SelectedValue.ToString();
                }
                catch { MessageBox.Show("что-то не так в\ncomboBox1_cust\ncomboBox2_Doer", "!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }



            switch (comboBox1_action.SelectedIndex)
            {
                case 0://add
                    {
                        if (int.TryParse(textBox1Priority.Text, out prior))
                        {
                            quer = $"insert into Projects" +
                                $"(Название_проекта,код_заказчика,код_исполнителя,Дата_Начала_проекта,Дата_окончания_проекта,Приоритет_проекта) " +
                                $"values ('{name_proj}',{name_cust},{name_doer},'{dtStart}','{dtEnd}',{prior})";
                            break;
                        }
                        else
                        {
                            MessageBox.Show("надо заполнить поле \"приоритет\"", "!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            access = false;
                            break;
                        }
                    }
                case 1://update
                    {
                        if (int.TryParse(textBox1project_id.Text, out id))
                        {
                            if (int.TryParse(textBox1Priority.Text, out prior))
                            {
                                quer = $"UPDATE Projects set" +
                                    $" Название_проекта = '{name_proj}'," +
                                    $"название_компании_заказчика={name_cust}," +
                                    $"название_компании_исполнителя={name_doer}," +
                                    $"Дата_Начала_проекта='{dtStart}'," +
                                    $"Дата_окончания_проекта='{dtEnd}'," +
                                    $"Приоритет_проекта={prior}" +
                                    $" WHERE Код_проекта={id};";
                            }
                            else
                            {
                                MessageBox.Show("надо заполнить поле \"приоритет\"", "!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                access = false;
                                break;
                            }
                            break;
                        }
                        else { access = false; }
                        break;
                    }

                case 2://delete
                    {
                        //if all correct
                        if (int.TryParse(textBox1project_id.Text, out id))
                        {
                            quer = $"delete from RecordsPrEm where Код_проекта={id}";
                            if (access) { mySQLconstructs.qerr(quer); }
                            quer = $"delete FROM Projects where Код_проекта={id};";
                        }

                        //if void text
                        if (textBox1project_id.Text == "")
                        {
                            MessageBox.Show("поле \"код\" надо заполнить", "!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        //if not a number
                        try { id = int.Parse(textBox1project_id.Text); }
                        catch
                        {
                            MessageBox.Show("код должен быть числом", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            access = false;
                        }
                        break;
                    }
            }
            if (access) { mySQLconstructs.qerr(quer); }
            RefrashDataGrid(dataGridView1);
        }




        //скрываем поля в зависимости от действия
        private void comboBox1_action_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1_action.SelectedIndex == 0)//add
            {
                textBox1project_id.Visible = false;
                label1_id.Visible = false;

                textBox1NameProj.Visible = true;
                label2_NameProj.Visible = true;

                comboBox1_cust.Visible = true;
                label4_NameDoer.Visible = true;


                comboBox2_Doer.Visible = true;
                label3_NameCust.Visible = true;

                textBox1Priority.Visible = true;
                label5_Priority.Visible = true;

                textBox1project_id.Text = "";
            }
            else if (comboBox1_action.SelectedIndex == 1)//update
            {
                textBox1project_id.Visible = true;
                label1_id.Visible = true;

                textBox1NameProj.Visible = true;
                label2_NameProj.Visible = true;

                comboBox1_cust.Visible = true;
                label4_NameDoer.Visible = true;

                comboBox2_Doer.Visible = true;
                label3_NameCust.Visible = true;

                textBox1Priority.Visible = true;
                label5_Priority.Visible = true;
            }
            else if (comboBox1_action.SelectedIndex == 2)//delete
            {
                textBox1project_id.Visible = true;
                label1_id.Visible = true;

                textBox1NameProj.Visible = false;
                label2_NameProj.Visible = false;

                comboBox1_cust.Visible = false;
                label4_NameDoer.Visible = false;


                comboBox2_Doer.Visible = false;
                label3_NameCust.Visible = false;

                textBox1Priority.Visible = false;
                label5_Priority.Visible = false;

                dateTimePicker1START.Visible = false;
                dateTimePicker2END.Visible = false;
            }
        }



        #region даты
        //ограничиваем даты, чтобы конец не был раньше начала
        private void dateTimePicker1START_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1START.Value > dateTimePicker2END.Value)
            {
                dateTimePicker2END.Value = dateTimePicker1START.Value;
            }
        }

        private void dateTimePicker2END_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker2END.Value < dateTimePicker1START.Value)
            {
                dateTimePicker2END.Value = dateTimePicker1START.Value;
                MessageBox.Show("дата окончания проекта \nне может быть раньше \nдаты начала проекта", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        #endregion






        #region combobox (cust and doer)
        //заполняем комбобоксы (cust and doer)
        private void comboBox1_cust_DropDown(object sender, EventArgs e)
        {
            string commText = "select код_заказчика,название_компании_заказчика from Сustomers";
            MyCbMethods.Fill(comboBox1_cust, commText, "название_компании_заказчика", "код_заказчика");
        }
        private void comboBox2_Doer_DropDown(object sender, EventArgs e)
        {
            string commText = "select код_исполнителя,название_компании_исполнителя from Doer";
            MyCbMethods.Fill(comboBox2_Doer, commText, "название_компании_исполнителя", "код_исполнителя");
        }

        //поиск (cust and doer)
        private void comboBox1_cust_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyCbMethods.SearchInCombobox(comboBox1_cust, e);
        }
        private void comboBox2_Doer_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyCbMethods.SearchInCombobox(comboBox2_Doer, e);
        }
        #endregion





        //помощь
        private void button1Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для корректной работы необходимо:" +
                "1)заполнить разделы (Сотрудники, Заказчики, Исполнители)\n" +
                "2)заполнить все поля в разделе (Проекты)\n" +
                "3)открыть раздел \"Назначение\" и определить сотрудников или руководителя на проект\n" +
                "4)в разделе (Проекты) нажать кнопку \"Обновить\"\n\n" +
                "вы можете нажать на определенную строку и вся строка перепишется в поля для редактирования\n\n" +
                "для сортировки нажмите на название столбца",
                "Справка проекты", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }








        //поиск по столбцам
        private void textBox1Search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }
        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();


            string search = whereSearch();

            int cb = comboBox1search.SelectedIndex;

            string qer = $"SELECT  dbo.Projects.Код_проекта,dbo.Projects.Название_проекта," +
                $"dbo.Сustomers.название_компании_заказчика," +
                $" dbo.Doer.название_компании_исполнителя," +
                $"dbo.Projects.Дата_Начала_проекта, dbo.Projects.Дата_окончания_проекта,dbo.Projects.Приоритет_проекта," +
                $"dbo.Employees.Фамилия,dbo.Employees.Имя, dbo.Employees.Отчество,dbo.Employees.email, dbo.RecordsPrEm.роль_сотрудника " +
                $"FROM            dbo.Doer INNER JOIN " +
                $"dbo.Projects ON dbo.Doer.код_исполнителя = dbo.Projects.код_исполнителя INNER JOIN dbo.RecordsPrEm ON " +
                $"dbo.Projects.Код_проекта = dbo.RecordsPrEm.Код_проекта INNER JOIN " +
                $"dbo.Employees ON dbo.RecordsPrEm.Код_сотрудника = dbo.Employees.Код_сотрудника INNER JOIN dbo.Сustomers ON " +
                $"dbo.Projects.код_заказчика = dbo.Сustomers.код_заказчика ";
            if (comboBox1search.SelectedIndex == 1 || comboBox1search.SelectedIndex == 7 || comboBox1search.SelectedIndex == 12)
            { qer += $"where {search} like '%[{textBox1Search.Text}]%'"; }//для цифр
            else if (cb==0 || cb > 1 & cb < 7 || cb > 7 & cb < 12)
            { qer += $"where {search} like '%{textBox1Search.Text}%'"; }//для строк
            else { }

            qerWithRead(qer, dataGridView1);
        }
        private void qerWithRead(string qer, DataGridView dgw)
        {
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
            catch {
                //MessageBox.Show("44") ; 
            }
        }

        private string whereSearch()//выбираем по какому полю выполнять поиск
        {
            string s = $"";
            switch (comboBox1search.SelectedIndex)
            {
                case 0://all
                    s = $"concat(dbo.Projects.Код_проекта,dbo.Projects.Название_проекта," +
            $"dbo.Сustomers.название_компании_заказчика, dbo.Doer.название_компании_исполнителя," +
            $"dbo.Projects.Дата_Начала_проекта, dbo.Projects.Дата_окончания_проекта,dbo.Projects.Приоритет_проекта," +
            $"dbo.Employees.Фамилия,dbo.Employees.Имя, dbo.Employees.Отчество,dbo.Employees.email, dbo.RecordsPrEm.роль_сотрудника)";
                    break;
                case 1:
                    s = $"Код_проекта";
                    break;
                case 2:
                    s = $"Название_проекта";
                    break;
                case 3:
                    s = $"название_компании_заказчика";
                    break;
                case 4:
                    s = $"название_компании_исполнителя";
                    break;
                case 5:
                    s = $"Дата_Начала_проекта";
                    break;
                case 6:
                    s = $"Дата_окончания_проекта";
                    break;
                case 7:
                    s = $"Приоритет_проекта";
                    break;
                case 8:
                    s = $"Фамилия";
                    break;
                case 9:
                    s = $"Имя";
                    break;
                case 10:
                    s = $"Отчество";
                    break;
                case 11:
                    s = $"email";
                    break;
                case 12:
                    s = $"роль_сотрудника";
                    break;
            }
            return s;
        }




        #region диапозон дат
        private void dateTimePickerBetweenStart_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerBetweenStart.Value > dateTimePickerBetweenEnd.Value)
            {
                dateTimePickerBetweenEnd.Value = dateTimePickerBetweenStart.Value;
            }
            betweenDT(dataGridView1);
        }
        private void dateTimePickerBetweenEnd_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerBetweenEnd.Value < dateTimePickerBetweenStart.Value)
            {
                dateTimePickerBetweenEnd.Value = dateTimePickerBetweenStart.Value;
                MessageBox.Show("дата окончания проекта \nне может быть раньше \nдаты начала проекта", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            betweenDT(dataGridView1);
        }


        private void betweenDT(DataGridView dgw)
        {

            dgw.Rows.Clear();


            int cb = comboBox1search.SelectedIndex;

            string qer = $"SELECT  dbo.Projects.Код_проекта,dbo.Projects.Название_проекта," +
                $"dbo.Сustomers.название_компании_заказчика," +
                $" dbo.Doer.название_компании_исполнителя," +
                $"dbo.Projects.Дата_Начала_проекта, dbo.Projects.Дата_окончания_проекта,dbo.Projects.Приоритет_проекта," +
                $"dbo.Employees.Фамилия,dbo.Employees.Имя, dbo.Employees.Отчество,dbo.Employees.email, dbo.RecordsPrEm.роль_сотрудника " +
                $"FROM            dbo.Doer INNER JOIN " +
                $"dbo.Projects ON dbo.Doer.код_исполнителя = dbo.Projects.код_исполнителя INNER JOIN dbo.RecordsPrEm ON " +
                $"dbo.Projects.Код_проекта = dbo.RecordsPrEm.Код_проекта INNER JOIN " +
                $"dbo.Employees ON dbo.RecordsPrEm.Код_сотрудника = dbo.Employees.Код_сотрудника INNER JOIN dbo.Сustomers ON " +
                $"dbo.Projects.код_заказчика = dbo.Сustomers.код_заказчика ";
            qer += $"where Дата_Начала_проекта BETWEEN '{dateTimePickerBetweenStart.Text}' AND '{dateTimePickerBetweenEnd.Text}'" +
                $"or Дата_окончания_проекта BETWEEN '{dateTimePickerBetweenStart.Text}' AND '{dateTimePickerBetweenEnd.Text}';";

            qerWithRead(qer, dataGridView1);
        }
        
        private void comboBox1search_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1search.SelectedIndex == 13)//поиск по диапозону дат
            {
                textBox1Search.Visible=false;
                dateTimePickerBetweenStart.Visible=true;
                dateTimePickerBetweenEnd.Visible = true;
                label3BetweenStart.Visible = true;
                label4BetweenEnd.Visible = true;
            }
            else 
            {
                textBox1Search.Visible = true;
                dateTimePickerBetweenStart.Visible = false;
                dateTimePickerBetweenEnd.Visible = false;
                label3BetweenStart.Visible = false;
                label4BetweenEnd.Visible = false;
            }
        }
#endregion


    }
}