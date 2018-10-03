using System;
using System.Linq;
using System.IO;

namespace Antra
{
  class Program
  {
    static void Main()
    {
      var lines = File.ReadAllLines("U2.txt").ToList();
      File.Delete("U2rez.txt");
      var stream = File.AppendText("U2rez.txt");
      int ilgis = int.Parse(lines[0].Split(' ')[0]);
      int lineNr=1;
      int plotis = int.Parse(lines[0].Split(' ')[1]);
      int colNr=1;
      lines.RemoveAt(0);

      foreach (var row in lines)
      {
        var spalva = row.Split(' ').Select(x=>int.Parse(x)).ToArray();
        var hex = DecToHex(spalva[0]) + DecToHex(spalva[1]) + DecToHex(spalva[2]);
        stream.Write(hex);
        if (colNr == plotis)
        {
          colNr = 1;
          if (lineNr<ilgis)stream.WriteLine();
          lineNr++;
        }
        else
        {
          colNr++;
          stream.Write(";");
        }

      }
      stream.Close();
      Console.ReadLine();
    }

    static string DecToHex(int dec)
    {
      string ats = dec.ToString("X");
      if (dec == 0) ats = "00";
      return ats;
    }
  }
}
