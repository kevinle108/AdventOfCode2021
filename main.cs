using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    Console.WriteLine("Program start.");
    StreamReader file = new StreamReader("input2.txt");
    int counter = 0;
    string line;
    List<string> myList = new List<string>();
    while ((line = file.ReadLine()) != null)
    {
        myList.Add(line);
        counter++;
    }
    file.Close();
    Console.WriteLine("Done reading input");
    Console.WriteLine($"{counter} lines read.");

    int x = 0;
    int depth = 0;

    for (int i = 0; i < myList.Count; i++) {
      string action = myList[i].Split(" ")[0];
      int val = Int32.Parse(myList[i].Split(" ")[1]);
      Console.WriteLine(action + " " + val);
      if (action[0] == 'f') {
        x += val;
      } else if (action[0] == 'd') {
        depth += val;
      } else {
        // up
        depth -= val;        
      }
      Console.WriteLine("  x = " + x + ", depth = " + depth);
    }
    Console.WriteLine("X: " + x);
    Console.WriteLine("Depth: " + depth);
    Console.WriteLine("Answer: " + (x * depth));
  }
}