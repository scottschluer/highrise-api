using HighriseApi.Requests;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RestSharp;
using HighriseApi;
using System.Collections.Generic;

namespace HighriseApi.Tests
{
    
    
    /// <summary>
    ///This is a test class for PersonRequestTest and is intended
    ///to contain all PersonRequestTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PersonRequestTest : TestBase
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
            PersonRequest target = base.HighriseApiRequest.PersonRequest; // new PersonRequest(client); // TODO: Initialize to an appropriate value
            DateTime startDate = DateTime.Parse("2013-01-01");
            IEnumerable<Person> actual;
            actual = target.Get(startDate);
            Assert.IsTrue(actual.Count() > 0);
        }

        /// <summary>
        ///A test for Get
        ///</summary>
        [TestMethod()]
        public void GetTest1()
        {
            PersonRequest target = base.HighriseApiRequest.PersonRequest;
            int id = 185835413; 
            Person actual;
            actual = target.Get(id);
            Assert.IsNotNull(actual);
        }
    }
}
