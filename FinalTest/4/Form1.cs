using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button_0_Click(object sender, EventArgs e)
    {
      if (textBox_Main.Text.Length < 11)
        if (textBox_Main.Text.Length > 0)
        {
          if (textBox_Main.Text.Length > 1 || textBox_Main.Text[0] != '0') textBox_Main.Text += "0";
        }
        else
          textBox_Main.Text = "0";
    }

    private void button_1_Click(object sender, EventArgs e)
    {
      if (textBox_Main.Text.Length < 11) textBox_Main.Text += "1";
    }

    private void button_2_Click(object sender, EventArgs e)
    {
      if (textBox_Main.Text.Length < 11) textBox_Main.Text += "2";
    }

    private void button_3_Click(object sender, EventArgs e)
    {
      if (textBox_Main.Text.Length < 11) textBox_Main.Text += "3";
    }

    private void button_4_Click(object sender, EventArgs e)
    {
      if (textBox_Main.Text.Length < 11) textBox_Main.Text += "4";
    }

    private void button_5_Click(object sender, EventArgs e)
    {
      if (textBox_Main.Text.Length < 11) textBox_Main.Text += "5";
    }

    private void button_6_Click(object sender, EventArgs e)
    {
      if (textBox_Main.Text.Length < 11) textBox_Main.Text += "6";
    }

    private void button_7_Click(object sender, EventArgs e)
    {
      if (textBox_Main.Text.Length < 11) textBox_Main.Text += "7";
    }

    private void button_8_Click(object sender, EventArgs e)
    {
      if (textBox_Main.Text.Length < 11) textBox_Main.Text += "8";
    }

    private void button_9_Click(object sender, EventArgs e)
    {
      if (textBox_Main.Text.Length < 11) textBox_Main.Text += "9";
    }

    private void button_Dot_Click(object sender, EventArgs e)
    {
      if (textBox_Main.Text.Length == 0)
      {
        textBox_Main.Text = "0.";
      }
      else if (!textBox_Main.Text.Contains(".")) textBox_Main.Text += ".";
    }

    private void button_Clear_Click(object sender, EventArgs e)
    {
      textBox_Main.Text = "";
    }

    private void button_Equals_Click(object sender, EventArgs e)
    {
      textBox_calk.Text += textBox_Main.Text;
      var history = textBox_calk.Text;
      textBox_Main.Text = DoMath(textBox_calk.Text).ToString();
      textBox_calk.Text = history + "=" + textBox_Main.Text;
      AddHistory();
      textBox_calk.Text = "";
    }

    private void button_Plus_Click(object sender, EventArgs e)
    {
      veiksmas('+');
    }

    private double DoMath(string row)
    {
      double[] numbers = new double[2];
      var veiksmasGale = "";
      var mat = ' ';
      if (row[row.Length - 1] != '√')
      {
        if (row[row.Length - 1] < '0' || row[row.Length - 1] > '9')
        {
          veiksmasGale = row[row.Length - 1].ToString();
          row = row.Remove(row.Length - 1, 1);
        }
      }
      else mat = row[row.Length - 1];

      var minusasA = false;
      var minusasB = false;
      if (row[0] == '-')
      {
        minusasA = true;
        row = row.Remove(0, 1);
      }

      int num = 0;
      foreach (var ch in row)
      {
        if ("+-÷×√^".Contains(ch))
        {
          if (num == 0)
          {
            mat = ch;
            num++;
          }
          else if (ch == '-') minusasB = true;
        }
        else
          numbers[num] = double.Parse(numbers[num].ToString() + ch);
      }
      row = row + veiksmasGale;
      if (minusasA) numbers[0] = -numbers[0];
      if (minusasB) numbers[1] = -numbers[1];
      double ats = numbers[0];
      switch (mat)
      {
        case '^':
          ats += Math.Pow(numbers[0], numbers[1]);
          break;
        case '√':
          ats = Math.Sqrt(numbers[0]);
          break;
        case '+':
          ats = numbers[0] + numbers[1];
          break;
        case '-':
          ats = numbers[0] - numbers[1];
          break;
        case '×':
          ats = numbers[0] * numbers[1];
          break;
        case '÷':
          ats = numbers[0] / numbers[1];
          break;
      }
      return ats;
    }

    private void veiksmas(char veiksm)
    {
      if (textBox_Main.Text.Length > 0)
      {
        bool skaiciuok = textBox_calk.Text.Length > 0;
        if (veiksm == '√')
        {
          if (textBox_calk.Text.Length > 0)
            textBox_History.Text += textBox_Main.Text + '√' + System.Environment.NewLine;
          textBox_Main.Text = DoMath(textBox_Main.Text + veiksm).ToString();
        }
        if (textBox_Main.Text[textBox_Main.Text.Length - 1] == '.')
          textBox_calk.Text += textBox_Main.Text.Remove(0, textBox_Main.Text.Length - 1);
        else textBox_calk.Text += textBox_Main.Text;
        textBox_Main.Text = "";
        if (skaiciuok) textBox_calk.Text = DoMath(textBox_calk.Text).ToString();
        if (textBox_calk.Text.Length > 0)
        {
          textBox_calk.Text += veiksm;
          AddHistory();
        }

        //if (veiksm == '√')
        //{
        //  textBox_Main.Text = DoMath(textBox_calk.Text).ToString();
        //  textBox_calk.Text = "";
        //};
      }
    }

    private void AddHistory()
    {
      textBox_History.AppendText(textBox_calk.Text + System.Environment.NewLine);
    }
    private void button_Minus_Click(object sender, EventArgs e)
    {
      veiksmas('-');
    }

    private void button_x_Click(object sender, EventArgs e)
    {
      veiksmas('×');
    }

    private void button_Div_Click(object sender, EventArgs e)
    {
      veiksmas('÷');
    }

    private void button_BackSpace_Click(object sender, EventArgs e)
    {
      if (textBox_Main.Text.Length > 0) textBox_Main.Text = textBox_Main.Text.Remove(textBox_Main.Text.Length - 1, 1);
    }

    private void button_SRoot_Click(object sender, EventArgs e)
    {
      veiksmas('√');
    }

    private void button_Exp_Click(object sender, EventArgs e)
    {
      veiksmas('^');
    }

    private void button_PlusMinus_Click(object sender, EventArgs e)
    {
      if (textBox_Main.Text.Length > 0)
      {
        if (textBox_Main.Text[0] == '-') textBox_Main.Text = textBox_Main.Text.Remove(1, 1);
        else textBox_Main.Text = "-" + textBox_Main.Text;
      }
    }
  }
}

