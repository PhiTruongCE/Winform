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

namespace PhoneBook
{
    public partial class PhoneBook : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-MGN3IP8;Initial Catalog=PhoneBookDB;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {

        }

        string Status = "";
        int Index = -1;
        int IndexSearch = -1;
        DataTable datatableWrite = new DataTable();
        DataSet dataSetWrite = new DataSet();
        public PhoneBook()
        {
            InitializeComponent();
        }
        DataTable CreateDataTable()
        {
            DataTable dataTable = new DataTable();

            DataColumn colFullName = new DataColumn("Full Name");
            DataColumn colPhoneNumber = new DataColumn("Phone Number");
            DataColumn colEmail = new DataColumn("Email");
            DataColumn colAddress = new DataColumn("Address");

            dataTable.Columns.Add(colFullName);
            dataTable.Columns.Add(colPhoneNumber);
            dataTable.Columns.Add(colEmail);
            dataTable.Columns.Add(colAddress);


            return dataTable;
        }

        void WriteXML()
        {

        }

        void CreateColumForDataView()
        {
            var colName = new DataGridViewTextBoxColumn();
            var colNumber = new DataGridViewTextBoxColumn();
            var colEmail = new DataGridViewTextBoxColumn();
            var colAddr = new DataGridViewTextBoxColumn();
            colName.DataPropertyName = "Fullname";
            colNumber.DataPropertyName = "Phonenumb";
            colEmail.DataPropertyName = "Email";
            colAddr.DataPropertyName = "Address";

            colName.HeaderText = "Full Name";       colName.Width = 220;
            colNumber.HeaderText = "Phone Number";  colNumber.Width = 200;
            colEmail.HeaderText = "Email";          colEmail.Width = 200;
            colAddr.HeaderText = "Address";         colAddr.Width = 300;
            dataView.Columns.AddRange(new DataGridViewColumn[] { colName, colNumber, colEmail, colAddr });
        }
        #region Method

        void EnableControl(bool EnableTextBox, bool EnableDataGridView)
        {
            txbName.Enabled = txbPhoneNumb.Enabled = txbEmail.Enabled = txbAddr.Enabled = EnableTextBox;
            dataView.Enabled = EnableDataGridView;
        }

        void LoadListPhoneBook()
        {
            dataView.DataSource = null;
            CreateColumForDataView();
            dataView.DataSource = ListPhoneBook.Instance.ListNumbPhone;
            dataView.Refresh();
        }

        private void PhoneBook_Load(object sender, EventArgs e)
        {
            EnableControl(false, true);
            CreateColumForDataView();
            LoadListPhoneBook();
            SearchNumb.Enabled = false;
            SaveBtn.Enabled = CancelBtn.Enabled = false;
        }
        void ClearTextBox()
        {
            Status = "";
            txbName.Text = "";
            txbPhoneNumb.Text = "";
            txbEmail.Text = "";
            txbAddr.Text = "";
            txbName.Enabled = txbPhoneNumb.Enabled = txbEmail.Enabled = txbAddr.Enabled = false;
        }
        bool CheckInput()
        {
            if(txbPhoneNumb.Text == "" || txbName.Text == "")
            {
                MessageBox.Show("Please enter phone number and full name!", "Error!");
                return false;
            }
            long result;
            if(!long.TryParse(txbPhoneNumb.Text,out result))
            {
                MessageBox.Show("Phone number wrong!", "Error!");
                return false;
            }
            return true;
        }
        #endregion

        #region Event
        
