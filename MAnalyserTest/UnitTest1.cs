using MAnalyser;
namespace MAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string message = "Iam in Sad mood";
            Mood mood = new Mood();
            string r = mood.MoodAnalyser(message);
            string actualoutput = "SAD";
            string expectedoutput;
            expectedoutput = mood.MoodAnalyser(message);
            Assert.AreEqual(actualoutput, expectedoutput);
        }
        [TestMethod]
        
        public void TestMethod2()
        {
            string message1 = "Iam in Any mood";
            Mood mood = new Mood();
            string r = mood.MoodAnalyser(messsage1);
            string actualoutput = "Happy";
            string expectedoutput;
            expectedoutput = mood.MoodAnalyser(message1);
            Assert.AreEqual(actualoutput, expectedoutput);
        }
    
    }
    
}
