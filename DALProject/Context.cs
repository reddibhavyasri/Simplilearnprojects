using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALProject
{
    public class Context
    {
        public BlogContext() : base("BlogTracker")
        {
            Configuration.ProxyCreationEnabled = false;
            Database.SetInitializer<BlogContext>(new BlogInitializer());
        }
        public virtual DbSet<EmpInfo> EmpInfos { get; set; }
        public virtual DbSet<AdminInfo> AdminInfos { get; set; }
        public virtual DbSet<BlogInfo> BlogInfos { get; set; }
    }
}

