using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAnalyser
{
    public class MoodException : Exception
    {
        public enum ExceptionType
        {
            NULL_MOOD, EMPTY_MOOD,
            NO_SUCH_CLASS, OBJECT_CREATION_ISSUE,
            NO_SUCH_METHOD
           
        }
        public ExceptionType exceptionType;
        public MoodException(ExceptionType exceptionType, string message) : base(message)
        {
            this.exceptionType = exceptionType;
        }
    }
}