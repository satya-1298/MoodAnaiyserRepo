using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAnalyser
{
   
        public string MoodAnalyser(string message)
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
