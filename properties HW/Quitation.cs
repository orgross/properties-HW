using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties_HW
{
    internal class Quitation
    {
        public string CostumerName { get; private set; }
        public double[] SumLines { get; set; }
        private double Docsum;
        public double DocSum
        {
            get
            {
                for (int i = 0; i < SumLines.Length; i++) ;
                    return Docsum;
            }
        }
        public DateTime VaildUntil { get; private set; }
        public Quitation()
        {

        }

        public Quitation(string costumerName, double[] sumLines, DateTime vaildUntil)
        {
            CostumerName = costumerName;
            costumerName = "or";
            SumLines = sumLines;
            VaildUntil = vaildUntil;
            vaildUntil = DateTime.Now;
        }

        public void ChangeMainDEtails()
        {
            Console.WriteLine("enter your name");
            CostumerName=Console.ReadLine();
            VaildUntil=DateTime.Now.AddDays(27);
        }


    }
}
