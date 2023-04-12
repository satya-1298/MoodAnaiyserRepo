
using MAnalyser;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;

namespace MAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        //TC1.1
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
        //TC1.2
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
            string message2 = "null";
            Mood mood = new Mood(message2);
            string r = mood.MoodAnalyser();
            string actualoutput = "Happy";
            string expectedoutput;
            expectedoutput = mood.MoodAnalyser();
            Assert.AreEqual(actualoutput, expectedoutput);

        }
        [TestMethod]
        public void TestMethod4() 
        {
            try
            {
                string message = "";
                Mood mood = new Mood(message);
                string r = mood.MoodAnalyser();
                string actualoutput = "message is empty";
                //string expectedoutput= mood.MoodAnalyser();
                //Assert.AreEqual(actualoutput, expectedoutput);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("message is empty", ex.Message);
            }
        }

    }

}