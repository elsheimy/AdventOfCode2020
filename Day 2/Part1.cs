using System;
using System.IO;
using System.Text.RegularExpressions;

string[] lines = File.ReadAllLines("input.txt");

Regex regex = new Regex(@"(\d+)-(\d+) (\w): (\w*)");

int validCount = 0;
foreach(string ln in lines) {
  var match = regex.Match(ln);

  int min = int.Parse(match.Groups[1].Value);
  int max = int.Parse(match.Groups[2].Value);
  char letter = match.Groups[3].Value[0];
  string password = match.Groups[4].Value;

  int occurrence = password.Where(a => a == letter).Count();

  if (occurrence >= min && occurrence <= max)
    validCount++;
}

Console.WriteLine(validCount);