using System;
using System.IO;
using System.Text.RegularExpressions;

string[] lines = File.ReadAllLines("input.txt");

Regex regex = new Regex(@"(\d+)-(\d+) (\w): (\w*)");

int validCount = 0;
foreach (string ln in lines)
{
  var match = regex.Match(ln);

  int first = int.Parse(match.Groups[1].Value);
  int second = int.Parse(match.Groups[2].Value);
  char letter = match.Groups[3].Value[0];
  string password = match.Groups[4].Value;


  if (Enumerable.Where(new[] { password[first - 1] == letter, password[second - 1] == letter }, a => a).Count() == 1)
    validCount++;
}

Console.WriteLine(validCount);