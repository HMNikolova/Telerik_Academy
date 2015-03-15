namespace GSMTest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Call
    {
        //Problem 8: Create class Call.It should contain date, time, dialed phone number and duration (in seconds).
        private DateTime? date;
        private string calledNumber;
        private ulong? runCall;

        public Call()
        {
            this.runCall = null;
            this.calledNumber = null;
            this.date = null;
        }

        public Call(string calledNumberPhone, ulong runCallPhone) : this()
        {
            this.calledNumber = calledNumberPhone;
            this.runCall = runCallPhone;
        }

        public Call(string calledNumberPhone, ulong runCallPhone, DateTime dateTime)
            : this(calledNumberPhone, runCallPhone)
        {
            this.calledNumber = calledNumberPhone;
            this.runCall = runCallPhone;
            this.date = dateTime;
        }

        public DateTime? Date
        {
            get { return date; }
            set
            {
                try
                {
                    this.date = value;
                }
                catch (FormatException)
                {
                    
                    throw new FormatException("Date format is invalid.");
                }
            }
        }

        public string CalledNumber 
        {
            get { return calledNumber; }
            set { calledNumber = value; } 
        }

        public ulong? RunCall
        {
            get { return runCall; }
            set { runCall = value; }
        }

        public override string ToString()
        {
            StringBuilder infoCall = new StringBuilder();
            infoCall.AppendFormat("Called number: {0}\n", this.calledNumber);
            infoCall.AppendFormat("Run of call: {0}\n", this.runCall);
            infoCall.AppendFormat("Date and time of call: {0}\n", this.date);
            return infoCall.ToString();
        }
    }
    
}
