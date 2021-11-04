using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Task_1._7._1._0
{
    class WMachine : AbstrackTask
    {
        public override string Name { get; set; }
        public override string Price { get; set; }

        public override string Brand { get; set; }

        public override string info()
        {
            return this.Name + " - " + this.Brand +" - " + this.Price;
        }
    }
}
