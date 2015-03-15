namespace GSMTest
{
    ﻿using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Display
    {
        //Problem 1: Initialize classes Display, Battery, GSM 
        //& Problem 5: Encapsulate all data fields
        private decimal? size;
        private ulong? colors;

        public decimal? Size 
        { 
            get {return size;}
            set
            {
                if (value == null || value > 0)
                {
                    this.size = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The size must be positive number");
                }
                
            } 
        }

        public ulong? Colors 
        {
            get { return colors; }
            set
            {
                if (value == null || value > 0)
                {
                    this.colors = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The colors of the display must be positive numbers");
                }
            }
        }

        public Display()
        {
            this.size = null;
            this.colors = null;
        }

        //Problem 2: Define constructors for the classes, model and manufacturer are mandatory
        public Display(decimal sizeDisplay) : this()
        {
            this.size = sizeDisplay;
        }

        public Display(decimal sizeDisplay, ulong colorsDisplay) : this(sizeDisplay)
        {
            this.colors = colorsDisplay;
        }

    }
}
