using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALProject
{
        public class Initializer : DropCreateDatabaseIfModelChanges<Context>
        {
        protected override void details( Context context)
            {
                List<AdminInfo> adminInfos = new List<AdminInfo>();
                adminInfos.Add(new AdminInfo() { Email = "renu@gamil.com", Password = "renu" });
                adminInfos.Add(new AdminInfo() { Email = "pavs@gamil.com", Password = "pavs" });
                context.AdminInfos.AddRange(adminInfos);
                context.SaveChanges();
                List<EmpInfo> empInfos = new List<EmpInfo>();
                empInfos.Add(new EmpInfo() { Email = "priya@gmail.com", Passcode = 123, DateOfJoining = new DateTime(2020, 09, 11), Name = "karthi" });
                empInfos.Add(new EmpInfo() { Email = "mouni@gmail.com", Passcode = 111, DateOfJoining = new DateTime(2019, 04, 11), Name = "nithya" });
               
                context.EmpInfos.AddRange(empInfos);
                List<BlogInfo> blogInfos = new List<BlogInfo>();
                blogInfos.Add(new BlogInfo() { Email = "renu12@gmail.com", BlogUrl = "https://github.com/reddibhavyasri", DateOfCreation = new DateTime(2020, 02, 02), Subject = "GitRepo", Title = "My GitRepo" });
                blogInfos.Add(new BlogInfo() { Email = "mouni12@gmail.com", BlogUrl = "https://github.com/reddibhavyasri", DateOfCreation = new DateTime(2020, 02, 02), Subject = "GitRepo", Title = "My GitRepo" });
                context.BlogInfos.AddRange(blogInfos);
                context.SaveChanges();
                base.Seed(context);
            }
        }
    }


