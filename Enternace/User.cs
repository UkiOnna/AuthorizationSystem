using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enternace
{
    public class User
    {
        private string _name;
        private string _firstName;
        public string _email;
        public string _phoneNumber;
        public string _password;

        public void SetName(string name)
        {
            _name = name;
        }
        public string GetName()
        {
            return _name;
        }

        public void SetFirstNAme(string firstName)
        {
            _firstName = firstName;
        }
        public string GetFirstName()
        {
            return _firstName;
        }

        public void SetEmail(string email)
        {
            _email = email;
        }
        public string GetEmail()
        {
            return _email;
        }

        public void SetNumber(string number)
        {
            _phoneNumber = number;
        }
        public string GetNumber()
        {
            return _phoneNumber;
        }

        public void SetPassword(string password)
        {
            _password = password;
        }
        public string GetPassword()
        {
            return _password;
        }


    }
}
