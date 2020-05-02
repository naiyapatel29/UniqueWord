using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace UniqueWord
{
    class Program
    {
        static void Main(string[] args)
        {
            /**

                Notes:

                There is not enough information about the scope what kind of string and which special characters should be excluded.

               I have developed the program based on following assumptions

               1. All the special charaters "?,."" are not considered words.

               2. All the words are converted to lowecase and compared so casesensitive words are not considered unique.

               3. Unit Test covers the scenarion on how to handle empty string, string with all special charaters and a regular string to count number of unique words.

    

               I have used Dictionary with word as key and integer count as value.

                * **/
            string paragraph = "";
            while (paragraph != "1")
            {
                Console.WriteLine("Enter Paragrah");

                paragraph = Console.ReadLine();

                UniqueWords uniqueWord = new UniqueWords();

                //string paragraph = "Share your thoughts on something that inspired you to do more and go above and beyond to find opportunities to contribute to success of the organization \"you\" are working for? Share your thoughts on something that inspired you to do more and go above and beyond to find opportunities to contribute to success of    the organization you are working for.";

                Dictionary<string, int> wordCount = uniqueWord.getUniqueWordCount(paragraph);

                foreach (KeyValuePair<string, int> item in wordCount)

                {

                    Console.WriteLine(item.Key + "  " + item.Value);

                }
                Console.WriteLine("Press enter to continue and 1 to exit");

                paragraph = Console.ReadLine();
            }
            System.Environment.Exit(0);
        }

    }

    public class UniqueWords

    {

        public Dictionary<string, int> getUniqueWordCount(string paragraph)

        {

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            foreach (string word in Regex.Split(paragraph, @"["".,;?\s]+"))

            {

                if (dictionary.ContainsKey(word.ToLower()))

                {

                    dictionary[word.ToLower()] += 1;

                }

                else

                {

                    if (word.Trim() != "")

                    { dictionary.Add(word.ToLower(), 1); }

                }

            }

            return dictionary;

        }

    }

}
