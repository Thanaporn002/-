using System;
using System.Collections.Generic;



    public class Force
    {
    private Force user;

   public static void InputForce()
   {
      Console.WriteLine("Car");
      Console.WriteLine("***************");
      Specar S1 = new Specar();
        S1.Car = "1.MG EP";
        S1.Price = 215;
      Specar S2 = new Specar();
        S2.Car = "2.MG ZS EV";
        S2.Price = 192;

      Specar S3 = new Specar();
        S3.Car = "3.Nisan Leaf";
        S3.Price = 172;

      Specar S4 = new Specar();
        S4.Car = "4.Audi e-Tron";
        S4.Price = 399;

       Console.WriteLine(S1.Car);
       Console.WriteLine(S2.Car);
       Console.WriteLine(S3.Car);
       Console.WriteLine(S4.Car);
       Console.WriteLine("Input Car");
       Console.WriteLine("***************");
       int C = int.Parse(Console.ReadLine());

            if (C == 1) 
            {
                Console.WriteLine("***************");
                Console.WriteLine(S1.Car);
                Console.WriteLine(S1.Price + "Bath");
                Console.WriteLine("***************");
           
               
            }
            if (C == 2)
            {
                Console.WriteLine("***************");
                Console.WriteLine(S2.Car);
                Console.WriteLine(S2.Price + "Bath");
                Console.WriteLine("***************");
            }
            if (C == 3)
            {
                Console.WriteLine("***************");
                Console.WriteLine(S3.Car);
                Console.WriteLine(S3.Price + "Bath");
                Console.WriteLine("***************");
            }
            if (C == 4)
            {
                Console.WriteLine("***************");
                Console.WriteLine(S4.Car);
                Console.WriteLine(S4.Price + "Bath");
                Console.WriteLine("***************");
            }

            Console.ReadLine ();
   }
}


