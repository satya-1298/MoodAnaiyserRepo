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



                if (this.message.ToLower().Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "Happy";
                }
            }catch
            {
                return "Happy";
            }

        }
    }
  
}