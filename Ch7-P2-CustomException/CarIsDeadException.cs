using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7_P2_CustomException
{
    #region older CarIsDeadException




    ////public class CarIsDeadException : ApplicationException
    ////{
    ////    private string messageDetails = String.Empty;
    ////    public DateTime ErrorTimeStamp { get; set; }
    ////    public string CauseOfError { get; set; }

    ////    public CarIsDeadException() { }
    ////    //public CarIsDeadException(string message, string cause, DateTime time)
    ////    //{
    ////    //    messageDetails = message;
    ////    //    CauseOfError = cause;
    ////    //    ErrorTimeStamp = time;
    ////    //}
    ////    public CarIsDeadException(string message, string cause, DateTime time) : base(message)
    ////    {
    ////        CauseOfError = cause;
    ////        ErrorTimeStamp = time;
    ////    }
    ////    //// Override the Exception.Message property.
    ////    //public override string Message => $"Car Error Message: {messageDetails}";
    ////}


    // A standard .NET custom exception is here....

    #endregion

    #region A little optimized custom .net exception


    //public class CarIsDeadException : ApplicationException
    //{
    //    private string messageDetails = String.Empty;
    //    public DateTime ErrorTimeStamp { get; set; }
    //    public string CauseOfError { get; set; }

    //    public CarIsDeadException() { }
    //    public CarIsDeadException(string message, string cause, DateTime time) : base(message)
    //    {
    //        CauseOfError = cause;
    //        ErrorTimeStamp = time;
    //    }
    //}

    #endregion

    #region A fully optimized .NET custom Exception < without code snippet >

    [Serializable]
    public class CarIsDeadException : ApplicationException
    {
        private string messageDetails = String.Empty;
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }

        public CarIsDeadException() { }
        public CarIsDeadException(string message) : base(message)
        { }
        public CarIsDeadException(string message , System.Exception inner) : base(message,inner)
        { }

        protected CarIsDeadException(System.Runtime.Serialization.SerializationInfo info, 
                                     System.Runtime.Serialization.StreamingContext context) : base(info, context)
        { }
        
        // Any additional custom properties, constructors and data members...
        
    }

    #endregion

    #region .NET Custom Exception generted through code snippet.


    //[Serializable]
    //public class MyException : Exception
    //{
    //    public MyException() { }
    //    public MyException(string message) : base(message) { }
    //    public MyException(string message, Exception inner) : base(message, inner) { }
    //    protected MyException(
    //      System.Runtime.Serialization.SerializationInfo info,
    //      System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    //}

    #endregion

    //class abc : SystemException
    //{

    //}
}
