using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Pastry.Models;

namespace Pastry.Tests 
{
  [TestClass]
  public class Pastry
  {
    [TestMethod]
    public void BreadConstructor_WillCreateABreadObject_Word()
    {
      Pastry testBread = new Pastry();
      Assert.AreEqual(true, testBread.isPastry());
    }
  }
}