using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asd
{
    public class ProductionWorker : Employee
    {
        public ProductionWorker(string name, int number, int shiftnumber, decimal hourlypayrate) : base(name, number) {

            Shift = shiftnumber;
            hourlypay = hourlypayrate;
        }

        public int Shift { get; set; }
        public decimal hourlypay { get; set; }

        public override string ToString()
        {
            return base.ToString() +
                "Employee shift: " + Shift + "\r\n" +
                "Employee hourly pay: " + hourlypay + "\r\n";
            ;
        }
    }
}
