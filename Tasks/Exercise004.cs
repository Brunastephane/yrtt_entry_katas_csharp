using System;

// Move the first letter of each word to the end of it, then add "ay" to the end of the word. 
// Leave punctuation marks untouched.

namespace TechReturners.Tasks
{
    public class Exercise004
    {
        public static string PigIt(string str)
        {
            //Variable for return
            string r = "";
            //variable for the frase
            string wmodify;
            //variable to check the ponctuation
            int count = 0;

            //A Loop for each word in a split
            foreach (string word in str.Split())
            {
                //A Loop for each letter in a word
                foreach (char c in word)
                {
                    //If is not have a ponctuation the count variable will change the value
                    if (char.IsPunctuation(c) == false)
                    {
                        count++;
                    }

                }

                //If the count varible has the same size of a word, dont have ponctuation, so apply the first condition
                //If dont have the same size, apply the else condition
                if (count == word.Length)
                {
                    wmodify = (word.Substring(1, word.Length - 1)) + (word.Substring(0, 1)) + "ay ";
                }
                else
                {
                    wmodify = (word.Substring(1, count - 1)) + (word.Substring(0, 1)) + "ay" + (word.Substring(count, word.Length - count));
                }

                r = r + wmodify;
                count = 0;
            }

            return r.Trim();
            throw new NotImplementedException();
        }
    }
}

