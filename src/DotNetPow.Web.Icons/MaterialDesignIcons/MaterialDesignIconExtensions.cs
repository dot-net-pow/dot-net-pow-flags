using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetPow.Web.Icons.MaterialDesignIcons
{
    /// <summary>
    /// Extensions for Material Design Icons
    /// </summary>
    public static class MaterialDesignIconExtensions
    {
        /// <summary>
        /// Get the Material Design Icon CSS Class
        /// </summary>
        public static string ToMaterialDesignCssClass(this MaterialDesignIconNames iconName)
        {
            return StaticMaterialDesignIconDefinitions.MaterialDesignIconCssClasses[iconName];
        }
    }
}
