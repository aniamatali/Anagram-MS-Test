using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Anagram.Models;

namespace Anagram.Tests
{

  [TestClass]
  public class AnagramerTests
  {
    [TestMethod]
    public void GetValue()
    {
      //Arrange
      Anagramer newWord = new Anagramer("beast");

      var output = new List<string>{"abets","baste","betas","beast","beats"};

      //Act
      List<string> result = newWord.GetValue(newWord.GetWord());

      //Assert
      CollectionAssert.AreEqual(result, output);

    }

    [TestMethod]
    public void GetValue2()
    {
      //Arrange
      Anagramer newWord = new Anagramer("alert");

      var output = new List<string>{"alert", "alter", "later"};

      //Act
      List<string> result = newWord.GetValue(newWord.GetWord());

      //Assert
      CollectionAssert.AreEqual(result, output);

    }


    //
    //   public void Dispose()
    //   {
    //     Anagramer.ClearAll();
    //   }
    }
  }
