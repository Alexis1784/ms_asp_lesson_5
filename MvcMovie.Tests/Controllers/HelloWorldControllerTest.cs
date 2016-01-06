using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcMovie.Controllers;

namespace MvcMovie.Tests.Controllers
{
    [TestClass]
    public class HelloWorldControllerTest
    {
        [TestMethod]
        public void HelloWorldControllerIsNotNull()
        { 
            // Arrange, Act
            HelloWorldController cont = new HelloWorldController();

            // Assert
            Assert.IsNotNull(cont);
        }
    }
}
