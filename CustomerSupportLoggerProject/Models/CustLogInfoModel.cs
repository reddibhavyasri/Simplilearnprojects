using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerSupportLoggerProject.Models
{
    public class CustLogInfoModel
    {
        
            public int Logid { get; set; }
            public string CustEmail { get; set; }
            public string CustName { get; set; }
            public string LogStatus { get; set; }
            public int Userid { get; set; }
            public string Description { get; set; }
        }
    }
