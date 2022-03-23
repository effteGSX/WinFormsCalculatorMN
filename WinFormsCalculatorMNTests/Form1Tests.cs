using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsCalculatorMN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace WinFormsCalculatorMNTests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void Form1TestPass()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void InputBufferTest()
        {
            // Arrange
            Form1 calculator = new Form1();

            // ToDo: This can certainly be done in a more elegant manner
            Button b1 = new Button();
            Button b2 = new Button();
            Button b5 = new Button();

            b1.Text = "1";
            b2.Text = "2";
            b5.Text = "5";


            //PrivateObject obj = new PrivateObject(typeof(WinFormsCalculatorMN.Form1));
            //obj.Invoke("btnPlusMinusClick");


            // Act
            calculator.btnNum_Click(b1, new EventArgs());
            calculator.btnNum_Click(b2, new EventArgs());
            calculator.btnNum_Click(b5, new EventArgs());
            calculator.btnDec_Click(new Button(), new EventArgs());
            calculator.btnNum_Click(b5, new EventArgs());
            calculator.btnNum_Click(b1, new EventArgs());
            calculator.btnNum_Click(b2, new EventArgs());
            calculator.btnPlusMinus_Click(new Button(), new EventArgs());

            // Assert
            string separator = System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            Assert.IsTrue(calculator.currentBuffer == "-125" + separator + "512");
        }
    }
}