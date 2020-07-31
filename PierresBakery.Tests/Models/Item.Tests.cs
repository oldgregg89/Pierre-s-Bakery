using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class ItemTests
  {
    [TestMethod]
    public void ItemConstructor_WillCreateAItemObject_Word()
    {
      Item testPastry = new Item();
      Assert.AreEqual(typeof(Item), testPastry.GetType());
    }
  }
}
