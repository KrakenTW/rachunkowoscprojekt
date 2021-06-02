
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Rachunkowość.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (Rachunkowość.Properties.Resources.resourceMan == null)
          Rachunkowość.Properties.Resources.resourceMan = new ResourceManager("Rachunkowość.Properties.Resources", typeof (Rachunkowość.Properties.Resources).Assembly);
        return Rachunkowość.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => Rachunkowość.Properties.Resources.resourceCulture;
      set => Rachunkowość.Properties.Resources.resourceCulture = value;
    }
  }
}
