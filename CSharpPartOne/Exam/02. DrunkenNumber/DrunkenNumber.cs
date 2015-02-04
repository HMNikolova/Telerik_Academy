using System;
  class DrunkenNumber
    {
        static void Main()
        {
            
            int n = int.Parse(Console.ReadLine());
            int m = 0;
            int v = 0;
            for (int i = 0; i < n; i++)
            {
                //string roundInfo = Console.ReadLine();
                //int digits = roundInfo.Length;
                //Console.WriteLine(digits);
                //с горните три реда може да вземем дължината(колко са цифрите) на цифри
			
                int roundInfo = int.Parse(Console.ReadLine());
                roundInfo = Math.Abs(roundInfo);
                
                int digits = 0;
                int tempRoundInfo = roundInfo;
                while(tempRoundInfo > 0)
                {
                    tempRoundInfo /= 10;
                    digits++;
                }

                for (int j = 0; j < digits / 2; j++)
                {
                    v += (roundInfo % 10);
                    roundInfo /= 10;
                }

                if (digits % 2 == 1)
                {
                    int middle = roundInfo % 10;
                    v += middle;
                    m += middle;
                    roundInfo /= 10;
                }

                for (int j = 0; j < digits / 2; j++)
                {
                    m += (roundInfo % 10);
                    roundInfo /= 10;
                }
            }

            if (m > v)
            {
                Console.WriteLine("M {0}", m - v);
            }
            else if (m < v)
            {
                Console.WriteLine("V {0}", v - m);
            }
            else // m == v
            {
                Console.WriteLine("No {0}", m + v);
            }
		}
     }
    

