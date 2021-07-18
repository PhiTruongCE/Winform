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

namespace PhoneDictionary
{
    public partial class Form1 : Form
    {
        int index = -1;
        SqlConnection connection;
        SqlCommand command;
        string connect = @"Data Source=DESKTOP-MGN3IP8;Initial Catalog=PhoneBookDB;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string Status = "";
        #region Method
        void LoadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from PhoneBook";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataView.DataSource = table;
            FullName.Enabled = PhoneNumber.Enabled = Email.Enabled = Address.Enabled = Search.Enabled = svbtn.Enabled = cancelbtn.Enabled = false;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connect);
            connection.Open();
            LoadData();
        }
        #endregion

        #region Event
        void Clear()
        {
            FullName.Text = "";
            PhoneNumber.Text = "";
            Email.Text = "";
            Address.Text = "";
            Search.Text = "";
            FullName.Enabled = PhoneNumber.Enabled = Email.Enabled = Address.Enabled = Search.Enabled = false;
        }
        private void dataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FullName.Enabled = PhoneNumber.Enabled = Email.Enabled = Address.Enabled = true;
            index = dataView.CurrentRow.Index;
            FullName.Text = dataView.Rows[index].Cells[0].Value.ToString();
            PhoneNumber.Text = dataView.Rows[index].Cells[1].Value.ToString();
            Email.Text = dataView.Rows[index].Cells[2].Value.ToString();
            Address.Text = dataView.Rows[index].Cells[3].Value.ToString();
        }
        private void insbtn_Click(object sender, EventArgs e)
        {
            FullName.Enabled = PhoneNumber.Enabled = Email.Enabled = Address.Enabled = svbtn.Enabled = cancelbtn.Enabled = true;
            Status = "Insert";
        }
        private void delbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phone Number deleted!", "Notification!");
            Status = "Delete";
            command = connection.CreateCommand();
            command.CommandText = "delete from PhoneBook where  Phone = '" + PhoneNumber.Text + "'";
            command.ExecuteNonQuery();
            LoadData();
            Clear();
        }
        private void edtbtn_Click(object sender, EventArgs e)
        {
            cancelbtn.Enabled = true;
            command = connection.CreateCommand();
            command.CommandText = "update PhoneBook set Phone = '" + PhoneNumber.Text + "', Email = '" + Email.Text + "', Address ='" + Address.Text + "' where Name = '" + FullName.Text + "'";
            command.ExecuteNonQuery();
            LoadData();
        }
        private void svbtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(PhoneNumber.Text, out int result))
            {
                if (Status == "Insert")
                {
                    MessageBox.Show("Phone Number inserted!", "Notificaltion!");
                    command = connection.CreateCommand();
                    command.CommandText = "insert into PhoneBook values('" + FullName.Text + "','" + PhoneNumber.Text + "','" + Email.Text + "','" + Address.Text + "')";
                    command.ExecuteNonQuery();
                    LoadData();

                    Clear();
                }
            }
            else MessageBox.Show("Phone Number Wrong!", "Notificaltion!");
        }
        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Clear();
            Status = "";
            svbtn.Enabled = cancelbtn.Enabled = Search.Enabled = false;
        }
        private void srchbtn_Click(object sender, EventArgs e)
        {
            Search.Enabled = cancelbtn.Enabled = true;
        }
        private void Search_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(table);
            DV.RowFilter = string.Format("Name LIKE '%{0}%' OR Phone LIKE '%{0}%'", Search.Text);
            dataView.DataSource = DV;            
        }
        #endregion
    }
}
