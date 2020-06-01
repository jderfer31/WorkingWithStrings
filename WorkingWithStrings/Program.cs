using System;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // \n means new line charachter ex: Console.WriteLine("jeremy\nlangenderfer"); will print on separate lines
            //Contatination example below
            //Methods are pre-made snips of code and we can "call" on them to get info and examples of methods are phrase.***
            string phrase = "Jeremy" + " is cool";
            //Console.WriteLine(phrase.Length); //returns the length of characters in the string phrase line
            //Console.WriteLine(phrase.ToUpper() ); //turns string phrase to all upper case letters
            //Console.WriteLine(phrase.ToLower() ); //turns string phrase to all lower case letters
            //Console.WriteLine(phrase.Contains("remy") ); //contains method returns if string contains anything placed inside the parameter such as "remy" and returned 'true'
            //Console.WriteLine(phrase[0] ); /using the [] and inputting a value will return character in string, in this case 0 is J as it counts 0,1,2,3 and so on
            //Console.WriteLine(phrase.IndexOf("is") );  // returns location value of i in is
            //Console.WriteLine(phrase.IndexOf('s') ); // returns location value of 's' and the '' allow for single character input and negative return value means character is not in string
            //Console.WriteLine(phrase.Substring(6) ); //prints starting from location value of 6 - "is cool"
            //Console.WriteLine(phrase.Substring(6, 3) ); //grabs from position 6 and returns 3 characters
            //GOOGLE STRING METHODS C# for a huge list of methods
            Console.WriteLine(phrase.Substring(6, 3) ); 

            
        }
    }
}
