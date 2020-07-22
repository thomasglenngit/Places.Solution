using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Places.Models;
using System;

namespace Places.Tests
{
  [TestClass]
  public class PlaceTests : IDisposable
  {
    public void Dispose()
    {
      Place.ClearAll();
    }

    [TestMethod]
    public void PlacesConstructor_CreatesAnInstanceOfAnObjectUsingConstructor_Place()
    {
      Place newPlace = new Place("test", "testy");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void GetCity_ReturnsCity_String()
    {
      string city = "Tokyo";
      string food = "Katsu";
      Place newPlace = new Place(city, food);
      string result = newPlace.City;

      Assert.AreEqual(city, result);
    }

    [TestMethod]
    public void SetCity_SetCity_String()
    {
      //Arrange
      string city = "Tokyo";
      string food = "Katsu";
      Place newPlace = new Place(city, food);
      // Place newPlace = new Place(food);

      //Act
      string updatedCity = "Paris";
      string updatedFood = "Escargot";
      newPlace.City = updatedCity;
      newPlace.Food = updatedFood;
      string result1 = newPlace.City;
      string result2 = newPlace.Food;

      //Assert
      Assert.AreEqual(updatedCity, result1);
      Assert.AreEqual(updatedFood, result2);

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