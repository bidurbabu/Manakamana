using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleQuestions;
namespace SampleQuestionsTest
{
    [TestClass]
    public class StringProblemsTest
    {
        [TestMethod]
        public void TestReverseWord()
        {
            StringProblems SP = new StringProblems();
            string sentence = "This is Nepal";
            string rsentence="Nepal is This";
            Assert.AreEqual(SP.reverseSentence(sentence),rsentence);
            
            sentence = "This is Nepal.";
            rsentence = "Nepal. is This";
            Assert.AreEqual(SP.reverseSentence(sentence), rsentence);

            sentence = "This is  Nepal.";
            rsentence = "Nepal.  is This";
            Assert.AreEqual(SP.reverseSentence(sentence), rsentence);

            sentence = "T";
            rsentence = "T";
            Assert.AreEqual(SP.reverseSentence(sentence), rsentence);

            sentence = "";
            rsentence = "";
            Assert.AreEqual(SP.reverseSentence(sentence), rsentence);

            sentence = "Nepal";
            rsentence = "Nepal";
            Assert.AreEqual(SP.reverseSentence(sentence), rsentence);

            
        }
    }
}
