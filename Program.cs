// See https://aka.ms/new-console-template for more information
using System.Text;
using System.Text.Unicode;

Console.WriteLine("Hello, World!");


string stringToEncode = "Hello";
// Encoded Steps
byte[] strbyte =  Encoding.UTF8.GetBytes(stringToEncode); // Convert string to byte array;
string encodedString =  Convert.ToBase64String(strbyte); // Convert byte array to base 64 string 
Console.WriteLine(encodedString);
// Encoded Steps

// Decode The Encoded String
byte[] bytearrfromBase64string =  Convert.FromBase64String(encodedString);  // Convert encoded base64 string to byte array
string decodedstring = Encoding.UTF8.GetString(bytearrfromBase64string);    // Getstring from byte array.

Console.Read();

