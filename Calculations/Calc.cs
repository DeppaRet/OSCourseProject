using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    public class Calc
    {
      public string Result(string fName, string start, string[] addreses, bool[] visited)
      {
        string tmp = " ";
        string resulted = "";
        int temp = 0;
        temp = Convert.ToInt32(start);
        tmp += start;
        do
        {
          tmp = tmp + ' ' + addreses[temp];
          visited[temp] = true;
          temp = Convert.ToInt32(addreses[temp]);
        } while (addreses[temp] != "eof");

        visited[temp] = true;
        tmp = tmp + ' ' + "eof";
        resulted += (fName+ ":" + tmp + "\n");
        return resulted;
      }
    }
}
