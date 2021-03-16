using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CapstoneProject.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.HomeController
{
    [TestClass]
    class HomeControllerTest
    {
        
        [TestMethod]
        public void StringInputCheckTestRegular(string input)
        {
            CapstoneProject.Controllers.HomeController con = new CapstoneProject.Controllers.HomeController();
            
            //Arrange
            bool resultFromCall;
            bool expectedResult = true;
            
            //Act
            resultFromCall = con.StringInputCheck("Oakville");

            //Assert
            Assert.AreEqual(expectedResult, resultFromCall);

        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void StringInputCheckInvalidLength_ThrowsException_Check()
        {
            CapstoneProject.Controllers.HomeController con = new CapstoneProject.Controllers.HomeController();

            //Arrange
            string testString = "OakvilleOakvilleOakvilleOakville";

            //Act
            con.StringInputCheck(testString);

            //Assert
            

        }

    }
}
