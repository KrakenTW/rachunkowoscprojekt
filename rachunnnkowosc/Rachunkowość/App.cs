// Decompiled with JetBrains decompiler
// Type: Rachunkowość.App
// Assembly: Rachunkowość, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5C50F409-3FC2-4B43-B2E6-AC2E0CDC169B
// Assembly location: C:\Users\kraken\Desktop\rachunkowość kowal\Rachunkowość projekt Michał Kowalczuk, Michał Kiezik, Daniel Duchnowski\Rachunkowość.exe

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Windows;

namespace Rachunkowość
{
  public class App : Application
  {
    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    public void InitializeComponent() => this.StartupUri = new Uri("MainWindow.xaml", UriKind.Relative);

    [STAThread]
    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    public static void Main()
    {
      App app = new App();
      app.InitializeComponent();
      app.Run();
    }
  }
}
