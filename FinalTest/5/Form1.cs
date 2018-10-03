using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5
{
  public partial class Form_CopyResult : Form
  {
    static Dictionary<char, char> rot = new Dictionary<char, char>();
    static Dictionary<char, int> key = new Dictionary<char, int>();
    static Dictionary<int, char> keyInvert = new Dictionary<int, char>();


    public Form_CopyResult()
    {
      InitializeComponent();
      PrepareROTLVL(13, "Koduoti");
    }

    private void PrepareROTLVL(int lvl, string kd)
    {
      if (!comboBox1.Enabled) return;
      rot = new Dictionary<char, char>();
      if (kd == "Koduoti")
      {
        for (char i = 'A'; i <= 'Z'; i++)
        {
          if ((char)(i + lvl) <= 'Z')
            rot.Add(i, (char)(i + lvl));
          else rot.Add(i, (char)(i + lvl - 26));
        }

        for (char i = 'a'; i <= 'z'; i++)
        {
          if ((char)(i + lvl) <= 'z')
            rot.Add(i, (char)(i + lvl));
          else rot.Add(i, (char)(i + lvl - 26));
        }
      }
      else
      {
        for (char i = 'Z'; i >= 'A'; i--)
        {
          if ((char)(i - lvl) >= 'A')
            rot.Add(i, (char)(i - lvl));
          else rot.Add(i, (char)(i - lvl + 26));
        }

        for (char i = 'z'; i >= 'a'; i--)
        {
          if ((char)(i - lvl) >= 'a')
            rot.Add(i, (char)(i - lvl));
          else rot.Add(i, (char)(i - lvl + 26));
        }
      }
    }

    private void PrepareKey()
    {
      key = new Dictionary<char, int>();
      keyInvert = new Dictionary<int, char>();
      int nr = 0;
      for (char i = 'a'; i <= 'z'; i++)
      {
        key.Add(i, nr);
        keyInvert.Add(nr, i);
        nr++;
      }
      for (char i = 'A'; i <= 'Z'; i++)
      {
        key.Add(i, nr);
        keyInvert.Add(nr, i);
        nr++;
      }
    }

    private void DoROT()
    {
      textBox_Result.Text = "";
      foreach (var raide in textBox_Enter.Text)
      {
        if (rot.ContainsKey(raide)) textBox_Result.Text += rot[raide];
        else textBox_Result.Text += raide;
      }
    }

    private void DoKey()
    {
      textBox_Result.Text = "";
      if (comboBox2.Text == "Koduoti")
      {
        int keyNr = 0;
        foreach (var raide in textBox_Enter.Text)
        {
          if (key.ContainsKey(raide) && key.ContainsKey(textBox_Raktas.Text[keyNr]))
          {
            var rez = key[raide] + key[textBox_Raktas.Text[keyNr]];
            if (rez >= 52) rez -= 52;
            textBox_Result.Text += keyInvert[rez];
          }
          else
            textBox_Result.Text += raide;
          keyNr++;
          if (keyNr >= textBox_Raktas.Text.Length) keyNr = 0;
        }
      }
      else
      {
        int keyNr = 0;
        foreach (var raide in textBox_Enter.Text)
        {
          if (key.ContainsKey(raide) && key.ContainsKey(textBox_Raktas.Text[keyNr]))
          {
            var rez = key[raide] - key[textBox_Raktas.Text[keyNr]];
            if (rez < 0) rez += 52;
            textBox_Result.Text += keyInvert[rez];
          }
          else
            textBox_Result.Text += raide;
          keyNr++;
          if (keyNr >= textBox_Raktas.Text.Length) keyNr = 0;
        }
      }
    }

    private void textBox_Enter_TextChanged(object sender, EventArgs e)
    {
      if (comboBox1.Enabled) DoROT();
      else DoKey();
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      PrepareROTLVL(int.Parse(comboBox1.Text), comboBox2.Text);
      DoROT();
    }

    private void button_OpenFile_Click(object sender, EventArgs e)
    {
      DialogResult browseFile = openFileDialog1.ShowDialog();
      if (browseFile == DialogResult.OK)
      {
        textBox_Enter.Text = File.ReadAllText(openFileDialog1.FileName);
      }
    }

    private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (comboBox1.Enabled)
      {
        PrepareROTLVL(int.Parse(comboBox1.Text), comboBox2.Text);
        DoROT();
      }
      else DoKey();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      DialogResult browseFile = openFileDialog1.ShowDialog();
      if (browseFile == DialogResult.OK)
      {
        textBox_Raktas.Text = File.ReadAllText(openFileDialog1.FileName);
      }
    }

    private void textBox_Raktas_TextChanged(object sender, EventArgs e)
    {
      if (textBox_Raktas.Text.Length > 0)
      {
        comboBox1.Enabled = false;
        PrepareKey();
        DoKey();
      }
      else
      {
        PrepareROTLVL(int.Parse(comboBox1.Text), comboBox2.Text);
        comboBox1.Enabled = true;
        DoROT();
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      textBox_Enter.Text = textBox_Result.Text;
      if (comboBox1.Enabled) DoROT();
      else DoKey();
    }

    private void comboBox1_EnabledChanged(object sender, EventArgs e)
    {
      if (comboBox1.Enabled)
      {
        PrepareROTLVL(int.Parse( comboBox1.Text),comboBox2.Text);
        DoROT();
      }
    }
  }
}
