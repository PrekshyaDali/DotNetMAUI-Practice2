using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrekshyaMaui.Models;


namespace TestProject
{
    public class ArithmeticServicesTest
    {
        private readonly ArithmeticServices _Services;

        public ArithmeticServicesTest()
        {
            _Services = new ArithmeticServices();
        }

        [Fact]
        public void Add()
        {
            var result = _Services.Add(5,5);
            Assert.Equal(10, result);
        }
        [Fact]
        public void Subtract()
        {
            var result = _Services.Subtract(5,4);
            Assert.Equal(1, result);
        }

        [Fact]
        public void Multiply()
        {
            var result = _Services.Multiply(2, 3);
            Assert.Equal(6, result);
        }


        [Fact]
        public void Divide()
        {
            var result = _Services.Divide(6, 3);
            Assert.Equal(2.0, result, 1);
        }

        [Fact]
        public void DivideByZero()
        {
            Assert.Throws<ArgumentException>(() => _Services.Divide(6, 0));
        }
    }
}
