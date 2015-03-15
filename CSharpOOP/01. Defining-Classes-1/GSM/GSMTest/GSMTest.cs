namespace GSMTest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GSMTest
    {

        static void Main()
        {
            //Problem 7: Write a class GSMTest to test the GSM class
            Battery battery = new Battery("Li-polymer +", 20, 5);
            Display display = new Display(5, 16000000);
            GSM gsm1 = new GSM("Alpha", "Samsung", 600);
            GSM gsm2 = new GSM("S5", "Samsung");
            GSM gsm3 = new GSM("s5 mini", "Samsung", 700, "Jennifer Lopez", battery, display);

            GSM[] gsms = new GSM[] { gsm1, gsm2, gsm3};

            foreach (GSM gsm in gsms)
            {
                Console.WriteLine(gsm);
            }
            Console.WriteLine(GSM.iPhone4S);
            Console.WriteLine(new string('-', 15));

            //Problem 12: Test the call history functionality of the GSM class.

            Console.WriteLine("Task 12: Write a class to test the call history functionality of the GSM class.");

            GSM Lenovo = new GSM("Vibe Z", "Lenovo", 900, null, null, null);
            Call callHistory1 = new Call("0885 111 111", 20, DateTime.Now);

            Call callHistory2 = new Call("359 101010", 40);

            List<Call> listOfCalls = new List<Call>();
            listOfCalls.Add(callHistory1);
            listOfCalls.Add(callHistory2);

            foreach (Call call in listOfCalls)
            {
                Console.WriteLine(call);
            }

            gsm1.AddCall(callHistory1);
            Console.WriteLine("Total price of calls for {0} {1} is: {2:C}", gsm1.Manufacturer, gsm1.Model, gsm1.PriceCalc(0.37m));

            gsm1.AddCall(callHistory2);
            Console.WriteLine("Total price of calls for {0} {1} is: {2:C}", gsm1.Manufacturer, gsm1.Model, gsm1.PriceCalc(0.37m));

            gsm1.Delete();
            Console.WriteLine("Total price of calls after removing a call is {0:C}", gsm1.PriceCalc(0.37m));

            gsm1.ClearCallHistory();
            Console.WriteLine("Total price after clearing call history is {0:C}", gsm1.PriceCalc(0.37m));
        
        }
    }
}
