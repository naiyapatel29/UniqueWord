using System.Collections.Generic;
using NUnit.Framework;
using UniqueWord;

namespace UniqueWordTest
{
    public class Tests
    {
        UniqueWords uniqueWord = new UniqueWords();



        [Test]

        public void checkgetUniqueWordCount()

        {

            //Assert

            var type = uniqueWord.GetType();
            //Verify

            Assert.IsNotNull(type.GetMethod("getUniqueWordCount"));

        }

        [Test]

        public void ChekUniqueWordsArenotCaseSesitive()

        {

            //Assert

            string paragraph = "Test test TesT TEST TEsT";

            //Act

            Dictionary<string, int> dictionary = uniqueWord.getUniqueWordCount(paragraph);

            //Verify

            Assert.AreEqual(dictionary.Count, 1);

        }



        [Test]

        public void CheckPunctuationsAreNotConsideredAsWords()

        {

            //Assert

            string paragraph = ".. ??    . ; ; ";

            //Act

            Dictionary<string, int> dictionary = uniqueWord.getUniqueWordCount(paragraph);

            //Verify

            Assert.AreEqual(dictionary.Count, 0);

        }

        [Test]

        public void CheckUniquewordCountMethodHandlesEmptyString()

        {

            //Assert

            string paragraph = "         ";

            //Act

            Dictionary<string, int> dictionary = uniqueWord.getUniqueWordCount(paragraph);

            //Verify

            Assert.AreEqual(dictionary.Count, 0);

        }



        public void CheckUniqueWordCountofGivenStringReturnCorrectly()

        {

            //Assert

            string paragraph = "Share your thoughts on something that inspired you to do more and go above and beyond to find opportunities to contribute to success of the organization \"you\" are working for";

            //Act

            Dictionary<string, int> dictionary = uniqueWord.getUniqueWordCount(paragraph);

            //Verify to words appears 4 times in the paragraph given above

            Assert.AreEqual(dictionary["to"], 4);

        }

    }

}