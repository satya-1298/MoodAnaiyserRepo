using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAnalyser
{
    public class Mood
    {
        public string message;
        public Mood(string message)
        {
            this.message = message;
        }
        public string MoodAnalyser()
        {
            try
            {
                if (string.IsNullOrEmpty(this.message))
                {
                    throw new MoodException(MoodException.ExceptionType.EMPTY_MOOD, "message is empty");
                }


                if (this.message.ToLower().Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "Happy";
                }
            }catch(Exception ) 
            {
                throw new MoodException(MoodException.ExceptionType.EMPTY_MOOD, "message is empty");
            }

        }
    }
  
}