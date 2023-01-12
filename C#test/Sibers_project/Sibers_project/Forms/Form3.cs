using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sibers_project
{

    public partial class Form3_Customer : Form
    {
        DataBaseConnection database = new DataBaseConnection();
        MyComboboxMethods MyCbMethods = new MyComboboxMethods();
        int selectedrow;

        public Form3_Customer()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            textBox1_Code.Visible = false;
            label1_Code.Visible = false;
            comboBox1.KeyPress += OnKeyPress;
            comboBox1search.KeyPress += OnKeyPress;
        }

        //untouchable combobox
        void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1_name.MaxLength = 50;
            CreateColumns();
            RefrashDataGrid(dataGridView1);
        }


        private void CreateColumns()
        {
            dataGridView1.Columns.Add("Код_заказчика", "id");
            dataGridView1.Columns.Add("название_компании_заказчика", "Название");
        }


        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(
                record.GetInt32(0),
                record.GetString(1)
                );
        }



        private void RefrashDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string qer = $"select * from Сustomers";

            SqlCommand com = new SqlCommand(qer, database.getConnaction());

            database.openConnection();

            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }



        private void button1_save_Click(object sender, EventArgs e)
        {
            string quer = $"";
            int code_cus = 0;
            var Name = textBox1_name.Text == "" ? "NULL" : textBox1_name.Text;
            bool b = true;


            switch (comboBox1.SelectedIndex)
            {
                case 0://add
                    {
                        quer = $"insert into Сustomers(название_компании_заказчика) values ('{Name}')";
                        break;
                    }
                case 1://update
                    {
                        if (textBox1_Code.Text == "")
                        {
                            MessageBox.Show("поле \"код заказчика\" надо заполнить", "!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        code_cus = int.Parse(textBox1_Code.Text);

                        quer = $"UPDATE Сustomers set название_компании_заказчика='{Name}' WHERE Код_заказчика={code_cus};";
                        break;
                    }

                case 2://delete
                    {
                        if (textBox1_Code.Text == "")
                        {
                            MessageBox.Show("поле \"код заказчика\" надо заполнить", "!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        try { code_cus = int.Parse(textBox1_Code.Text); }
                        catch
                        {
                            MessageBox.Show("код должен быть числом", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            b = false;
                        }
                        quer = $"delete FROM Сustomers where Код_заказчика={code_cus};";
                        break;
                    }
            }
            if (b) { qerr(quer); }
            RefrashDataGrid(dataGridView1);
        }
        private void qerr(string qer)
        {
            database.openConnection();
            var command = new SqlCommand(qer, database.getConnaction());
            command.ExecuteNonQuery();
            database.closeConnection();
            MessageBox.Show("действие выполнено", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_reset_Click(object sender, EventArgs e)
        {
            RefrashDataGrid(dataGridView1);
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedrow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedrow];

                textBox1_Code.Text = row.Cells[0].Value.ToString();
                textBox1_name.Text = row.Cells[1].Value.ToString();
            }
        }


        #region выбор действия
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBox1_Code.Visible = false;
                textBox1_name.Visible = true;
                label1_Code.Visible = false;
                label1_name.Visible = true;

                textBox1_Code.Text = "";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                textBox1_Code.Visible = true;
                textBox1_name.Visible = true;
                label1_Code.Visible = true;
                label1_name.Visible = true;
            }
            else
            {
                textBox1_Code.Visible = true;
                textBox1_name.Visible = false;
                label1_Code.Visible = true;
                label1_name.Visible = false;
            }
        }
        #endregion

        private void button1Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1)запонляем\n" +
                "2)сохраняем\n\n" +
                "вы можете нажать на определенную строку и вся строка перепишется в поля для редактирования\n\n" +
                "для сортировки нажмите на название столбца",
                "Справка Заказчики", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void textBox1Search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }
        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string search = whereSearch();

            string qer = $"SELECT * " +
                $"FROM Сustomers ";
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
                    s = $"concat(Код_заказчика,название_компании_заказчика)";
                    break;
                case 1://коду проекта
                    s = $"Код_заказчика";
                    break;
                case 2://названию проекта
                    s = $"название_компании_заказчика";
                    break;
            }
            return s;
        }
    }
}
