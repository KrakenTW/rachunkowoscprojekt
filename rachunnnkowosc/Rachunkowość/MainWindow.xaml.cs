// Decompiled with JetBrains decompiler
// Type: Rachunkowość.MainWindow
// Assembly: Rachunkowość, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5C50F409-3FC2-4B43-B2E6-AC2E0CDC169B
// Assembly location: C:\Users\kraken\Desktop\rachunkowość kowal\Rachunkowość projekt Michał Kowalczuk, Michał Kiezik, Daniel Duchnowski\Rachunkowość.exe

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Rachunkowość
{
  public partial class MainWindow : Window, IComponentConnector
  {
    private string szczegóły = "";
    private string[] miesiace = new string[12]
    {
      "styczeń",
      "luty",
      "marzec",
      "kwiecień",
      "maj",
      "czerwiec",
      "lipiec",
      "sierpień",
      "wrzesień",
      "październik",
      "listopad",
      "grudzień"
    };
    internal TextBox DataStartMTB;
    internal TextBox DataStartRTB;
    internal TextBox WartoscTB;
    internal TextBox StawkaAmortTB;
    internal TextBox AkceleracjaTB;
    internal TextBox DataOdpisTB;
    internal TextBox WartoscOdpisTB;
    internal TextBox DataLiniowyTB;
    internal TextBox WartoscLiniowyTB;
    internal TextBox DataLiniowyMiesiacTB;
    internal TextBox WartośćLiniowyMiesiacTB;
    internal Button LiczButton;
    internal Button SzczegółyButton;
    private bool _contentLoaded;

    public MainWindow() => this.InitializeComponent();

    private void funkcja(
      double data_r,
      double data_m,
      double wartość,
      double stawka_amort,
      double akceleracja)
    {
      int num1 = 0;
      double num2 = stawka_amort * akceleracja;
      double num3 = wartość * stawka_amort;
      double num4 = num3 / 12.0;
      double num5 = wartość * num2;
      double num6 = num5 / 12.0 * (12.0 - data_m);
      this.szczegóły += "Metoda degresywna: \n";
      this.szczegóły = this.szczegóły + ((double) num1 + data_r).ToString() + " --> " + num5.ToString() + " - " + num6.ToString() + "\n";
      double num7 = wartość - num6;
      double num8;
      while (true)
      {
        ++num1;
        num8 = num7 * num2;
        if (num8 >= num3)
        {
          this.szczegóły = this.szczegóły + ((double) num1 + data_r).ToString() + " --> " + num7.ToString() + " - " + num8.ToString() + "\n";
          num7 -= num8;
        }
        else
          break;
      }
      this.szczegóły = this.szczegóły + ((double) num1 + data_r).ToString() + " --> " + ((int) num7).ToString() + " - " + num8.ToString() + " STOP!!! \n";
      this.WartoscOdpisTB.Text = ((int) num8).ToString();
      this.szczegóły += "Metoda liniowa: \n";
      int index = num1 + (int) data_r;
      this.DataOdpisTB.Text = index.ToString();
      double num9 = num7;
      this.szczegóły = this.szczegóły + index.ToString() + " --> " + ((int) num9).ToString() + " - " + num3.ToString() + "\n";
      while (true)
      {
        ++index;
        num9 -= num3;
        if (num9 >= num3)
          this.szczegóły = this.szczegóły + index.ToString() + " --> " + ((int) num9).ToString() + " - " + num3.ToString() + "\n";
        else
          break;
      }
      TextBox wartoscLiniowyTb = this.WartoscLiniowyTB;
      int num10 = (int) num9;
      string str1 = num10.ToString();
      wartoscLiniowyTb.Text = str1;
      this.DataLiniowyTB.Text = index.ToString();
      string[] strArray1 = new string[7]
      {
        this.szczegóły,
        index.ToString(),
        " --> ",
        null,
        null,
        null,
        null
      };
      num10 = (int) num9;
      strArray1[3] = num10.ToString();
      strArray1[4] = " - ";
      strArray1[5] = num3.ToString();
      strArray1[6] = " STOP!!!\n";
      this.szczegóły = string.Concat(strArray1);
      double num11 = num9;
      string[] strArray2 = new string[5]
      {
        this.szczegóły,
        this.miesiace[0].ToString(),
        " --> ",
        null,
        null
      };
      num10 = (int) num4;
      strArray2[3] = num10.ToString();
      strArray2[4] = "\n";
      this.szczegóły = string.Concat(strArray2);
      index = 0;
      while (true)
      {
        ++index;
        num11 -= num4;
        if (num11 >= num4)
        {
          string[] strArray3 = new string[5]
          {
            this.szczegóły,
            this.miesiace[index].ToString(),
            " --> ",
            null,
            null
          };
          num10 = (int) num4;
          strArray3[3] = num10.ToString();
          strArray3[4] = "\n";
          this.szczegóły = string.Concat(strArray3);
        }
        else
          break;
      }
      string[] strArray4 = new string[7]
      {
        this.szczegóły,
        this.miesiace[index].ToString(),
        " --> ",
        null,
        null,
        null,
        null
      };
      num10 = (int) num11;
      strArray4[3] = num10.ToString();
      strArray4[4] = " - ";
      strArray4[5] = num4.ToString();
      strArray4[6] = " STOP!!!\n";
      this.szczegóły = string.Concat(strArray4);
      TextBox liniowyMiesiacTb = this.WartośćLiniowyMiesiacTB;
      num10 = (int) num11;
      string str2 = num10.ToString();
      liniowyMiesiacTb.Text = str2;
      this.DataLiniowyMiesiacTB.Text = this.miesiace[index].ToString();
    }

    private void LiczButton_Click(object sender, RoutedEventArgs e)
    {
      if (string.IsNullOrEmpty(this.DataStartRTB.Text) || string.IsNullOrEmpty(this.WartoscTB.Text) || (string.IsNullOrEmpty(this.StawkaAmortTB.Text) || string.IsNullOrEmpty(this.AkceleracjaTB.Text)))
      {
        int num = (int) MessageBox.Show("Nie wszystkie pola są zapełnione!");
      }
      else
        this.funkcja(Convert.ToDouble(this.DataStartRTB.Text), Convert.ToDouble(this.DataStartMTB.Text), Convert.ToDouble(this.WartoscTB.Text), Convert.ToDouble(this.StawkaAmortTB.Text), Convert.ToDouble(this.AkceleracjaTB.Text));
      this.SzczegółyButton.IsEnabled = true;
    }

    private void SzczegółyButton_Click(object sender, RoutedEventArgs e)
    {
      Szczegóły szczegóły = new Szczegóły();
      szczegóły.Show();
      szczegóły.SzczegółyTB.Text = this.szczegóły;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    public void InitializeComponent()
    {
      if (this._contentLoaded)
        return;
      this._contentLoaded = true;
      Application.LoadComponent((object) this, new Uri("/Rachunkowość;component/mainwindow.xaml", UriKind.Relative));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    void IComponentConnector.Connect(int connectionId, object target)
    {
      switch (connectionId)
      {
        case 1:
          this.DataStartMTB = (TextBox) target;
          break;
        case 2:
          this.DataStartRTB = (TextBox) target;
          break;
        case 3:
          this.WartoscTB = (TextBox) target;
          break;
        case 4:
          this.StawkaAmortTB = (TextBox) target;
          break;
        case 5:
          this.AkceleracjaTB = (TextBox) target;
          break;
        case 6:
          this.DataOdpisTB = (TextBox) target;
          break;
        case 7:
          this.WartoscOdpisTB = (TextBox) target;
          break;
        case 8:
          this.DataLiniowyTB = (TextBox) target;
          break;
        case 9:
          this.WartoscLiniowyTB = (TextBox) target;
          break;
        case 10:
          this.DataLiniowyMiesiacTB = (TextBox) target;
          break;
        case 11:
          this.WartośćLiniowyMiesiacTB = (TextBox) target;
          break;
        case 12:
          this.LiczButton = (Button) target;
          this.LiczButton.Click += new RoutedEventHandler(this.LiczButton_Click);
          break;
        case 13:
          this.SzczegółyButton = (Button) target;
          this.SzczegółyButton.Click += new RoutedEventHandler(this.SzczegółyButton_Click);
          break;
        default:
          this._contentLoaded = true;
          break;
      }
    }
  }
}