        private void Insbtn_Click(object sender, EventArgs e)
        {
           Status = "Insert";
            Edtbtn.Enabled = Delbtn.Enabled = false;
            SaveBtn.Enabled = CancelBtn.Enabled = true;
            EnableControl(true, false);
        }
        private void Delbtn_Click(object sender, EventArgs e)
        {
            if (Index < 0)
            {
                MessageBox.Show("Please! Choose a element for edit!", "Error!");
            }
            ListPhoneBook.Instance.ListNumbPhone.RemoveAt(Index);
            ClearTextBox();
            LoadListPhoneBook();
        }
        private void Edtbtn_Click(object sender, EventArgs e)
        {
            txbName.Enabled = txbPhoneNumb.Enabled = txbEmail.Enabled = txbAddr.Enabled = true;
            if (Index < 0)
            {
                MessageBox.Show("Please! Choose a element for edit!", "Error!");
            }
            Status = "Edit";
            Insbtn.Enabled = Delbtn.Enabled = false;
            SaveBtn.Enabled = CancelBtn.Enabled = true;
            txbName.Text = ListPhoneBook.Instance.ListNumbPhone[Index].Fullname;
            txbPhoneNumb.Text = ListPhoneBook.Instance.ListNumbPhone[Index].Phonenumb;
            txbEmail.Text = ListPhoneBook.Instance.ListNumbPhone[Index].Email;
            txbAddr.Text = ListPhoneBook.Instance.ListNumbPhone[Index].Address;
            EnableControl(true, false);
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) return;
            if (Status == "Insert") ListPhoneBook.Instance.ListNumbPhone.Add(new PhoneBook1(txbName.Text, txbPhoneNumb.Text, txbEmail.Text, txbAddr.Text));
            if (Status == "Edit") 
            {
                ListPhoneBook.Instance.ListNumbPhone[Index].Fullname = txbName.Text;
                ListPhoneBook.Instance.ListNumbPhone[Index].Phonenumb = txbPhoneNumb.Text;
                ListPhoneBook.Instance.ListNumbPhone[Index].Email = txbEmail.Text;
                ListPhoneBook.Instance.ListNumbPhone[Index].Address = txbAddr.Text;
            }
            SaveBtn.Enabled = CancelBtn.Enabled = SearchNumb.Enabled = false;
            Insbtn.Enabled = Edtbtn.Enabled = Delbtn.Enabled = true;
            EnableControl(false, true);
            LoadListPhoneBook();
            ClearTextBox();
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            SaveBtn.Enabled = CancelBtn.Enabled = false;
            Insbtn.Enabled = Edtbtn.Enabled = Delbtn.Enabled = true;
            ClearTextBox();
            EnableControl(false, true);
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchNumb.Enabled = true;
            dataView.Enabled = CancelBtn.Enabled =true;
            Insbtn.Enabled = false;
            Status = "Search";
        }
        private void dataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(Status == "Search")
            {
                IndexSearch = e.RowIndex;
                for(var i = 0; i < ListPhoneBook.Instance.ListNumbPhone.Count; i++)
                {
                    if(ListPhoneBook.Instance.ListNumbPhone[i].Fullname == dataView.Rows[IndexSearch].Cells[0].Value.ToString() )
                    {
                        Index = i;
                    }
                }
            }
            else
            {
                Index = e.RowIndex;
            }
            txbName.Text = ListPhoneBook.Instance.ListNumbPhone[Index].Fullname;
            txbPhoneNumb.Text = ListPhoneBook.Instance.ListNumbPhone[Index].Phonenumb;
            txbEmail.Text = ListPhoneBook.Instance.ListNumbPhone[Index].Email;
            txbAddr.Text = ListPhoneBook.Instance.ListNumbPhone[Index].Address;
        }
        private void SearchNumb_TextChanged(object sender, EventArgs e)
        {
            List<PhoneBook1> listSearch = new List<PhoneBook1>();
            foreach(var item in ListPhoneBook.Instance.ListNumbPhone)
            {
                if(item.Phonenumb.Contains(SearchNumb.Text) || item.Fullname.ToLower().Contains(SearchNumb.Text.ToLower()))
                {
                    listSearch.Add(item);
                }
            }
            dataView.DataSource = null;
            CreateColumForDataView();
            dataView.DataSource = listSearch;
        }
        #endregion


    }
}
