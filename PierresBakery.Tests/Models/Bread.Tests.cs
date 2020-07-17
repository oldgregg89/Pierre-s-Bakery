using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Bread.Models;

namespace Bread.Tests 
{
  [TestClass]
  public class Bread
  {
    [TestMethod]
    public void BreadConstructor_WillCreateABreadObject_Word()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(typeof(Bread), testBread.GetType());
    }
  }
}