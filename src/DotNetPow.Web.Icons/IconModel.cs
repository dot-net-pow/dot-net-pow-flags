using System;
using System.Drawing;

namespace DotNetPow.Web.Icons
{
    /// <summary>
    /// Base class for icon libraries
    /// </summary>
    /// <typeparam name="T">Every icon library should have an enumeration of the names of the icons in the library. This should be used as the type parameter.</typeparam>
    public abstract class IconModel<T> where T : Enum
    {
        public abstract T Name { get; set; }

        public Image IconImage { get; protected set; }

        public string IconCssClass { get; protected set; }
    }
}
