using System;
namespace Palindrome.Domain.Models
{
  class Program
  {
    static void Main()
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