using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using PassportForm1;
using Interface;


namespace StartTests
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class Test1
    {

        Assembly assem = Assembly.LoadFrom( @"C:\Users\guest2\Documents\Visual Studio 2015\TestProject\PassportForm1\PassportForm1\bin\Debug\PassportForm1.exe");
        Form formPassport;
        public Test1()
        {
        }


        [TestMethod]
        public void TestPassport()
        {
            StartPassportForm();
        }

        [TestMethod]
        public void TestINN()
        {
            StartINNForm();
        }
    
     


        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        private TestContext testContextInstance;




        public void StartPassportForm()
        {


            Assembly assem =
                Assembly.LoadFrom(
                    @"C:\Users\guest2\Documents\Visual Studio 2015\TestProject\PassportForm1\PassportForm1\bin\Debug\PassportForm1.exe");
            Form formPassport;
            Type[] typess = assem.GetTypes();
            foreach (var item in typess)
            {
                var iTestInterfaseType = item.GetInterface(typeof(ITest).ToString());
                if (iTestInterfaseType != null)
                {
                    formPassport = (Form) Activator.CreateInstance(item);


                    var itestFormPassport = formPassport as ITest;
                    if (itestFormPassport != null)
                    {

                        itestFormPassport.doTest();

                    }


                }
            }
        }

        public void StartINNForm()
        {

            Assembly assem =
                Assembly.LoadFrom(
                    @"C:\Users\guest2\Documents\Visual Studio 2015\TestProject\INNForm\INNForm\bin\Debug\INNForm.exe");
            Form formINN;
            Type[] typess = assem.GetTypes();
            foreach (var item in typess)
            {
                var iTestInterfaseType = item.GetInterface(typeof(ITest).ToString());
                if (iTestInterfaseType != null)
                {
                    formINN = (Form) Activator.CreateInstance(item);
  
                    var itestFormInn = formINN as ITest;
                    if (itestFormInn != null)
                    {
                         
                        itestFormInn.doTest();

                         

                    }


                }
            }
        }

        
    }
}