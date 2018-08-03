﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReleasePipeDemoApplication.Controllers;

namespace ReleasePipeDemoApplication.Tests.Controllers
{
    [TestClass]
    public class ExamplesControllerTests
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            ExamplesController controller = new ExamplesController();

            // Act
            IEnumerable<string> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("wrong", result.ElementAt(0));
            Assert.AreEqual("value2", result.ElementAt(1));
        }
    }
}
