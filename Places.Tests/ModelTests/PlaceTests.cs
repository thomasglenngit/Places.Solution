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
      Place newPlace = new Place("test", "testy");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void GetAll_ReturnsTheListOfDestinations_List()
    {
      string city = "Tokyo";
      string food = "Katsu";
      Place newPlace = new Place(city, food);
      List<Place> newList = new List<Place> {newPlace};

      List<Place> result = Place.GetAll();
      
      CollectionAssert.AreEqual(newList, result);

    }
  }
}