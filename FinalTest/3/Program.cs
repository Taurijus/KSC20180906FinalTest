using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
  class Program
  {
    static List<int> gang = new List<int>();
    static void Main(string[] args)
    {
      Console.WriteLine("Imput:");
      int count = int.Parse(Console.ReadLine());
      Console.WriteLine("Output:");
      if (count > 0)
        for (int i = 0; i < count; i++)
          gang.Add(i + 1);
      KillNextAfter(gang,1);

      Console.WriteLine("Kelinta romėna iš kairės kirsti? - ");
      int nextAfter = int.Parse(Console.ReadLine());
      Console.WriteLine("Output:");
      gang = new List<int>();
      if (count > 0)
        for (int i = 0; i < count; i++)
          gang.Add(i + 1);
      KillNextAfter(gang, nextAfter);
      Console.ReadLine();
    }

    static void KillNextAfter(List<int> gang, int NextAfter)
    {
      if (gang.Count > 1)
      {
        //int index = 0;
        //for (int i = 0; i < NextAfter; i++)
        //{
        //  if (index == gang.Count - 1) index = 0;
        //  else index++;
        //}
        //Pasiliksiu prie matematinio ir rekursinio mix sprendimo
        int index = NextAfter - NextAfter / gang.Count * gang.Count;
        if (index > 0) gang.AddRange(gang.Where((x, i) => i < index).ToList());
        gang.RemoveRange(0, index+1);
        KillNextAfter(gang, NextAfter);
      }
      else Console.WriteLine(gang[0]);
    }
  }
}
