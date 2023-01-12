using Sibers_project;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sibers_project
{
    public class MyComboboxMethods
    {
        DataBaseConnection database = new DataBaseConnection();



        #region Fill combobox
        private DataTable littleQuer(string s)
        {
            database.openConnection();
            var comm = new SqlCommand(s, database.getConnaction()); //создаем команду
            var table = new DataTable();//данные будут записаны в этот объект DataTable 
            var adapter = new SqlDataAdapter(comm); //создаем адаптер
            adapter.Fill(table); //заполняем DataTable
            database.closeConnection();
            return table;
        }

        /// <summary>
        /// in comboBox add result SQL quer ;
        /// cbFiller.Fill(comboBox2_Doer,commText, "название_компании_исполнителя", "код_исполнителя");
        /// будет видно название а не код;
        /// 
        /// использовать в comboBox_DropDown
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="commText"></param>
        /// <param name="strVisible"></param>
        /// <param name="strNotvisible"></param>
        public void Fill(ComboBox comboBox, string commText, string strVisible, string strNotvisible)
        {
            var table = littleQuer(commText);
            comboBox.DisplayMember = strVisible; //отображаемое поле (данные из поля будут отображаться в комбобоксе)
            comboBox.ValueMember = strNotvisible; //поле-значение (данные из этого поля будут записываться в свойство SelectedValue)
            comboBox.DataSource = table; //устанавливаем для комбобокса источник данных}
        }
        #endregion



        #region Search in combobox
        /// <summary>
        /// search in combobox;
        /// use in KeyPress
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="e"></param>
        public void SearchInCombobox(ComboBox comboBox, KeyPressEventArgs e)
        {
            comboBox.DroppedDown = true;
            if (char.IsControl(e.KeyChar))
            { return; }
            string str = comboBox.Text.Substring(0, comboBox.SelectionStart) + e.KeyChar;

            Int32 index = comboBox.FindStringExact(str);
            if (index == -1)
            {
                index = comboBox.FindString(str);
            }
            comboBox.SelectedIndex = index;
            comboBox.SelectionStart = str.Length;
            comboBox.SelectionLength = comboBox.Text.Length - comboBox.SelectionStart;
            e.Handled = true;
        }
        #endregion







        public void IdToName(TextBoxBase textBox, string qer)
        {
            SqlCommand command = new SqlCommand(qer, database.getConnaction());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                textBox.Text = reader.GetString(0);
            }
            reader.Close();
            database.closeConnection();
        }


    }
}

