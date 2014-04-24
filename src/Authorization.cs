using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace warehouse_classes
{
    public class Authorization
    {
        private string user;
        private string password;
        private string salt;
        private int userHash;
        
        public Authorization()
        {
            user = null;
            password = null;
            salt = null;
            userHash = 0;
        }
        private int GetPareHash(string pass, string usersalt)
        {
            return (password + salt).GetHashCode();
        }
        public bool Enter(string username, string pass)
        {
            //функция возвращающая username+salt+userHash
            user = username;
            password = pass;
            //salt = 
            //userHash = 
            int passSaltHash = GetPareHash(password, salt);
            if (passSaltHash == userHash) return true;
            else return false;
        }

    }
}
