
using MAnalyser;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;

namespace MAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string message = "Iam in Sad mood";
            Mood mood = new Mood(message);
            string r = mood.MoodAnalyser();
            string actualoutput = "SAD";
            string expectedoutput;
            expectedoutput = mood.MoodAnalyser();
            Assert.AreEqual(actualoutput, expectedoutput);
        }
        [TestMethod]

        public void TestMethod2()
        {
            string message1 = "Iam in Any mood";
            Mood mood = new Mood(message1);
            string r = mood.MoodAnalyser();
            string actualoutput = "Happy";
            string expectedoutput;
            expectedoutput = mood.MoodAnalyser();
            Assert.AreEqual(actualoutput, expectedoutput);
        }
        //TC2.1
        [TestMethod]
        public void TestMethod3() 
        {
            string message2 = "";
            Mood mood = new Mood(message2);
            string r = mood.MoodAnalyser();
            string actualoutput = "Happy";
            string expectedoutput;
            expectedoutput = mood.MoodAnalyser();
            Assert.AreEqual(actualoutput, expectedoutput);

        }

    }

}