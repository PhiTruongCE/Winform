using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class PhoneBook1
    {
        private string fullname;
        private string phonenumb;
        private string email;
        private string address;
        public string Fullname { get => fullname; set => fullname = value; }
        public string Phonenumb { get => phonenumb; set => phonenumb = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public PhoneBook1(string fullname, string phonenumb, string email, string address)
        {
            Fullname = fullname;
            Phonenumb = phonenumb;
            Email = email;
            Address = address;
        }
    }
}
