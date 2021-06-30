using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

//Test genera 2 Custom attributes

namespace MyFirstApp.Tests
{
    [TestClass()] //C# Custom attributes. Indica que es un test de Clase
    public class CalculatorTests
    {
        [TestMethod()] //C# Custom attributes. Indica que es un test de Metodo
        public void AddTest()
        {
            Calculator calculator = new Calculator();
            //Assert.IsTrue(calculator.Add(2, 2) == 4);
            IsTrue(calculator.Add(2, 2) == 4);
        }

        [TestMethod()]
        public void SubstractTest()
        {
            Calculator calculator = new Calculator();
            IsTrue(calculator.Substract(2, 2) == 0);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Calculator calculator = new Calculator();
            IsTrue(calculator.Multiply(2, 3) == 6);
        }

        [TestMethod()]
        public void DivideTest()
        {
            Calculator calculator = new Calculator();
            IsTrue(calculator.Divide(6, 3) == 2);
        }
    }
}