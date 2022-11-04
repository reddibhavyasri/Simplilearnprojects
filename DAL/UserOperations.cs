
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.WindowsRuntime;

namespace BALecommerce { 
public class UserOperations
{
    mysqldatabase123456Entities1 userContext = null;
    public UserOperations()
    {
        userContext = new mysqldatabase123456Entities1();
    }
    public bool ValidateUser(string email, string pass)
    {
        bool ans = false;
        var found1 = userContext.UserInfoTableDatas.ToList();
        var found = found1.Find(x => x.Email == email);
        if (found != null)
        {
            if (found.Password == pass)
            {
                ans = true;
            }
        }
        return ans;
    }
    public bool Insert(CustLogInfoTable4 c)
    {
        bool ans = true;
        try
        {
            userContext.CustLogInfoTable4.Add(c);
            userContext.SaveChanges();
            return ans;
        }
        catch (Exception)
        {
            ans = false;
            return ans;
        }
    }
}
}

