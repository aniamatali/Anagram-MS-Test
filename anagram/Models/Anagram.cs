using System.Collections.Generic;

namespace Anagram.Models
{
  public class Anagramer
  {
    private string _inputWord;

    public Anagramer(string inputWord)
    {
      _inputWord = inputWord;
    }

    public string GetWord()
    {
      return _inputWord;
    }

    public List<string> stringOne = new List <string>  {"abets","baste","betas","beast","beats"};
    public List<string> stringTwo = new List <string>  {"acres", "cares", "races", "scare"};
    public List<string> stringThree = new List <string>  {"alert", "alter", "later"};
    public List<string> stringFour = new List <string>  {"angel","angle", "glean"};
    public List<string> stringFive = new List <string>  {"ascot","coats","coast", "tacos"};
    public List<string> stringSix = new List <string> {"aster", "rates", "stare", "taser", "tears"};



    public List<string> GetValue(string word)
    {
      List<string> result = new List<string>{};
      foreach(string element in stringOne)
      {
        if (word == element)
        {
          return stringOne;
        }
      }

      foreach(string element in stringTwo)
      {
        if (word == element)
        {
          return stringTwo;
        }
      }

      foreach(string element in stringThree)
      {
        if (word == element)
        {
          return stringThree;
        }
      }

      foreach(string element in stringFour)
      {
        if (word == element)
        {
          return stringFour;
        }
      }

      foreach(string element in stringFive)
      {
        if (word == element)
        {
          return stringFive;
        }
      }

      foreach(string element in stringSix)
      {
        if (word == element)
        {
          return stringSix;
        }
      }
      return result;
    }






  }
}
