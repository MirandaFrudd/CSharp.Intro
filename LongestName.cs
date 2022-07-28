class LongestName
{
  public string GetLongest(string[] names)
  {
    string longest = "";
    foreach (string name in names)
    {
      if (name.Length >= longest.Length)
      {
        longest = name;
      }
    }
    return longest;
  }
}