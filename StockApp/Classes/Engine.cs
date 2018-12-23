using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp
{
    public class Engine
    {
        public static void LoginWin()
        {

            foreach (var c in DataBase.UserList)
            {
                if (Login.TxtSaveID == c.userID && Login.TxtSavePsw == c.Password)
                {
                    if (c.Admin)
                    {
                        AdminWin adminWin = new AdminWin();
                       
                        Login.IdSave = c.userID;
                        adminWin.Show();
                        Login.count++;
       
                    }
                    else
                    {
                        UserWin userWin = new UserWin();
                         Login.IdSave = c.userID;
                        userWin.Show();
                        Login.count++;

                    }

                }
            }
        }
                      
    }
}
