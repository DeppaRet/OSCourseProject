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

      public static string[] NotEmpty(bool[] visited, string[] addreses, bool[] named)
      {
        int i = 0, j = 0;
        string[] E = new string[10];
        for (int k = 0; k < 10; k++)
        {
          E[k] = "Empty";
        }
        do
        {
          var temp = i;
          if ((visited[i] == false) && (addreses[i] != "0"))
          {
            if (j < 9)
              E[j] = Convert.ToString(i);
            while (addreses[temp] != "eof")
            {
              E[j] = E[j] + ' ' + addreses[temp];
              visited[temp] = true;
              temp = Convert.ToInt32(addreses[temp]);
            }
            if (addreses[temp] == "eof")
            {
              E[j] = E[j] + ' ' + "eof";
              visited[temp] = true;
              j++;
            }
          }
          i++;
        }
        while (i < 100);
        return E;
      }
  }
}
