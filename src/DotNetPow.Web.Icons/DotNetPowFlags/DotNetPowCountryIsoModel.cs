using System.Collections.Generic;
using DotNetPow.Core.Localization.Models;
using DotNetPow.Web.Icons.DotNetPowFlags;

namespace DotNetPow.Core.Addresses.Models
{
    /// <summary>
    /// .Net Pow! representation of Iso Country; copied from DotNetPow.Core.Addresses.Models
    /// </summary>
    public class DotNetPowCountryIsoModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Iso2 { get; set; }
        public string Iso3 { get; set; }
        public string Fips { get; set; }
        public string IsoNumeric { get; set; }
        public string PhoneCode { get; set; }
        public string CapitalCity { get; set; }

        public List<DotNetPowApplicationLanguageModel> Languages { get; set; } = new List<DotNetPowApplicationLanguageModel>();
        public DotNetPowFlagNames DotNetPowFlagName { get; set; } = DotNetPowFlagNames.DotNetPowAlt;
    }
}
