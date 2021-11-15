using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerProblem
{
   public class UC3MoodAnalysisException : Exception
    {
       
          
            // Enum for Exception Type
          
            public enum ExceptionType
            {
                NULL_MESSAGE, Empty_Message
            }

           //create variable type
            private readonly ExceptionType type;

           
        
           
            public UC3MoodAnalysisException(ExceptionType Type, string message) : base(message)
            {
                this.type = Type;
            }
        }
    }
