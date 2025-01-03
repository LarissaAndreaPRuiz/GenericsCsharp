using System.Reflection;
using DeSerializerNugetAttributes.Models;
using Newtonsoft.Json;


MyArray<int> arrayInterger = new MyArray<int>();

arrayInterger.AddElementArray(1);

Console.WriteLine(arrayInterger[0]);

MyArray<string> arrayString = new MyArray<string>();
arrayString.AddElementArray("string1");
Console.WriteLine(arrayString[0]);
