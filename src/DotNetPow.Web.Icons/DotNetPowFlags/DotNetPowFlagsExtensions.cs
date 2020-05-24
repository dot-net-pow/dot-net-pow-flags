using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetPow.Web.Icons.DotNetPowFlags
{
    /// <summary>
    /// Extensions for .Net Pow! Flags
    /// </summary>
    public static class DotNetPowFlagsExtensions
    {
        /// <summary>
        /// Get name of the image file for the flag.
        /// </summary>
        public static string ToDotNetPowFlagImageName(this DotNetPowFlagNames flagName) 
        {
            return StaticDotNetPowFlagDefinitions.DotNetPowFlagImages[flagName];
        }

        /// <summary>
        /// Get default folder name for defined sizes (only used if individual directories are generated).
        /// </summary>
        public static string ToDefaultImageDirectoryName(this DotNetPowFlagSizes flagSize)
        {
            switch (flagSize)
            {
                case DotNetPowFlagSizes.H20:
                    return "h20";
                case DotNetPowFlagSizes.H24:
                    return "h24";
                case DotNetPowFlagSizes.H48:
                    return "h48";
                case DotNetPowFlagSizes.H80:
                    return "h80";
                case DotNetPowFlagSizes.H120:
                    return "h120";
                case DotNetPowFlagSizes.H160:
                    return "h160";
                case DotNetPowFlagSizes.H240:
                    return "h240";
                case DotNetPowFlagSizes.W320:
                    return "w320";
                case DotNetPowFlagSizes.W550:
                    return "w550";
                case DotNetPowFlagSizes.W640:
                    return "w640";
                case DotNetPowFlagSizes.W702:
                    return "w702";
                case DotNetPowFlagSizes.W1160:
                    return "w1160";
                case DotNetPowFlagSizes.W1600:
                    return "w1600";
                case DotNetPowFlagSizes.W2560:
                    return "w2560";
                default:
                    return "h48";
            }
        }

    }
}
