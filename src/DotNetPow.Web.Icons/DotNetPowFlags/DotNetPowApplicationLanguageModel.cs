using System.Linq;
using System.Globalization;
using DotNetPow.Web.Icons.DotNetPowFlags;

namespace DotNetPow.Core.Localization.Models
{
    /// <summary>
    /// Generic representation of CultureInfo for .Net Pow! Flags; copied from DotNetPow.Core.Localization.Models
    /// </summary>
    public class DotNetPowApplicationLanguageModel
    {
        private CultureInfo _cultureInfo;

        /// <summary>
        /// Create with CultureInfo; DotNetPowFlagName is the default
        /// </summary>
        public DotNetPowApplicationLanguageModel(CultureInfo cultureInfo)
        {
            CultureInfo = cultureInfo;
        }

        /// <summary>
        /// Create with CultureInfo and Iso Country Code, if the mapped code isn't found the default DotNetPowFlagName is used.
        /// </summary>
        public DotNetPowApplicationLanguageModel(CultureInfo cultureInfo, DotNetPowFlagNames flagName)
        {
            CultureInfo = cultureInfo;
            DotNetPowFlagName = flagName;
        }

        /// <summary>
        /// Languages must be represented with a .Net CultureInfo
        /// </summary>
        public CultureInfo CultureInfo 
        { 
            get
            {
                return _cultureInfo;
            } 
            private set
            {
                _cultureInfo = value;

                Name = _cultureInfo.Name;
                Iso2LanguageCode = _cultureInfo.TwoLetterISOLanguageName;
                Iso3LanguageCode = _cultureInfo.ThreeLetterISOLanguageName;
                DisplayName = _cultureInfo.DisplayName;
                NativeName = _cultureInfo.NativeName;
            }
        }

        /// <summary>
        /// CultureInfo.Name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// CultureInfo.TwoLetterISOLanguageName
        /// </summary>
        public string Iso2LanguageCode { get; private set; }

        /// <summary>
        /// CultureInfo.ThreeLetterISOLanguageName
        /// </summary>
        public string Iso3LanguageCode { get; private set; }

        /// <summary>
        /// CultureInfo.DisplayName
        /// </summary>
        public string DisplayName { get; private set; }

        /// <summary>
        /// CultureInfo.NativeName
        /// </summary>
        public string NativeName { get; private set; }

        /// <summary>
        /// Mapped DotNetPowFlagName
        /// </summary>
        public DotNetPowFlagNames DotNetPowFlagName { get; set; } = DotNetPowFlagNames.DotNetPowAlt;
    }
}
