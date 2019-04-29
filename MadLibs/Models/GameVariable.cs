namespace MadLibs.Models
{
  public class GameVariable
  {
    private string _exlamation;
    private string _adverb;
    private string _noun;
    private string _adjective;

    public string GetExlamation ()
    {
      return _exlamation;
    }

    public void SetExlamation(string newExlamation)
    {
      _exlamation = newExlamation;
    }

    public string GetAdverb()
    {
      return _adverb;
    }

    public void SetAdverb (string newAdverb)
    {
      _adverb = newAdverb;
    }

    public string GetNoun ()
    {
      return _noun;
    }

    public void SetNoun(string newNoun)
    {
      _noun = newNoun;
    }

    public string GetAdjective()
    {
      return _adjective;
    }

    public void SetAdjective(string newAdjective)
    {
      _adjective = newAdjective;
    }

  }
}
