using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Places.Models;
using System;

namespace Places.Tests
{
  [TestClass]
  public class PlaceTests 
  {
    [TestMethod]
    public void PlacesConstructor_CreatesAnInstanceOfAnObjectUsingConstructor_Place()
    {
      Place newPlace = new Place("test", "test");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }
  }
}