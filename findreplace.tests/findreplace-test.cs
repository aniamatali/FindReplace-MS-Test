using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Find.Models;

namespace Find.Tests
{

  [TestClass]
  public class FinderTests
  {
    [TestMethod]
    public void Replace()
    {
      // Arrange
      Finder newFind = new Finder("a rock a dog a rock rocker", "rock", "hat");

      var output = "a hat a dog a hat hater";

      // Act
      string result = newFind.FindAndReplace2();
      Console.WriteLine (newFind.GetInputOne());
      Console.WriteLine (result);
      // Assert
      Assert.AreEqual(result, output);
      //Assert.AreEqual(result, "DRAW"); this will return the same thing as above
    }

  }
}
