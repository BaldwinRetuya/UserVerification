using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Verification
    {
        public bool Verify(string UserID, string Password)
        {
            LoginData data = new LoginData();
            var result = data.GetAccount(UserID, Password);

            return result != null ? true : false;
        }
    }
}
