using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlacesBeen.Models;
using System.Collections.Generic;
using System;

namespace PlacesBeen.Tests
{
  [TestClass]
  public class PlaceTests
  {
    [TestMethod]
    public void Place_InstantiateAnInstanceOfPlace_Place()
    {
      Place newPlace = new Place("test");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }
    [TestMethod]
    public void Place_InstantiateAnInstanceOfPlace_newPlace()
    {
      //Arrange
      string cityName = "Amsterdam";
      //Act
      Place newPLace = new Place(cityName);
      string result = newPLace.CityName;
      // Assert
      Assert.AreEqual("Amsterdam", result);
    }
  }
}