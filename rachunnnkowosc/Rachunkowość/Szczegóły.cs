// Decompiled with JetBrains decompiler
// Type: Rachunkowość.Szczegóły
// Assembly: Rachunkowość, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5C50F409-3FC2-4B43-B2E6-AC2E0CDC169B


using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Rachunkowość
{
  public class Szczegóły : Window, IComponentConnector
  {
    internal Button OkButton;
    internal TextBox SzczegółyTB;
    private bool _contentLoaded;

    public Szczegóły() => this.InitializeComponent();

    private void OkButton_Click(object sender, RoutedEventArgs e) => this.Close();

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    public void InitializeComponent()
    {
      if (this._contentLoaded)
        return;
      this._contentLoaded = true;
      Application.LoadComponent((object) this, new Uri("/Rachunkowość;component/szczeg%c3%b3%c5%82y.xaml", UriKind.Relative));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    void IComponentConnector.Connect(int connectionId, object target)
    {
      if (connectionId != 1)
      {
        if (connectionId == 2)
          this.SzczegółyTB = (TextBox) target;
        else
          this._contentLoaded = true;
      }
      else
      {
        this.OkButton = (Button) target;
        this.OkButton.Click += new RoutedEventHandler(this.OkButton_Click);
      }
    }
  }
}
