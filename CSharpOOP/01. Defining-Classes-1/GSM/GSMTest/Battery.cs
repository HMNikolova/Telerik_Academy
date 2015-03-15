namespace GSMTest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Battery
    {
        //Problem 3: Set enum BatteryType
        public enum BatteryType
        { LiIon, NiMH, NiCd, }

        //Problem 1: Initialize classes Display, Battery, GSM 
        //& Problem 5: Encapsulate all data fields
        private string model;
        private double? hoursFree;
        private double? hoursSpeak;

        public string Model 
        {
            get { return model; }
            set
            {
                if (value == null || value.Length > 0)
                {
                    this.model = value;
                }
                else
                {
                    throw new ArgumentException("You must enter battery model.");   
                }
            }
        }
        public double? HoursFree 
        {
            get { return hoursFree; }
            set
            {
                if (value == null || value > 0)
                {
                    this.hoursFree = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The hours value must be positive number.");
                }
            }
        }

        public double? HoursSpeak 
        {
            get { return hoursSpeak;}
            set
            {
                if (value == null || value > 0)
                {
                    this.hoursSpeak = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The hours value must be positive number.");
                }
            }
        }

        //Problem 2: Define constructors for the classes, model and manufacturer are mandatory
        public Battery(string modelPhone)
        {
            this.model = modelPhone;
            this.hoursFree = null;
            this.hoursSpeak = null;
        }

        public Battery(string modelPhone, double hoursFreePhone, double hoursSpeakPhone) : this(modelPhone)
        {
            this.hoursFree = hoursFreePhone;
            this.hoursSpeak = hoursSpeakPhone;
        }
    }
}
