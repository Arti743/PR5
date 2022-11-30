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
using Microsoft.VisualBasic;

namespace Guide_to_Teyvat
{
    public partial class Table_Char : Form
    {
        DataSet data;
        SqlDataAdapter adap;
        SqlCommandBuilder command;
        string connectionString = @"Data Source=192.168.0.7, 3306; Initial Catalog=Genshin_Info; Integrated Security=True";
        string sql = "SELECT * FROM Characters";
        public Table_Char()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adap = new SqlDataAdapter(sql, connection);

                data = new DataSet();
                adap.Fill(data);
                dataGridView1.DataSource = data.Tables[0];
            }
        }

        void openchild(Panel pen, Form empryF)
        {
            empryF.TopLevel = false;
            empryF.FormBorderStyle = FormBorderStyle.None;
            empryF.Dock = DockStyle.Fill;
            pen.Controls.Add(empryF);
            empryF.BringToFront();
            empryF.Show();
        }

        private void button_Admin_Click(object sender, EventArgs e)
        {
            string result = Microsoft.VisualBasic.Interaction.InputBox("Enter Administrator password:");

            if(result != "F8O1R9M3E1R4O5R")
            {
                MessageBox.Show("Invalid password!");
            }
            else
            {
                button_Admin.Visible = false;
                button_Save.Visible = true;
                button_Add.Visible = true;
                button_Del.Visible = true;
                button_Update.Visible = true;
                MessageBox.Show("Password is correct.");
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                {
                    connection.Open();
                    adap = new SqlDataAdapter(sql, connection);
                    command = new SqlCommandBuilder(adap);
                    adap.InsertCommand = new SqlCommand("ADD_Char", connection);
                    adap.InsertCommand.CommandType = CommandType.StoredProcedure;
                    adap.InsertCommand.Parameters.Add(new SqlParameter("@Name_Char", SqlDbType.VarChar, 75, "Name_Char"));
                    adap.InsertCommand.Parameters.Add(new SqlParameter("@Gender_Char", SqlDbType.Int, 0, "Gender_Char"));
                    adap.InsertCommand.Parameters.Add(new SqlParameter("@Eye_of_God", SqlDbType.Int, 0, "Eye_of_God"));
                    adap.InsertCommand.Parameters.Add(new SqlParameter("@Weapon", SqlDbType.VarChar, 50, "Weapon"));
                    adap.InsertCommand.Parameters.Add(new SqlParameter("@Rarity", SqlDbType.VarChar, 15, "Rarity"));
                    adap.InsertCommand.Parameters.Add(new SqlParameter("@Region", SqlDbType.VarChar, 80, "Region"));
                    adap.InsertCommand.Parameters.Add(new SqlParameter("@Version_game", SqlDbType.VarChar, 15, "Version_game"));


                    adap.Update(data);
                }
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            DataRow row = data.Tables[0].NewRow();
            data.Tables[0].Rows.Add(row);
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            openchild(panel1, new Table_Char());
        }

        private void button_Del_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        //Тут будет реализована функция фильтрации по столбцам
        private void Table_Char_Load(object sender, EventArgs e)
        {
            //данная строка кода позволяет загрузить данные в таблицу.
            this.charactersTableAdapter.Fill(this.genshin_InfoDataSet.Characters);
        }
        private void comboBox1_TextChanged_1(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = sql = "SELECT * FROM Character WHERE Eye_of_God IN ('1')";
        }
    }
}
