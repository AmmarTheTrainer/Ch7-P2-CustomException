using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7_P2_CustomException
{
    class Car
    {
        // Constant for maximum speed.
        public const int MaxSpeed = 100;
        // Car properties.
        public int CurrentSpeed { get; set; } = 0;
        public string CarName { get; set; } = "";
        // Is the car still operational?
        private bool carIsDead;
        // A car has-a radio.
        private Radio theMusicBox = new Radio();
        // Constructors.
        public Car() { }
        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            CarName = name;
        }

        public void CrankTunes(bool state)
        {
            // Delegate request to inner object.
            theMusicBox.TurnOn(state);
        }

        // See if Car has overheated.
        public void Accelerate(int delta)
        {
            if (carIsDead)
                Console.WriteLine("{0} is out of order...", CarName);
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed > MaxSpeed)
                {
                    //Console.WriteLine("{0} has overheated!", PetName);
                    CurrentSpeed = 0;
                    carIsDead = true;

                    #region Throwing excpetion by custom exception class

                    CarIsDeadException ex = new CarIsDeadException($"{CarName} is over heated", 
                                                                    "You have a loud foot", DateTime.Now);
                    ex.HelpLink = "www.apni-auqat-main-raho.com";
                    throw ex;

                    #endregion
                    
                    #region throwing expcetion by using base exception class


                    //Exception ex = new Exception($"{CarName} has overheated!");
                    //ex.HelpLink = "http://www.Apni-Auqat-Main-Raho.com";
                    //ex.Data.Add("TimeStamp", $"The car exploded at {DateTime.Now}");
                    //ex.Data.Add("Cause", "You have a Loud foot.");

                    //throw ex;

                    #endregion

                }
                else
                {
                    Console.WriteLine("=> CurrentSpeed = {0}", CurrentSpeed);
                }
            }
        }
    }
}
