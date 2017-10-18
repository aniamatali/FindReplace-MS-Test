using System.Collections.Generic;
using System;

namespace Find.Models
{
  public class Finder
  {
    private string _inputOne;
    private string _inputTwo;
    private string _inputThree;

    public Finder(string inputOne, string inputTwo, string inputThree)
    {
      _inputOne = inputOne;
      _inputTwo = inputTwo;
      _inputThree = inputThree;
    }


    public string GetInputOne()
    {
      return _inputOne;
    }

    public string GetInputTwo()
    {
      return _inputTwo;
    }

    public string GetInputThree()
    {
      return _inputThree;
    }

    public string FindAndReplace()
    {
      string[] splitString = _inputOne.Split(' ');
      for (var i=0; i < splitString.Length; i++ )
      {
        if (splitString[i] == _inputTwo)
        {
          splitString[i] = _inputThree;
        }
      }
      return String.Join(" ", splitString);
    }

    public string FindAndReplace2()
    {
      return _inputOne.Replace(_inputTwo,_inputThree);
    }

  }
}
