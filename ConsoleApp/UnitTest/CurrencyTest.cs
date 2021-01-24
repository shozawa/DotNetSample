using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ConsoleApp;

namespace UnitTest
{
    public class CurrencyTest
    {
        [Fact]
        public void TestAdd()
        {
            var a = new Currency(1);
            var b = new Currency(2);
            Assert.Equal(3, a.Add(b).Value);
        }
    }
}
