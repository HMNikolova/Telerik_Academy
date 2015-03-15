namespace GSMTest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GSM
    {
        //Problem 6: Add field and property IPhone4S
        public static GSM iPhone4S = new GSM("IPhone4S", "Apple", 850, "Jennifer Lopez", new Battery("Li-polymer", 20, 5), new Display(4, 1000500));

        //Problem 1: Initialize classes Display, Battery, GSM 
        //& Problem 5: Encapsulate all data fields
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;

        public string Model
        {
            get { return model; }
            set
            {
                if (value.Length > 0)
                {
                    this.model = value;
                }
                else
                {
                    throw new ArgumentException("You must enter Model");
                }
            }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set
            {
                if (value.Length > 0)
                {
                    this.manufacturer = value;
                }
                else
                {
                    throw new ArgumentException("You must enter Manufacturer");
                }
            }
        }

        public decimal? Price
        {
            get { return price; }
            set
            {
                if (value == null || value >= 0)
                {
                    this.price = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The price must be positive number.");
                }
            }
        }

        public string Owner
        {
            get { return owner; }
            set
            {
                if (value == null || value.Length > 0)
                {
                    this.owner = value;
                }
                else
                {
                    throw new ArgumentException("You must enter Owner");
                }
            }
        }

        private Battery battery = new Battery(string.Empty);

        public Battery Battery 
        {
            get { return battery; }
            set { this.battery = value; }
        }

        private Display display = new Display();

        public Display Display
        {
            get { return display; }
            set { this.display = value; }
        }

        //Problem 9: Create list of calls history
        private List<Call> callHistory = new List<Call>();
        public List<Call> CallHistory
        {
            get { return callHistory; }
            set { this.callHistory = value; }
        }

        //Problem 2: Define constructors for the classes, model and manufacturer are mandatory
        public GSM(string modelPhone, string manufacturerPhone)
        {
            this.model = modelPhone;
            this.manufacturer = manufacturerPhone;
            this.price = null;
            this.owner = null;
        }

        public GSM(string modelPhone, string manufacturerPhone, decimal pricePhone)
            : this(modelPhone, manufacturerPhone)
        {
            this.price = pricePhone;
        }

        public GSM(string modelPhone, string manufacturerPhone, decimal pricePhone, string ownerPhone)
            : this(modelPhone, manufacturerPhone, pricePhone)
        {
            this.owner = ownerPhone;
        }

        public GSM(string modelPhone, string manufacturerPhone, decimal pricePhone, string ownerPhone, Battery batteryPhone)
            : this(modelPhone, manufacturerPhone, pricePhone, ownerPhone)
        {
            this.Battery = batteryPhone;
        }

        public GSM(string modelPhone, string manufacturerPhone, decimal pricePhone, string ownerPhone, Battery batteryPhone, Display displayPhone)
            : this(modelPhone, manufacturerPhone, pricePhone, ownerPhone, batteryPhone)
        {
            this.Display = displayPhone;
        }

        //Problem 6: Add field and property IPhone4S
        public GSM IPhone4S
        {
            get { return GSM.iPhone4S; }
            private set { }
        }

        //Problem 4: Override the ToString() method
        public override string ToString()
        {
            StringBuilder mobilePhoneData = new StringBuilder();
            mobilePhoneData.AppendFormat("Model: {0}\n", this.model);
            mobilePhoneData.AppendFormat("Manufacturer: {0}\n", this.manufacturer);
            mobilePhoneData.AppendFormat("Price: {0}\n", this.price);
            mobilePhoneData.AppendFormat("Owner: {0}\n", this.owner);
            mobilePhoneData.AppendFormat("Battery Model: {0}\n", this.Battery.Model);
            mobilePhoneData.AppendFormat("Battery Hours Free: {0}\n", this.Battery.HoursFree);
            mobilePhoneData.AppendFormat("Battery Hours Speak: {0}\n", this.Battery.HoursSpeak);
            mobilePhoneData.AppendFormat("Display Size: {0}\n", this.Display.Size);
            mobilePhoneData.AppendFormat("Display colors: {0}\n", this.Display.Colors);
            return mobilePhoneData.ToString();
        }

        //Problem 10: Add, delete, clear calls history & Problem 11: Calculating price of calls
        public void AddCall(Call currentCall)
        {
            this.callHistory.Add(currentCall);
        }

        public void Delete()
        {
            decimal maxDuration = decimal.MinValue;
            decimal currDuration = 0;
            int index = 0;
            int searchIndex = 0;
            for (int i = 0; i < callHistory.Count; i++)
            {
                currDuration = 0;
                for (int j = 0; j < callHistory.Count; j++)
                {
                    if (callHistory[i].RunCall > callHistory[j].RunCall)
                    {
                        currDuration = callHistory[i].RunCall.Value;
                        index = i;
                    }
                }
                if (currDuration > maxDuration)
                {
                    maxDuration = currDuration;
                    searchIndex = index;
                }
            }
            callHistory.RemoveAt(searchIndex);
        }

        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        public decimal PriceCalc(decimal pricePerMinute)
        {
            decimal totalMinutes = 0;
            decimal totalPrice = 0m;
            foreach (var seconds in callHistory)
            {
                totalMinutes += (decimal)(seconds.RunCall) / 60;
            }
            return totalPrice = totalMinutes * pricePerMinute;
        }
    }
}
