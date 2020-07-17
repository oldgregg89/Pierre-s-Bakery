using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bread.Tests 
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_WillCreateABreadObject_Word()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(true, testBread.isBread());
    }
  }
}