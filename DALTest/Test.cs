using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BALecommerce;
using NUnit.Framework;

namespace DALTest
{
    [NUnit.Framework.TestFixture]
    public class Test
    {
        UserOperations op = null;
        public Test()
        {

            op = new UserOperations();
        }
        [TestCase("renu@gmail.com", "renu", ExpectedResult = true)]
        [TestCase("pavas@gmail.com", "pavs", ExpectedResult = false)]
        [TestCase("priya@gmail.com", "priya", ExpectedResult = true)]
        [TestCase("kola@gmail.com", "kola", ExpectedResult = true)]
        public bool Validate(string Email, string Password)
        {
            return op.ValidateUser(Email, Password);
        }
        [TestCase(2002, ExpectedResult = false)]
        [TestCase(4006, ExpectedResult = true)]
        public bool InsertCkeck(int id)
        {
            CustLogInfoTable4 c = new CustLogInfoTable4();
            c.Userid = id;
            return op.Insert(c);
        }
    }
    }
