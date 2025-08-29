// See https://aka.ms/new-console-template for more information
using System.Text;
using System.Text.Unicode;

Console.WriteLine("Hello, World!");


//In C#, encoding refers to the process of converting characters (like letters and symbols) into a sequence of bytes, and vice versa.
//This is crucial when you're working with text data—especially when saving to files, sending over networks, or interfacing with systems
//that use different character sets.

//🔤 What Encoding Does
//Encodes: Converts a string (e.g., "Hello") into bytes.

//Decodes: Converts bytes back into a string.


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


