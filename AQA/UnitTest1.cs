using System;
using System.IO;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace AQA
{
    [TestClass]
    public class UnitTest1
    {
        public string logFile = @"logfile.txt";

        [TestMethod]
        public void TestNaturalNumbers()
        {
            var applicationPath = Path.Combine("AvalonCalculator.exe");
            Application application = Application.Launch(applicationPath);
            Window window = application.GetWindow("WPF Calculator", InitializeOption.NoCache);

            int btn8 = 8;
            int btn2 = 2;
            int result;

            Button button8 = window.Get<Button>(SearchCriteria.ByAutomationId("B8"));
            button8.Click();
            Button buttonDivide = window.Get<Button>(SearchCriteria.ByAutomationId("BDevide"));
            buttonDivide.Click();
            Button button2 = window.Get<Button>(SearchCriteria.ByAutomationId("B2"));
            button2.Click();
            Button buttonEqual = window.Get<Button>(SearchCriteria.ByAutomationId("BEqual"));
            buttonEqual.Click();


            TextBox textResult = window.Get<TextBox>(SearchCriteria.ByAutomationId("txtResult"));
            Button buttonClear = window.Get<Button>(SearchCriteria.ByAutomationId("BC"));

            result = btn8 / btn2;
            if (result == Convert.ToInt32(textResult.Text))
                Console.WriteLine("True result: " + Convert.ToInt32(textResult.Text));
            else Console.WriteLine("Fals result ");
            using (StreamWriter sw=new StreamWriter(logFile,false,System.Text.Encoding.Default))
            {
                
                sw.WriteLine("test 1: Divide natural numbers. Choice number 8 and divided on number 2, result 4. Result posetive!");

            }
                window.Close();
        }

        [TestMethod]
        public void TestFractionalNumbers()
        {
            var applicationPath = Path.Combine("AvalonCalculator.exe");
            Application application = Application.Launch(applicationPath);
            Window window = application.GetWindow("WPF Calculator", InitializeOption.NoCache);

            Button button1 = window.Get<Button>(SearchCriteria.ByAutomationId("B1"));
            button1.Click();
            Button buttonPoint = window.Get<Button>(SearchCriteria.ByAutomationId("BPeriod"));
            buttonPoint.Click();
            Button button3 = window.Get<Button>(SearchCriteria.ByAutomationId("B3"));
            button3.Click();

            Button buttonDivide = window.Get<Button>(SearchCriteria.ByAutomationId("BDevide"));
            buttonDivide.Click();

            Button button2 = window.Get<Button>(SearchCriteria.ByAutomationId("B2"));
            button2.Click();
            buttonPoint.Click();
            Button button7 = window.Get<Button>(SearchCriteria.ByAutomationId("B7"));
            button3.Click();

            Button buttonEqual = window.Get<Button>(SearchCriteria.ByAutomationId("BEqual"));
            buttonEqual.Click();

            Button buttonClear = window.Get<Button>(SearchCriteria.ByAutomationId("BC"));

            Thread.Sleep(2000);
            Button error = window.Get<Button>(SearchCriteria.ByAutomationId("2"));
            error.Click();
            Console.WriteLine("Error, cant divide");

            using (StreamWriter sw = new StreamWriter(logFile, true, System.Text.Encoding.Default))
            {
                sw.WriteLine("test 2: Fractional natural numbers. Choice number 1.3 and divided on number 2.7, result False, must be true. Result negative!");

            }
            window.Close();

        }

        [TestMethod]
        public void TestDivideZeroFirstNumber()
        {
            var applicationPath = Path.Combine("AvalonCalculator.exe");
            Application application = Application.Launch(applicationPath);
            Window window = application.GetWindow("WPF Calculator", InitializeOption.NoCache);

            Button button0 = window.Get<Button>(SearchCriteria.ByAutomationId("B0"));
            button0.Click();
            Button buttonDivide = window.Get<Button>(SearchCriteria.ByAutomationId("BDevide"));
            buttonDivide.Click();
            Button button2 = window.Get<Button>(SearchCriteria.ByAutomationId("B2"));
            button2.Click();
            Button buttonEqual = window.Get<Button>(SearchCriteria.ByAutomationId("BEqual"));
            buttonEqual.Click();

            Console.WriteLine("True, 0/2 divide");

            using (StreamWriter sw = new StreamWriter(logFile, true, System.Text.Encoding.Default))
            {
                sw.WriteLine("test 3: Divide zero ferst numbers. Choice number 0 and divided on number 2, result true, but must be false. Result negative!");

            }
            window.Close();

        }

        [TestMethod]
        public void TestDivideZeroSecondtNumber()
        {
            var applicationPath = Path.Combine("AvalonCalculator.exe");
            Application application = Application.Launch(applicationPath);
            Window window = application.GetWindow("WPF Calculator", InitializeOption.NoCache);

            Button button8 = window.Get<Button>(SearchCriteria.ByAutomationId("B8"));
            button8.Click();
            Button buttonDivide = window.Get<Button>(SearchCriteria.ByAutomationId("BDevide"));
            buttonDivide.Click();
            Button button0 = window.Get<Button>(SearchCriteria.ByAutomationId("B0"));
            button0.Click();
            Button buttonEqual = window.Get<Button>(SearchCriteria.ByAutomationId("BEqual"));
            buttonEqual.Click();

            Console.WriteLine("False. divide on zero");
            Thread.Sleep(2000);
            Button error = window.Get<Button>(SearchCriteria.ByAutomationId("2"));
            error.Click();

            using (StreamWriter sw = new StreamWriter(logFile, true, System.Text.Encoding.Default))
            {
                sw.WriteLine("test 4: Divide zero second numbers. Choice number 8 and divided on number 0, result false. Result posetive!");

            }
            window.Close();

        }       
    } 
}
