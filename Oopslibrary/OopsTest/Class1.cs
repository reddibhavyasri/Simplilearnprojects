using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Oopslibrary;
using NUnit.Framework;
namespace oop_class_test
{
    [TestFixture]
    public class Class_test
    {
        /// </summary>
        [TestCase]
        public void test_student()
        {
            Student s = new Student();
           
            s.SName = "Pavs";
            Assert.AreEqual(s.SName, "Pavs");
        }
        [TestCase]
        public void test_subject()
        {
            Subject s = new Subject();
           
            s.SubName = "physics";
          
            Assert.AreEqual(s.SubName, "Physics");
        }
        [TestCase]
        public void test_teacher()
        {
            Teacher s = new Teacher();
            
            s.TName = "Renu";
            Assert.AreEqual(s.TName, "Renu");
        }

    }
}