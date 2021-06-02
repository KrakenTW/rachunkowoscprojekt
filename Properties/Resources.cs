
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Rachunkowosc.Properties
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
                if (Rachunkowosc.Properties.Resources.resourceMan == null)
                    Rachunkowosc.Properties.Resources.resourceMan = new ResourceManager("Rachunkowosc.Properties.Resources", typeof(Rachunkowosc.Properties.Resources).Assembly);
                return Rachunkowosc.Properties.Resources.resourceMan;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture
        {
            get => Rachunkowosc.Properties.Resources.resourceCulture;
            set => Rachunkowosc.Properties.Resources.resourceCulture = value;
        }
    }
}
