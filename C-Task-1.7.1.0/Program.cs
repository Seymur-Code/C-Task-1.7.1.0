using System;

namespace C_Task_1._7._1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Pc */
            PcAbs Pcabs1 = new PcAbs();
            Pcabs1.Name = "Dell";
            Pcabs1.Price = "830$";
            Console.WriteLine(Pcabs1.info());

            /* Washing Machine */
            WMachine wmachine1 = new WMachine();
            wmachine1.Name = "Bosch";
            wmachine1.Price = "500$";
            wmachine1.Brand = "Serie 6 WAU28TS1GB";
            Console.WriteLine(wmachine1.info());
        }
    }
}
