using ProjectBELL.Calculater;
using System;

    public class Bell
    {

        public void InputBell()
        {

            Car N1 = new Car();
            N1.EVcar = 50.3;
            Car N2 = new Car();
            N2.EVcar = 44.5;
            Car N3 = new Car();
            N3.EVcar = 40;
            Car N4 = new Car();
            N4.EVcar = 95;
            Car Point = new Car();
            Point.EVcar = 4.3;

           Console.WriteLine("Input Car");
            Console.WriteLine("1:MG EP,2:MG ZS EV,3:Nussan Leaf,4:Audi e-Tron");
           double N =double.Parse(Console.ReadLine());

            if (N == 1) 
            {
                Console.WriteLine("confirm  charge: Input 1 Yes/Input 2 No");
                Console.WriteLine("*******************");
                int R = int.Parse(Console.ReadLine());
                if (R == 1) 
                {
                    Console.WriteLine("Start Charge. . .");
                    double Ans = N1.EVcar* Point.EVcar;
                    Console.WriteLine("finish:" + Ans + "Bath");
                    Console.WriteLine("*******************");
                }
                if (R == 2) 
                {
                    Console.WriteLine("Stop");
                }
               
                       
            }

            if (N == 2)
            {

                Console.WriteLine("confirm  charge: Input 1 Yes/Input 2 No");
                Console.WriteLine("*******************");
                int R = int.Parse(Console.ReadLine());
                if (R == 1)
                {
                    Console.WriteLine("Start Charge. . .");
                    double Ans = N2.EVcar * Point.EVcar;
                    Console.WriteLine("finish:" + Ans + "Bath");
                    Console.WriteLine("*******************");
                }
                if (R == 2)
                {
                    Console.WriteLine("Stop");
                }


            }

            if (N == 3)
            {
                Console.WriteLine("*******************");
                Console.WriteLine("confirm  charge: Input 1 Yes/Input 2 No");
                int R = int.Parse(Console.ReadLine());
                if (R == 1)
                {
                    Console.WriteLine("Start Charge. . .");
                    double Ans = N3.EVcar * Point.EVcar;
                    Console.WriteLine("finish:" + Ans + "Bath");
                    Console.WriteLine("*******************");
                }
                if (R == 2)
                {
                    Console.WriteLine("Stop");
                }


            }

            if (N == 4)
            {
                Console.WriteLine("*******************");
                Console.WriteLine("confirm  charge: Input 1 Yes/Input 2 No");
                int R = int.Parse(Console.ReadLine());
                if (R == 1)
                {
                    Console.WriteLine("Start Charge. . .");
                    double Ans = N4.EVcar * Point.EVcar;
                    Console.WriteLine("finish:" + Ans + "Bath");
                    Console.WriteLine("*******************");
                }
                if (R == 2)
                {
                    Console.WriteLine("Stop");
                }

            }

        }
    }
