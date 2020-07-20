using System;
using Xunit;

namespace PalindromeTest
{
  public class UnitTest1
  {
    [Fact]
    public void Test1()
    {
      string string1, rev;
      string1 = Console.ReadLine();
      char[] ch = string1.ToCharArray();
      Array.Reverse(ch);
      rev = new string(ch);
      bool b = string1.Equals(rev, StringComparison.OrdinalIgnoreCase);
      if (b == true)
      {
        Console.WriteLine("" + string1 + " is a Palindrome!");
      }
      else
      {
        Console.WriteLine(" " + string1 + " is not a Palindrome!");
      }
      Console.Read();
    }
  }
}
