using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universite_Arsiv_Uygulamasi.DOMAİN
{
    internal class Kullanici
    {
        int userId;
        string username;
        string password;
        string userType;
        bool status;
        private string gUserId;
        private string gUserName;
        private string gPassword;

        

        public Kullanici(string gUserName, string gPassword, string gUserType)
        {
            this.username = gUserName;
            this.password = gPassword;
            this.userType = gUserType;
            
        }

        public Kullanici(int gUserId,string gUsername, string gPassword, string gUserType, bool gStatus)
        {
            this.userId = gUserId;
            this.username = gUsername;
            this.password = gPassword;
            this.userType = gUserType;
            this.status = gStatus;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string UserType { get => userType; set => userType = value; }
        public bool Status { get => status; set => status = value; }
        public int UserId { get => userId; set => userId = value; }
    }
}
