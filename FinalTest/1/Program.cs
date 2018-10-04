using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
  class Program
  {
    static private int vietos;
    static private string prior;
    static private List<string[]> vaikai = new List<string[]>();
    static void Main(string[] args)
    {
      var ats = "";
      var txt = File.ReadAllLines("U1.txt");
      vietos = int.Parse(txt[txt.Length - 2]);
      prior = txt[txt.Length - 1];
      for (int i = 0; i < txt.Length - 2; i++)
      {
        string[] str = new string[5];
        str[0] = txt[i].Split(' ')[0] + " " + txt[i].Split(' ')[1];
        str[1] = txt[i].Split(' ')[2];
        str[2] = txt[i].Split(' ')[3];
        str[3] = txt[i].Split(' ')[4];
        str[4] = txt[i].Split(' ')[5];
        vaikai.Add(str);
      }

      foreach (var t in prior)
      {
        if (vietos > 0 && vaikai.Count > 0)
        {
          Sort(int.Parse(t.ToString()));
          var top = TopVaikai(int.Parse(t.ToString()));
          while (vietos > 0 && vaikai.Count > 0 && top > 0)
          {
            ats += vaikai[0][0];
            vaikai.RemoveAt(0);
            vietos--;
            top--;
            if (vietos > 0 && vaikai.Count > 0 && top > 0)
              ats += ", ";

          }
          if (vietos > 0 && vaikai.Count > 0)
            ats += ", ";

        }
      }
      File.WriteAllText("U1Rez.txt", ats);
    }

    static void Sort(int col)
    {
      string[] str = new string[5];
      List<string[]> lst = new List<string[]>();
      if (col == 4)
        lst = vaikai.OrderByDescending(x => x[col]).ToList();
      else lst = vaikai.OrderByDescending(x => int.Parse(x[col])).ToList();
      vaikai = lst;
    }

    static int TopVaikai(int col)
    {
      var top = 0;
      var sk = vaikai[0][col];
      var skLast = vaikai[vaikai.Count - 1][col];
      if (col > 1)
        foreach (var vaikas in vaikai)
        {
          if (col == 4 && vaikas[col] == "True") top++;
          if ((col == 3 || col == 2) && vaikas[col] == sk) top++;
        }
      else
        for (int i = vaikai.Count - 1; i >= 0; i--)
        {
          if (vaikai[i][col] == skLast) top++;
        }
      return top;
    }
  }
}
