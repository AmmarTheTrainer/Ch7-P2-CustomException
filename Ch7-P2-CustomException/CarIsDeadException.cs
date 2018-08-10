﻿using System;
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

    
    

    public class CarIsDeadException : ApplicationException
    {
        private string messageDetails = String.Empty;
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }

        public CarIsDeadException() { }
        //public CarIsDeadException(string message, string cause, DateTime time)
        //{
        //    messageDetails = message;
        //    CauseOfError = cause;
        //    ErrorTimeStamp = time;
        //}
        public CarIsDeadException(string message, string cause, DateTime time) : base(message)
        {
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }
        //// Override the Exception.Message property.
        //public override string Message => $"Car Error Message: {messageDetails}";
    }


    //class abc : SystemException
    //{

    //}
}
