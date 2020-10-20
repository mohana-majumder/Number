using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Number
{
    [TestFixture]
    class Test
    {
        [TestCase]
        public void DivByThree()
        {
            int num = 3;
            Program p = new Program();
            string str = p.DivNum(num);
            Assert.AreEqual("A", str);
        }
        [TestCase]
        public void DivByFive()
        {
            int num = 5;
            Program p = new Program();
            string str = p.DivNum(num);
            Assert.AreEqual("B", str);
        }
        [TestCase]
        public void DivByThreeAndFive()
        {
            int num = 15;
            Program p = new Program();
            string str = p.DivNum(num);
            Assert.AreEqual("C", str); 
        }
        [TestCase]
        public void NotDiv()
        {
            int num = 7;
            Program p = new Program();
            string str = p.DivNum(num);
            Assert.AreEqual("Not divisible", str);
        }
    }
}
