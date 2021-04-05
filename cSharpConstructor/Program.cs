using System;

namespace cSharpConstructor
{
     
    class Program
    {
        static void Main(string[] args)
        {
            //Customer c1 = new Customer("john", "smith");
            //c1.PrintFullName();
            Customer c2 = new Customer();
            c2.PrintFullName();
            Console.WriteLine(c2.GetFullName() + " " + Customer.GetClassInfo());
            


            Location l1 = new Location("Winnipeg, Main. St. 123");

            l1.LocationName = "Winnipeg, Corydon. St. 777";
            Console.WriteLine(l1.LocationName);

            
           // Console.WriteLine(l1.GetLocationName());
            //l1.SetLocationName("Winnipeg, Corydon. St. 777");
            //Console.WriteLine(l1.GetLocationName());
            


        }
    }
}