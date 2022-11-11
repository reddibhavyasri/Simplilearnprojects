using Dal_lib;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Test
{
    public class validate
    {
        DbContext db=new Context();
        public bool check()
        {
            bool ans = false;
            var found = db.AdminInfos.ToList();
            if (found[0].EmailId == "mouni@gmail.com" && found[0].Password == "mouni123456")
            {
                ans = true;
            }
            return ans;
        }
    }
}
