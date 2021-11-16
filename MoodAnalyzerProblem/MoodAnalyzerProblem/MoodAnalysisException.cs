using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerProblem
{
   public class MoodAnalysisException : Exception
    {
       
          
            // Enum for Exception Type
          
            public enum ExceptionType
            {
                NULL_MESSAGE, Empty_Message, NO_SUCH_CLASS, NO_SUCH_METHOD
        }

           //create variable type
            private readonly ExceptionType type;

           
        
           
            public MoodAnalysisException(ExceptionType Type, string message) : base(message)
            {
                this.type = Type;
            }
        }
    }
