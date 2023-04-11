using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAnalyser
{
    public class Mood
    {
        private string message;
        public  Mood(string message)
        {
            this.message = message;
        }
        public string MoodAnalyser()
        {
           
            if(this.message.Contains("Sad"))
            {
                return "SAD";
            }
            else
            {
                return "Happy";
            }

        }
    }
}
