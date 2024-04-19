using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class LoginData
    {
        List<Models> users = new List<Models>();

        public LoginData()
        {

        }

        private void CreateDummyAccount()
        {
            Models user1 = new Models
            {
                UserID = "dreii",
                Password = "Beans16"
            };
            Models user2 = new Models
            {
                UserID = "Knee",
                Password = "Cole11"
            };

            users.Add(user1);
            users.Add(user2);
        }
        public Models GetAccount(string UserID, string Password)
        {
            Models Accountfound = new Models();

            foreach (Models users in users)
            {
                if (users.UserID == UserID)
                {
                    Accountfound = users;
                }

            }

            return Accountfound;

        }
    }
}
