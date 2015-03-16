using HighriseApi.Requests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Collections;
using RestSharp;
using HighriseApi;
using System.Collections.Generic;

namespace HighriseApi.Tests
{
    
    
    /// <summary>
    ///This is a test class for EmailRequestTest and is intended
    ///to contain all EmailRequestTest Unit Tests
    ///</summary>
    [TestClass()]
    public class EmailRequestTest : TestBase
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Get
        ///</summary>
        [TestMethod()]
        public void GetTest()
        {
            EmailRequest target = base.HighriseApiRequest.EmailRequest;
            Nullable<int> offset = new Nullable<int>(); // TODO: Initialize to an appropriate value
            IEnumerable<Email> actual;
            actual = target.Get(offset);
            Assert.IsTrue(actual.Count() > 0);
        }
    }
}
