using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_1
{
    public class Matematik
    {
        static public void SschetChisel (int k, out string chisla, out int sum)
        {
            sum = 666;
            sum = 0;
            int a;
            chisla = "0";
            Random r = new Random();

            while (sum<k)
            {
                a = r.Next(2, 11);
                chisla = a.ToString();
                sum += a;
            }
        }
    }
}