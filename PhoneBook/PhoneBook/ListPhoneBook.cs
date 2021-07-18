using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class ListPhoneBook
    {
        private static ListPhoneBook instance;
        //public static string connectionString = @"Data Source=DESKTOP-MGN3IP8;Initial Catalog=PhoneBookDB;Integrated Security=True";
        public static ListPhoneBook Instance
        {
            get
            {
                if (instance == null) instance = new ListPhoneBook();
                return instance;
            }
            set => instance = value;
        }
        List<PhoneBook1> listNumbPhone;
        public List<PhoneBook1> ListNumbPhone { get => listNumbPhone; set => listNumbPhone = value; }
        private ListPhoneBook()
        {
            listNumbPhone = new List<PhoneBook1>();
            listNumbPhone.Add(new PhoneBook1("Vo Phi Truong1", "0368674463", "phitruong220675@gmail.com", "Loc Ninh, Binh Phuoc"));
            listNumbPhone.Add(new PhoneBook1("Vo Phi Truong2", "0368674463", "phitruong220675@gmail.com", "Loc Ninh, Binh Phuoc"));
            listNumbPhone.Add(new PhoneBook1("Vo Phi Truong3", "0368674463", "phitruong220675@gmail.com", "Loc Ninh, Binh Phuoc"));
            listNumbPhone.Add(new PhoneBook1("Vo Minh Quan", "0910230904", "phitruong220675@gmail.com", "Loc Ninh, Binh Phuoc"));

        }
    }
}
