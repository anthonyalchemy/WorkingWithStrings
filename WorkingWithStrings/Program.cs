using System;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            string phrase = "Alchemy Academy";
            Console.WriteLine(phrase);
            Console.WriteLine(phrase.Length); //finds out characters in phrase 
            Console.WriteLine(phrase.Contains("Academy")); //giving contains a parameter in the brackets to see if this phrase contains a word will return true or false
            Console.WriteLine(phrase.Substring(7, 3)); //Grabs and prints part of the string from the index number then the 3 will print out 3 characters 


            string phrase2 = "Alchemy Academy" + " is cool"; //concatination adding one string onto another
            Console.WriteLine(phrase2);
            Console.WriteLine(phrase2.ToUpper()); //prints phrase 2 to uppercase
            Console.WriteLine(phrase2 [0]); //will print out first character of the phrase, when indexing a string we start at 0 
            Console.WriteLine(phrase2.IndexOf("Academy"));//will tell you index positon the word starts at i.e 7 can also do it with characters
            //if you add a character in and it isnt in the string it will return an answer of -1 




            Console.WriteLine("Alchemy\nAcademy"); // \n makes new line Alchemy one line academy next line 


            Console.WriteLine("Alchemy\"Academy"); //prints out quotation 




            Console.ReadLine();
        }
    }
}
