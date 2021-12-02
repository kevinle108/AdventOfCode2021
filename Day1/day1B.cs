// ﻿using System;
// using System.IO;
// using System.Collections.Generic;
// using System.Linq;

// class MainClass {
//   public static void Main (string[] args) {
//     Console.WriteLine ("Hello World");
//     Console.WriteLine("Program start.");
//     StreamReader file = new StreamReader("input2.txt");
//     int counter = 0;
//     string line;
//     List<int> myList = new List<int>();
//     while ((line = file.ReadLine()) != null)
//     {
//         myList.Add(Int32.Parse(line));
//         counter++;
//     }
//     file.Close();
//     Console.WriteLine("Done reading input");
//     Console.WriteLine($"{counter} lines read.");

//     int answer = 0;

//     int prev = myList[0] + myList[1] + myList[2];
//     string grouping = myList[0].ToString() + " " + 
//                       myList[1].ToString() + " " + 
//                       myList[2].ToString() + " = " + (myList[0]+myList[1]+myList[2]).ToString();
//     Console.WriteLine(grouping);
//     for (int i = 1; i < myList.Count - 2; i++) {

      
//       int cur = myList[i] + myList[i+1] + myList[i+2];
//       if (cur > prev) answer++;
//       prev = cur;

//       grouping = myList[i].ToString() + " " + 
//                   myList[i+1].ToString() + " " + 
//                   myList[i+2].ToString() + " = " + cur.ToString();


//       Console.WriteLine(grouping);
//     }
//     Console.WriteLine(answer);
//   }
// }