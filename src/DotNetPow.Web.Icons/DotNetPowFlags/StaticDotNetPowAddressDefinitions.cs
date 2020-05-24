using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using DotNetPow.Core.Addresses.Models;
using DotNetPow.Core.Localization.Models;
using DotNetPow.Web.Icons.DotNetPowFlags;

namespace DotNetPow.Core.Addresses
{
    /// <summary>
    /// Partial copy from the DotNetPow.Core.Addresses library
    /// </summary>
    public static class StaticDotNetPowAddressDefinitions
    {
        /// <summary>
        /// List of .Net Pow! country models.
        /// </summary>
        private static List<DotNetPowCountryIsoModel> _dotNetPowCountryIsoModels;

        /// <summary>
        /// Static list of Iso countries, database driven and updated frequently in .Net Pow!
        /// </summary>
        public static ReadOnlyCollection<DotNetPowCountryIsoModel> DotNetPowCountryIsoModels
        {
            get
            {
                if (_dotNetPowCountryIsoModels == null)
                {
                    _dotNetPowCountryIsoModels = new List<DotNetPowCountryIsoModel>
                    {
                        new DotNetPowCountryIsoModel { Id = -1, Name = "Dot Net Pow", Iso2 = "dnp-rocks", Iso3 = "", Fips = "", IsoNumeric = "", PhoneCode = "", CapitalCity = "Awesome", DotNetPowFlagName = DotNetPowFlagNames.DotNetPow },
                        new DotNetPowCountryIsoModel { Id = -2, Name = "Dot Net Pow Alt", Iso2 = "dnp-rocks-alt", Iso3 = "", Fips = "", IsoNumeric = "", PhoneCode = "", CapitalCity = "Awesome", DotNetPowFlagName = DotNetPowFlagNames.DotNetPowAlt },
                        new DotNetPowCountryIsoModel { Id = 60, Name = "Afghanistan", Iso2 = "AF", Iso3 = "AFG", Fips = "AF", IsoNumeric = "4", PhoneCode = "93", CapitalCity = "Kabul", DotNetPowFlagName = DotNetPowFlagNames.Afghanistan },
                        new DotNetPowCountryIsoModel { Id = 243, Name = "Aland Islands", Iso2 = "AX", Iso3 = "ALA", Fips = "", IsoNumeric = "248", PhoneCode = "358", CapitalCity = "Mariehamn", DotNetPowFlagName = DotNetPowFlagNames.Aland_Islands },
                        new DotNetPowCountryIsoModel { Id = 112, Name = "Albania", Iso2 = "AL", Iso3 = "ALB", Fips = "AL", IsoNumeric = "8", PhoneCode = "355", CapitalCity = "Tirana", DotNetPowFlagName = DotNetPowFlagNames.Albania },
                        new DotNetPowCountryIsoModel { Id = 1, Name = "Algeria", Iso2 = "DZ", Iso3 = "DZA", Fips = "AG", IsoNumeric = "12", PhoneCode = "213", CapitalCity = "Algiers", DotNetPowFlagName = DotNetPowFlagNames.Algeria },
                        new DotNetPowCountryIsoModel { Id = 203, Name = "American Samoa", Iso2 = "AS", Iso3 = "ASM", Fips = "AQ", IsoNumeric = "16", PhoneCode = "1-684", CapitalCity = "Pago Pago", DotNetPowFlagName = DotNetPowFlagNames.American_Samoa },
                        new DotNetPowCountryIsoModel { Id = 113, Name = "Andorra", Iso2 = "AD", Iso3 = "AND", Fips = "AN", IsoNumeric = "20", PhoneCode = "376", CapitalCity = "Andorra la Vella", DotNetPowFlagName = DotNetPowFlagNames.Andorra },
                        new DotNetPowCountryIsoModel { Id = 2, Name = "Angola", Iso2 = "AO", Iso3 = "AGO", Fips = "AO", IsoNumeric = "24", PhoneCode = "244", CapitalCity = "Luanda", DotNetPowFlagName = DotNetPowFlagNames.Angola },
                        new DotNetPowCountryIsoModel { Id = 164, Name = "Anguilla", Iso2 = "AI", Iso3 = "AIA", Fips = "AV", IsoNumeric = "660", PhoneCode = "1-264", CapitalCity = "The Valley", DotNetPowFlagName = DotNetPowFlagNames.Anguilla },
                        new DotNetPowCountryIsoModel { Id = 59, Name = "Antarctica", Iso2 = "AQ", Iso3 = "ATA", Fips = "AY", IsoNumeric = "10", PhoneCode = "672", CapitalCity = "-", DotNetPowFlagName = DotNetPowFlagNames.Antarctica },
                        new DotNetPowCountryIsoModel { Id = 165, Name = "Antigua and Barbuda", Iso2 = "AG", Iso3 = "ATG", Fips = "AC", IsoNumeric = "28", PhoneCode = "1-268", CapitalCity = "St. Johns", DotNetPowFlagName = DotNetPowFlagNames.Antigua_And_Barbuda },
                        new DotNetPowCountryIsoModel { Id = 228, Name = "Argentina", Iso2 = "AR", Iso3 = "ARG", Fips = "AR", IsoNumeric = "32", PhoneCode = "54", CapitalCity = "Buenos Aires", DotNetPowFlagName = DotNetPowFlagNames.Argentina },
                        new DotNetPowCountryIsoModel { Id = 61, Name = "Armenia", Iso2 = "AM", Iso3 = "ARM", Fips = "AM", IsoNumeric = "51", PhoneCode = "374", CapitalCity = "Yerevan", DotNetPowFlagName = DotNetPowFlagNames.Armenia },
                        new DotNetPowCountryIsoModel { Id = 166, Name = "Aruba", Iso2 = "AW", Iso3 = "ABW", Fips = "AA", IsoNumeric = "533", PhoneCode = "297", CapitalCity = "Oranjestad", DotNetPowFlagName = DotNetPowFlagNames.Aruba },
                        new DotNetPowCountryIsoModel { Id = 204, Name = "Australia", Iso2 = "AU", Iso3 = "AUS", Fips = "AS", IsoNumeric = "36", PhoneCode = "61", CapitalCity = "Canberra", DotNetPowFlagName = DotNetPowFlagNames.Australia },
                        new DotNetPowCountryIsoModel { Id = 114, Name = "Austria", Iso2 = "AT", Iso3 = "AUT", Fips = "AU", IsoNumeric = "40", PhoneCode = "43", CapitalCity = "Vienna", DotNetPowFlagName = DotNetPowFlagNames.Austria },
                        new DotNetPowCountryIsoModel { Id = 62, Name = "Azerbaijan", Iso2 = "AZ", Iso3 = "AZE", Fips = "AJ", IsoNumeric = "31", PhoneCode = "994", CapitalCity = "Baku", DotNetPowFlagName = DotNetPowFlagNames.Azerbaijan },
                        new DotNetPowCountryIsoModel { Id = 167, Name = "Bahamas", Iso2 = "BS", Iso3 = "BHS", Fips = "BF", IsoNumeric = "44", PhoneCode = "1-242", CapitalCity = "Nassau", DotNetPowFlagName = DotNetPowFlagNames.Bahamas },
                        new DotNetPowCountryIsoModel { Id = 63, Name = "Bahrain", Iso2 = "BH", Iso3 = "BHR", Fips = "BA", IsoNumeric = "48", PhoneCode = "973", CapitalCity = "Manama", DotNetPowFlagName = DotNetPowFlagNames.Bahrain },
                        new DotNetPowCountryIsoModel { Id = 64, Name = "Bangladesh", Iso2 = "BD", Iso3 = "BGD", Fips = "BG", IsoNumeric = "50", PhoneCode = "880", CapitalCity = "Dhaka", DotNetPowFlagName = DotNetPowFlagNames.Bangladesh },
                        new DotNetPowCountryIsoModel { Id = 168, Name = "Barbados", Iso2 = "BB", Iso3 = "BRB", Fips = "BB", IsoNumeric = "52", PhoneCode = "1-246", CapitalCity = "Bridgetown", DotNetPowFlagName = DotNetPowFlagNames.Barbados },
                        new DotNetPowCountryIsoModel { Id = 115, Name = "Belarus", Iso2 = "BY", Iso3 = "BLR", Fips = "BO", IsoNumeric = "112", PhoneCode = "375", CapitalCity = "Minsk", DotNetPowFlagName = DotNetPowFlagNames.Belarus },
                        new DotNetPowCountryIsoModel { Id = 116, Name = "Belgium", Iso2 = "BE", Iso3 = "BEL", Fips = "BE", IsoNumeric = "56", PhoneCode = "32", CapitalCity = "Brussels", DotNetPowFlagName = DotNetPowFlagNames.Belgium },
                        new DotNetPowCountryIsoModel { Id = 169, Name = "Belize", Iso2 = "BZ", Iso3 = "BLZ", Fips = "BH", IsoNumeric = "84", PhoneCode = "501", CapitalCity = "Belmopan", DotNetPowFlagName = DotNetPowFlagNames.Belize },
                        new DotNetPowCountryIsoModel { Id = 3, Name = "Benin", Iso2 = "BJ", Iso3 = "BEN", Fips = "BN", IsoNumeric = "204", PhoneCode = "229", CapitalCity = "Porto-Novo", DotNetPowFlagName = DotNetPowFlagNames.Benin },
                        new DotNetPowCountryIsoModel { Id = 170, Name = "Bermuda", Iso2 = "BM", Iso3 = "BMU", Fips = "BD", IsoNumeric = "60", PhoneCode = "1-441", CapitalCity = "Hamilton", DotNetPowFlagName = DotNetPowFlagNames.Bermuda },
                        new DotNetPowCountryIsoModel { Id = 65, Name = "Bhutan", Iso2 = "BT", Iso3 = "BTN", Fips = "BT", IsoNumeric = "64", PhoneCode = "975", CapitalCity = "Thimphu", DotNetPowFlagName = DotNetPowFlagNames.Bhutan },
                        new DotNetPowCountryIsoModel { Id = 229, Name = "Bolivia", Iso2 = "BO", Iso3 = "BOL", Fips = "BL", IsoNumeric = "68", PhoneCode = "591", CapitalCity = "Sucre", DotNetPowFlagName = DotNetPowFlagNames.Bolivia },
                        new DotNetPowCountryIsoModel { Id = 117, Name = "Bosnia and Herzegovina", Iso2 = "BA", Iso3 = "BIH", Fips = "BK", IsoNumeric = "70", PhoneCode = "387", CapitalCity = "Sarajevo", DotNetPowFlagName = DotNetPowFlagNames.Bosnia_And_Herzegovina },
                        new DotNetPowCountryIsoModel { Id = 4, Name = "Botswana", Iso2 = "BW", Iso3 = "BWA", Fips = "BC", IsoNumeric = "72", PhoneCode = "267", CapitalCity = "Gaborone", DotNetPowFlagName = DotNetPowFlagNames.Botswana },
                        new DotNetPowCountryIsoModel { Id = 230, Name = "Brazil", Iso2 = "BR", Iso3 = "BRA", Fips = "BR", IsoNumeric = "76", PhoneCode = "55", CapitalCity = "Brasilia", DotNetPowFlagName = DotNetPowFlagNames.Brazil },
                        new DotNetPowCountryIsoModel { Id = 66, Name = "British Indian Ocean Territory", Iso2 = "IO", Iso3 = "IOT", Fips = "IO", IsoNumeric = "86", PhoneCode = "246", CapitalCity = "Diego Garcia", DotNetPowFlagName = DotNetPowFlagNames.British_Indian_Ocean_Territory },
                        new DotNetPowCountryIsoModel { Id = 171, Name = "British Virgin Islands", Iso2 = "VG", Iso3 = "VGB", Fips = "VI", IsoNumeric = "92", PhoneCode = "1-284", CapitalCity = "Road Town", DotNetPowFlagName = DotNetPowFlagNames.British_Virgin_Islands },
                        new DotNetPowCountryIsoModel { Id = 67, Name = "Brunei", Iso2 = "BN", Iso3 = "BRN", Fips = "BX", IsoNumeric = "96", PhoneCode = "673", CapitalCity = "Bandar Seri Begawan", DotNetPowFlagName = DotNetPowFlagNames.Brunei },
                        new DotNetPowCountryIsoModel { Id = 118, Name = "Bulgaria", Iso2 = "BG", Iso3 = "BGR", Fips = "BU", IsoNumeric = "100", PhoneCode = "359", CapitalCity = "Sofia", DotNetPowFlagName = DotNetPowFlagNames.Bulgaria },
                        new DotNetPowCountryIsoModel { Id = 5, Name = "Burkina Faso", Iso2 = "BF", Iso3 = "BFA", Fips = "UV", IsoNumeric = "854", PhoneCode = "226", CapitalCity = "Ouagadougou", DotNetPowFlagName = DotNetPowFlagNames.Burkina_Faso },
                        new DotNetPowCountryIsoModel { Id = 6, Name = "Burundi", Iso2 = "BI", Iso3 = "BDI", Fips = "BY", IsoNumeric = "108", PhoneCode = "257", CapitalCity = "Bujumbura", DotNetPowFlagName = DotNetPowFlagNames.Burundi },
                        new DotNetPowCountryIsoModel { Id = 68, Name = "Cambodia", Iso2 = "KH", Iso3 = "KHM", Fips = "CB", IsoNumeric = "116", PhoneCode = "855", CapitalCity = "Phnom Penh", DotNetPowFlagName = DotNetPowFlagNames.Cambodia },
                        new DotNetPowCountryIsoModel { Id = 7, Name = "Cameroon", Iso2 = "CM", Iso3 = "CMR", Fips = "CM", IsoNumeric = "120", PhoneCode = "237", CapitalCity = "Yaounde", DotNetPowFlagName = DotNetPowFlagNames.Cameroon },
                        new DotNetPowCountryIsoModel { Id = 172, Name = "Canada", Iso2 = "CA", Iso3 = "CAN", Fips = "CA", IsoNumeric = "124", PhoneCode = "1", CapitalCity = "Ottawa", DotNetPowFlagName = DotNetPowFlagNames.Canada },
                        new DotNetPowCountryIsoModel { Id = 8, Name = "Cape Verde", Iso2 = "CV", Iso3 = "CPV", Fips = "CV", IsoNumeric = "132", PhoneCode = "238", CapitalCity = "Praia", DotNetPowFlagName = DotNetPowFlagNames.Cape_Verde },
                        new DotNetPowCountryIsoModel { Id = 173, Name = "Cayman Islands", Iso2 = "KY", Iso3 = "CYM", Fips = "CJ", IsoNumeric = "136", PhoneCode = "1-345", CapitalCity = "George Town", DotNetPowFlagName = DotNetPowFlagNames.Cayman_Islands },
                        new DotNetPowCountryIsoModel { Id = 9, Name = "Central African Republic", Iso2 = "CF", Iso3 = "CAF", Fips = "CT", IsoNumeric = "140", PhoneCode = "236", CapitalCity = "Bangui", DotNetPowFlagName = DotNetPowFlagNames.Central_African_Republic },
                        new DotNetPowCountryIsoModel { Id = 10, Name = "Chad", Iso2 = "TD", Iso3 = "TCD", Fips = "CD", IsoNumeric = "148", PhoneCode = "235", CapitalCity = "N'Djamena", DotNetPowFlagName = DotNetPowFlagNames.Chad },
                        new DotNetPowCountryIsoModel { Id = 231, Name = "Chile", Iso2 = "CL", Iso3 = "CHL", Fips = "CI", IsoNumeric = "152", PhoneCode = "56", CapitalCity = "Santiago", DotNetPowFlagName = DotNetPowFlagNames.Chile },
                        new DotNetPowCountryIsoModel { Id = 69, Name = "China", Iso2 = "CN", Iso3 = "CHN", Fips = "CH", IsoNumeric = "156", PhoneCode = "86", CapitalCity = "Beijing", DotNetPowFlagName = DotNetPowFlagNames.China },
                        new DotNetPowCountryIsoModel { Id = 70, Name = "Christmas Island", Iso2 = "CX", Iso3 = "CXR", Fips = "KT", IsoNumeric = "162", PhoneCode = "61", CapitalCity = "Flying Fish Cove", DotNetPowFlagName = DotNetPowFlagNames.Christmas_Island },
                        new DotNetPowCountryIsoModel { Id = 71, Name = "Cocos Islands", Iso2 = "CC", Iso3 = "CCK", Fips = "CK", IsoNumeric = "166", PhoneCode = "61", CapitalCity = "West Island", DotNetPowFlagName = DotNetPowFlagNames.Cocos_Islands },
                        new DotNetPowCountryIsoModel { Id = 232, Name = "Colombia", Iso2 = "CO", Iso3 = "COL", Fips = "CO", IsoNumeric = "170", PhoneCode = "57", CapitalCity = "Bogota", DotNetPowFlagName = DotNetPowFlagNames.Colombia },
                        new DotNetPowCountryIsoModel { Id = 11, Name = "Comoros", Iso2 = "KM", Iso3 = "COM", Fips = "CN", IsoNumeric = "174", PhoneCode = "269", CapitalCity = "Moroni", DotNetPowFlagName = DotNetPowFlagNames.Comoros },
                        new DotNetPowCountryIsoModel { Id = 205, Name = "Cook Islands", Iso2 = "CK", Iso3 = "COK", Fips = "CW", IsoNumeric = "184", PhoneCode = "682", CapitalCity = "Avarua", DotNetPowFlagName = DotNetPowFlagNames.Cook_Islands },
                        new DotNetPowCountryIsoModel { Id = 174, Name = "Costa Rica", Iso2 = "CR", Iso3 = "CRI", Fips = "CS", IsoNumeric = "188", PhoneCode = "506", CapitalCity = "San Jose", DotNetPowFlagName = DotNetPowFlagNames.Costa_Rica },
                        new DotNetPowCountryIsoModel { Id = 119, Name = "Croatia", Iso2 = "HR", Iso3 = "HRV", Fips = "HR", IsoNumeric = "191", PhoneCode = "385", CapitalCity = "Zagreb", DotNetPowFlagName = DotNetPowFlagNames.Croatia },
                        new DotNetPowCountryIsoModel { Id = 175, Name = "Cuba", Iso2 = "CU", Iso3 = "CUB", Fips = "CU", IsoNumeric = "192", PhoneCode = "53", CapitalCity = "Havana", DotNetPowFlagName = DotNetPowFlagNames.Cuba },
                        new DotNetPowCountryIsoModel { Id = 176, Name = "Curacao", Iso2 = "CW", Iso3 = "CUW", Fips = "UC", IsoNumeric = "531", PhoneCode = "599", CapitalCity = "Willemstad", DotNetPowFlagName = DotNetPowFlagNames.Curacao },
                        new DotNetPowCountryIsoModel { Id = 120, Name = "Cyprus", Iso2 = "CY", Iso3 = "CYP", Fips = "CY", IsoNumeric = "196", PhoneCode = "357", CapitalCity = "Nicosia", DotNetPowFlagName = DotNetPowFlagNames.Cyprus },
                        new DotNetPowCountryIsoModel { Id = 121, Name = "Czech Republic", Iso2 = "CZ", Iso3 = "CZE", Fips = "EZ", IsoNumeric = "203", PhoneCode = "420", CapitalCity = "Prague", DotNetPowFlagName = DotNetPowFlagNames.Czech_Republic },
                        new DotNetPowCountryIsoModel { Id = 12, Name = "Democratic Republic of the Congo", Iso2 = "CD", Iso3 = "COD", Fips = "CG", IsoNumeric = "180", PhoneCode = "243", CapitalCity = "Kinshasa", DotNetPowFlagName = DotNetPowFlagNames.Democratic_Republic_of_the_Congo },
                        new DotNetPowCountryIsoModel { Id = 122, Name = "Denmark", Iso2 = "DK", Iso3 = "DNK", Fips = "DA", IsoNumeric = "208", PhoneCode = "45", CapitalCity = "Copenhagen", DotNetPowFlagName = DotNetPowFlagNames.Denmark },
                        new DotNetPowCountryIsoModel { Id = 13, Name = "Djibouti", Iso2 = "DJ", Iso3 = "DJI", Fips = "DJ", IsoNumeric = "262", PhoneCode = "253", CapitalCity = "Djibouti", DotNetPowFlagName = DotNetPowFlagNames.Djibouti },
                        new DotNetPowCountryIsoModel { Id = 177, Name = "Dominica", Iso2 = "DM", Iso3 = "DMA", Fips = "DO", IsoNumeric = "212", PhoneCode = "1-767", CapitalCity = "Roseau", DotNetPowFlagName = DotNetPowFlagNames.Dominica },
                        new DotNetPowCountryIsoModel { Id = 178, Name = "Dominican Republic", Iso2 = "DO", Iso3 = "DOM", Fips = "DR", IsoNumeric = "214", PhoneCode = "1-809", CapitalCity = "Santo Domingo", DotNetPowFlagName = DotNetPowFlagNames.Dominican_Republic },
                        new DotNetPowCountryIsoModel { Id = 206, Name = "East Timor", Iso2 = "TL", Iso3 = "TLS", Fips = "TT", IsoNumeric = "626", PhoneCode = "670", CapitalCity = "Dili", DotNetPowFlagName = DotNetPowFlagNames.East_Timor },
                        new DotNetPowCountryIsoModel { Id = 233, Name = "Ecuador", Iso2 = "EC", Iso3 = "ECU", Fips = "EC", IsoNumeric = "218", PhoneCode = "593", CapitalCity = "Quito", DotNetPowFlagName = DotNetPowFlagNames.Ecuador },
                        new DotNetPowCountryIsoModel { Id = 14, Name = "Egypt", Iso2 = "EG", Iso3 = "EGY", Fips = "EG", IsoNumeric = "818", PhoneCode = "20", CapitalCity = "Cairo", DotNetPowFlagName = DotNetPowFlagNames.Egypt },
                        new DotNetPowCountryIsoModel { Id = 179, Name = "El Salvador", Iso2 = "SV", Iso3 = "SLV", Fips = "ES", IsoNumeric = "222", PhoneCode = "503", CapitalCity = "San Salvador", DotNetPowFlagName = DotNetPowFlagNames.El_Salvador },
                        new DotNetPowCountryIsoModel { Id = 15, Name = "Equatorial Guinea", Iso2 = "GQ", Iso3 = "GNQ", Fips = "EK", IsoNumeric = "226", PhoneCode = "240", CapitalCity = "Malabo", DotNetPowFlagName = DotNetPowFlagNames.Equatorial_Guinea },
                        new DotNetPowCountryIsoModel { Id = 16, Name = "Eritrea", Iso2 = "ER", Iso3 = "ERI", Fips = "ER", IsoNumeric = "232", PhoneCode = "291", CapitalCity = "Asmara", DotNetPowFlagName = DotNetPowFlagNames.Eritrea },
                        new DotNetPowCountryIsoModel { Id = 123, Name = "Estonia", Iso2 = "EE", Iso3 = "EST", Fips = "EN", IsoNumeric = "233", PhoneCode = "372", CapitalCity = "Tallinn", DotNetPowFlagName = DotNetPowFlagNames.Estonia },
                        new DotNetPowCountryIsoModel { Id = 17, Name = "Ethiopia", Iso2 = "ET", Iso3 = "ETH", Fips = "ET", IsoNumeric = "231", PhoneCode = "251", CapitalCity = "Addis Ababa", DotNetPowFlagName = DotNetPowFlagNames.Ethiopia },
                        new DotNetPowCountryIsoModel { Id = 234, Name = "Falkland Islands", Iso2 = "FK", Iso3 = "FLK", Fips = "FK", IsoNumeric = "238", PhoneCode = "500", CapitalCity = "Stanley", DotNetPowFlagName = DotNetPowFlagNames.Falkland_Islands },
                        new DotNetPowCountryIsoModel { Id = 124, Name = "Faroe Islands", Iso2 = "FO", Iso3 = "FRO", Fips = "FO", IsoNumeric = "234", PhoneCode = "298", CapitalCity = "Torshavn", DotNetPowFlagName = DotNetPowFlagNames.Faroe_Islands },
                        new DotNetPowCountryIsoModel { Id = 207, Name = "Fiji", Iso2 = "FJ", Iso3 = "FJI", Fips = "FJ", IsoNumeric = "242", PhoneCode = "679", CapitalCity = "Suva", DotNetPowFlagName = DotNetPowFlagNames.Fiji },
                        new DotNetPowCountryIsoModel { Id = 125, Name = "Finland", Iso2 = "FI", Iso3 = "FIN", Fips = "FI", IsoNumeric = "246", PhoneCode = "358", CapitalCity = "Helsinki", DotNetPowFlagName = DotNetPowFlagNames.Finland },
                        new DotNetPowCountryIsoModel { Id = 126, Name = "France", Iso2 = "FR", Iso3 = "FRA", Fips = "FR", IsoNumeric = "250", PhoneCode = "33", CapitalCity = "Paris", DotNetPowFlagName = DotNetPowFlagNames.France },
                        new DotNetPowCountryIsoModel { Id = 241, Name = "French Guiana", Iso2 = "GF", Iso3 = "GUF", Fips = "", IsoNumeric = "254", PhoneCode = "594", CapitalCity = "Cayenne", DotNetPowFlagName = DotNetPowFlagNames.French_Guiana },
                        new DotNetPowCountryIsoModel { Id = 208, Name = "French Polynesia", Iso2 = "PF", Iso3 = "PYF", Fips = "FP", IsoNumeric = "258", PhoneCode = "689", CapitalCity = "Papeete", DotNetPowFlagName = DotNetPowFlagNames.French_Polynesia },
                        new DotNetPowCountryIsoModel { Id = 18, Name = "Gabon", Iso2 = "GA", Iso3 = "GAB", Fips = "GB", IsoNumeric = "266", PhoneCode = "241", CapitalCity = "Libreville", DotNetPowFlagName = DotNetPowFlagNames.Gabon },
                        new DotNetPowCountryIsoModel { Id = 19, Name = "Gambia", Iso2 = "GM", Iso3 = "GMB", Fips = "GA", IsoNumeric = "270", PhoneCode = "220", CapitalCity = "Banjul", DotNetPowFlagName = DotNetPowFlagNames.Gambia },
                        new DotNetPowCountryIsoModel { Id = 72, Name = "Georgia", Iso2 = "GE", Iso3 = "GEO", Fips = "GG", IsoNumeric = "268", PhoneCode = "995", CapitalCity = "Tbilisi", DotNetPowFlagName = DotNetPowFlagNames.Georgia },
                        new DotNetPowCountryIsoModel { Id = 127, Name = "Germany", Iso2 = "DE", Iso3 = "DEU", Fips = "GM", IsoNumeric = "276", PhoneCode = "49", CapitalCity = "Berlin", DotNetPowFlagName = DotNetPowFlagNames.Germany },
                        new DotNetPowCountryIsoModel { Id = 20, Name = "Ghana", Iso2 = "GH", Iso3 = "GHA", Fips = "GH", IsoNumeric = "288", PhoneCode = "233", CapitalCity = "Accra", DotNetPowFlagName = DotNetPowFlagNames.Ghana },
                        new DotNetPowCountryIsoModel { Id = 128, Name = "Gibraltar", Iso2 = "GI", Iso3 = "GIB", Fips = "GI", IsoNumeric = "292", PhoneCode = "350", CapitalCity = "Gibraltar", DotNetPowFlagName = DotNetPowFlagNames.Gibraltar },
                        new DotNetPowCountryIsoModel { Id = 129, Name = "Greece", Iso2 = "GR", Iso3 = "GRC", Fips = "GR", IsoNumeric = "300", PhoneCode = "30", CapitalCity = "Athens", DotNetPowFlagName = DotNetPowFlagNames.Greece },
                        new DotNetPowCountryIsoModel { Id = 180, Name = "Greenland", Iso2 = "GL", Iso3 = "GRL", Fips = "GL", IsoNumeric = "304", PhoneCode = "299", CapitalCity = "Nuuk", DotNetPowFlagName = DotNetPowFlagNames.Greenland },
                        new DotNetPowCountryIsoModel { Id = 181, Name = "Grenada", Iso2 = "GD", Iso3 = "GRD", Fips = "GJ", IsoNumeric = "308", PhoneCode = "1-473", CapitalCity = "St. George's", DotNetPowFlagName = DotNetPowFlagNames.Grenada },
                        new DotNetPowCountryIsoModel { Id = 242, Name = "Guadeloupe", Iso2 = "GP", Iso3 = "GLP", Fips = "", IsoNumeric = "312", PhoneCode = "590", CapitalCity = "Basse-Terre", DotNetPowFlagName = DotNetPowFlagNames.Guadeloupe },
                        new DotNetPowCountryIsoModel { Id = 209, Name = "Guam", Iso2 = "GU", Iso3 = "GUM", Fips = "GQ", IsoNumeric = "316", PhoneCode = "1-671", CapitalCity = "Hagatna", DotNetPowFlagName = DotNetPowFlagNames.Guam },
                        new DotNetPowCountryIsoModel { Id = 182, Name = "Guatemala", Iso2 = "GT", Iso3 = "GTM", Fips = "GT", IsoNumeric = "320", PhoneCode = "502", CapitalCity = "Guatemala City", DotNetPowFlagName = DotNetPowFlagNames.Guatemala },
                        new DotNetPowCountryIsoModel { Id = 130, Name = "Guernsey", Iso2 = "GG", Iso3 = "GGY", Fips = "GK", IsoNumeric = "831", PhoneCode = "44-14", CapitalCity = "St Peter Port", DotNetPowFlagName = DotNetPowFlagNames.Guernsey },
                        new DotNetPowCountryIsoModel { Id = 21, Name = "Guinea", Iso2 = "GN", Iso3 = "GIN", Fips = "GV", IsoNumeric = "324", PhoneCode = "224", CapitalCity = "Conakry", DotNetPowFlagName = DotNetPowFlagNames.Guinea },
                        new DotNetPowCountryIsoModel { Id = 22, Name = "Guinea-Bissau", Iso2 = "GW", Iso3 = "GNB", Fips = "PU", IsoNumeric = "624", PhoneCode = "245", CapitalCity = "Bissau", DotNetPowFlagName = DotNetPowFlagNames.Guinea_Bissau },
                        new DotNetPowCountryIsoModel { Id = 235, Name = "Guyana", Iso2 = "GY", Iso3 = "GUY", Fips = "GY", IsoNumeric = "328", PhoneCode = "592", CapitalCity = "Georgetown", DotNetPowFlagName = DotNetPowFlagNames.Guyana },
                        new DotNetPowCountryIsoModel { Id = 183, Name = "Haiti", Iso2 = "HT", Iso3 = "HTI", Fips = "HA", IsoNumeric = "332", PhoneCode = "509", CapitalCity = "Port-au-Prince", DotNetPowFlagName = DotNetPowFlagNames.Haiti },
                        new DotNetPowCountryIsoModel { Id = 184, Name = "Honduras", Iso2 = "HN", Iso3 = "HND", Fips = "HO", IsoNumeric = "340", PhoneCode = "504", CapitalCity = "Tegucigalpa", DotNetPowFlagName = DotNetPowFlagNames.Honduras },
                        new DotNetPowCountryIsoModel { Id = 73, Name = "Hong Kong", Iso2 = "HK", Iso3 = "HKG", Fips = "HK", IsoNumeric = "344", PhoneCode = "852", CapitalCity = "Hong Kong", DotNetPowFlagName = DotNetPowFlagNames.Hong_Kong },
                        new DotNetPowCountryIsoModel { Id = 131, Name = "Hungary", Iso2 = "HU", Iso3 = "HUN", Fips = "HU", IsoNumeric = "348", PhoneCode = "36", CapitalCity = "Budapest", DotNetPowFlagName = DotNetPowFlagNames.Hungary },
                        new DotNetPowCountryIsoModel { Id = 132, Name = "Iceland", Iso2 = "IS", Iso3 = "ISL", Fips = "IC", IsoNumeric = "352", PhoneCode = "354", CapitalCity = "Reykjavik", DotNetPowFlagName = DotNetPowFlagNames.Iceland },
                        new DotNetPowCountryIsoModel { Id = 74, Name = "India", Iso2 = "IN", Iso3 = "IND", Fips = "IN", IsoNumeric = "356", PhoneCode = "91", CapitalCity = "New Delhi", DotNetPowFlagName = DotNetPowFlagNames.India },
                        new DotNetPowCountryIsoModel { Id = 75, Name = "Indonesia", Iso2 = "ID", Iso3 = "IDN", Fips = "ID", IsoNumeric = "360", PhoneCode = "62", CapitalCity = "Jakarta", DotNetPowFlagName = DotNetPowFlagNames.Indonesia },
                        new DotNetPowCountryIsoModel { Id = 76, Name = "Iran", Iso2 = "IR", Iso3 = "IRN", Fips = "IR", IsoNumeric = "364", PhoneCode = "98", CapitalCity = "Tehran", DotNetPowFlagName = DotNetPowFlagNames.Iran },
                        new DotNetPowCountryIsoModel { Id = 77, Name = "Iraq", Iso2 = "IQ", Iso3 = "IRQ", Fips = "IZ", IsoNumeric = "368", PhoneCode = "964", CapitalCity = "Baghdad", DotNetPowFlagName = DotNetPowFlagNames.Iraq },
                        new DotNetPowCountryIsoModel { Id = 133, Name = "Ireland", Iso2 = "IE", Iso3 = "IRL", Fips = "EI", IsoNumeric = "372", PhoneCode = "353", CapitalCity = "Dublin", DotNetPowFlagName = DotNetPowFlagNames.Ireland },
                        new DotNetPowCountryIsoModel { Id = 134, Name = "Isle of Man", Iso2 = "IM", Iso3 = "IMN", Fips = "IM", IsoNumeric = "833", PhoneCode = "44-16", CapitalCity = "Douglas, Isle of Man", DotNetPowFlagName = DotNetPowFlagNames.Isle_of_Man },
                        new DotNetPowCountryIsoModel { Id = 78, Name = "Israel", Iso2 = "IL", Iso3 = "ISR", Fips = "IS", IsoNumeric = "376", PhoneCode = "972", CapitalCity = "Jerusalem", DotNetPowFlagName = DotNetPowFlagNames.Israel },
                        new DotNetPowCountryIsoModel { Id = 135, Name = "Italy", Iso2 = "IT", Iso3 = "ITA", Fips = "IT", IsoNumeric = "380", PhoneCode = "39", CapitalCity = "Rome", DotNetPowFlagName = DotNetPowFlagNames.Italy },
                        new DotNetPowCountryIsoModel { Id = 23, Name = "Ivory Coast", Iso2 = "CI", Iso3 = "CIV", Fips = "IV", IsoNumeric = "384", PhoneCode = "225", CapitalCity = "Yamoussoukro", DotNetPowFlagName = DotNetPowFlagNames.Ivory_Coast },
                        new DotNetPowCountryIsoModel { Id = 185, Name = "Jamaica", Iso2 = "JM", Iso3 = "JAM", Fips = "JM", IsoNumeric = "388", PhoneCode = "1-876", CapitalCity = "Kingston", DotNetPowFlagName = DotNetPowFlagNames.Jamaica },
                        new DotNetPowCountryIsoModel { Id = 79, Name = "Japan", Iso2 = "JP", Iso3 = "JPN", Fips = "JA", IsoNumeric = "392", PhoneCode = "81", CapitalCity = "Tokyo", DotNetPowFlagName = DotNetPowFlagNames.Japan },
                        new DotNetPowCountryIsoModel { Id = 136, Name = "Jersey", Iso2 = "JE", Iso3 = "JEY", Fips = "JE", IsoNumeric = "832", PhoneCode = "44-15", CapitalCity = "Saint Helier", DotNetPowFlagName = DotNetPowFlagNames.Jersey },
                        new DotNetPowCountryIsoModel { Id = 80, Name = "Jordan", Iso2 = "JO", Iso3 = "JOR", Fips = "JO", IsoNumeric = "400", PhoneCode = "962", CapitalCity = "Amman", DotNetPowFlagName = DotNetPowFlagNames.Jordan },
                        new DotNetPowCountryIsoModel { Id = 81, Name = "Kazakhstan", Iso2 = "KZ", Iso3 = "KAZ", Fips = "KZ", IsoNumeric = "398", PhoneCode = "7", CapitalCity = "Astana", DotNetPowFlagName = DotNetPowFlagNames.Kazakhstan },
                        new DotNetPowCountryIsoModel { Id = 24, Name = "Kenya", Iso2 = "KE", Iso3 = "KEN", Fips = "KE", IsoNumeric = "404", PhoneCode = "254", CapitalCity = "Nairobi", DotNetPowFlagName = DotNetPowFlagNames.Kenya },
                        new DotNetPowCountryIsoModel { Id = 210, Name = "Kiribati", Iso2 = "KI", Iso3 = "KIR", Fips = "KR", IsoNumeric = "296", PhoneCode = "686", CapitalCity = "Tarawa", DotNetPowFlagName = DotNetPowFlagNames.Kiribati },
                        new DotNetPowCountryIsoModel { Id = 137, Name = "Kosovo", Iso2 = "XK", Iso3 = "XKX", Fips = "KV", IsoNumeric = "0", PhoneCode = "383", CapitalCity = "Pristina", DotNetPowFlagName = DotNetPowFlagNames.Kosovo },
                        new DotNetPowCountryIsoModel { Id = 82, Name = "Kuwait", Iso2 = "KW", Iso3 = "KWT", Fips = "KU", IsoNumeric = "414", PhoneCode = "965", CapitalCity = "Kuwait City", DotNetPowFlagName = DotNetPowFlagNames.Kuwait },
                        new DotNetPowCountryIsoModel { Id = 83, Name = "Kyrgyzstan", Iso2 = "KG", Iso3 = "KGZ", Fips = "KG", IsoNumeric = "417", PhoneCode = "996", CapitalCity = "Bishkek", DotNetPowFlagName = DotNetPowFlagNames.Kyrgyzstan },
                        new DotNetPowCountryIsoModel { Id = 84, Name = "Laos", Iso2 = "LA", Iso3 = "LAO", Fips = "LA", IsoNumeric = "418", PhoneCode = "856", CapitalCity = "Vientiane", DotNetPowFlagName = DotNetPowFlagNames.Laos },
                        new DotNetPowCountryIsoModel { Id = 138, Name = "Latvia", Iso2 = "LV", Iso3 = "LVA", Fips = "LG", IsoNumeric = "428", PhoneCode = "371", CapitalCity = "Riga", DotNetPowFlagName = DotNetPowFlagNames.Latvia },
                        new DotNetPowCountryIsoModel { Id = 85, Name = "Lebanon", Iso2 = "LB", Iso3 = "LBN", Fips = "LE", IsoNumeric = "422", PhoneCode = "961", CapitalCity = "Beirut", DotNetPowFlagName = DotNetPowFlagNames.Lebanon },
                        new DotNetPowCountryIsoModel { Id = 25, Name = "Lesotho", Iso2 = "LS", Iso3 = "LSO", Fips = "LT", IsoNumeric = "426", PhoneCode = "266", CapitalCity = "Maseru", DotNetPowFlagName = DotNetPowFlagNames.Lesotho },
                        new DotNetPowCountryIsoModel { Id = 26, Name = "Liberia", Iso2 = "LR", Iso3 = "LBR", Fips = "LI", IsoNumeric = "430", PhoneCode = "231", CapitalCity = "Monrovia", DotNetPowFlagName = DotNetPowFlagNames.Liberia },
                        new DotNetPowCountryIsoModel { Id = 27, Name = "Libya", Iso2 = "LY", Iso3 = "LBY", Fips = "LY", IsoNumeric = "434", PhoneCode = "218", CapitalCity = "Tripolis", DotNetPowFlagName = DotNetPowFlagNames.Libya },
                        new DotNetPowCountryIsoModel { Id = 139, Name = "Liechtenstein", Iso2 = "LI", Iso3 = "LIE", Fips = "LS", IsoNumeric = "438", PhoneCode = "423", CapitalCity = "Vaduz", DotNetPowFlagName = DotNetPowFlagNames.Liechtenstein },
                        new DotNetPowCountryIsoModel { Id = 140, Name = "Lithuania", Iso2 = "LT", Iso3 = "LTU", Fips = "LH", IsoNumeric = "440", PhoneCode = "370", CapitalCity = "Vilnius", DotNetPowFlagName = DotNetPowFlagNames.Lithuania },
                        new DotNetPowCountryIsoModel { Id = 141, Name = "Luxembourg", Iso2 = "LU", Iso3 = "LUX", Fips = "LU", IsoNumeric = "442", PhoneCode = "352", CapitalCity = "Luxembourg", DotNetPowFlagName = DotNetPowFlagNames.Luxembourg },
                        new DotNetPowCountryIsoModel { Id = 86, Name = "Macau", Iso2 = "MO", Iso3 = "MAC", Fips = "MC", IsoNumeric = "446", PhoneCode = "853", CapitalCity = "Macao", DotNetPowFlagName = DotNetPowFlagNames.Macau },
                        new DotNetPowCountryIsoModel { Id = 142, Name = "Macedonia", Iso2 = "MK", Iso3 = "MKD", Fips = "MK", IsoNumeric = "807", PhoneCode = "389", CapitalCity = "Skopje", DotNetPowFlagName = DotNetPowFlagNames.Macedonia },
                        new DotNetPowCountryIsoModel { Id = 28, Name = "Madagascar", Iso2 = "MG", Iso3 = "MDG", Fips = "MA", IsoNumeric = "450", PhoneCode = "261", CapitalCity = "Antananarivo", DotNetPowFlagName = DotNetPowFlagNames.Madagascar },
                        new DotNetPowCountryIsoModel { Id = 29, Name = "Malawi", Iso2 = "MW", Iso3 = "MWI", Fips = "MI", IsoNumeric = "454", PhoneCode = "265", CapitalCity = "Lilongwe", DotNetPowFlagName = DotNetPowFlagNames.Malawi },
                        new DotNetPowCountryIsoModel { Id = 87, Name = "Malaysia", Iso2 = "MY", Iso3 = "MYS", Fips = "MY", IsoNumeric = "458", PhoneCode = "60", CapitalCity = "Kuala Lumpur", DotNetPowFlagName = DotNetPowFlagNames.Malaysia },
                        new DotNetPowCountryIsoModel { Id = 88, Name = "Maldives", Iso2 = "MV", Iso3 = "MDV", Fips = "MV", IsoNumeric = "462", PhoneCode = "960", CapitalCity = "Male", DotNetPowFlagName = DotNetPowFlagNames.Maldives },
                        new DotNetPowCountryIsoModel { Id = 30, Name = "Mali", Iso2 = "ML", Iso3 = "MLI", Fips = "ML", IsoNumeric = "466", PhoneCode = "223", CapitalCity = "Bamako", DotNetPowFlagName = DotNetPowFlagNames.Mali },
                        new DotNetPowCountryIsoModel { Id = 143, Name = "Malta", Iso2 = "MT", Iso3 = "MLT", Fips = "MT", IsoNumeric = "470", PhoneCode = "356", CapitalCity = "Valletta", DotNetPowFlagName = DotNetPowFlagNames.Malta },
                        new DotNetPowCountryIsoModel { Id = 211, Name = "Marshall Islands", Iso2 = "MH", Iso3 = "MHL", Fips = "RM", IsoNumeric = "584", PhoneCode = "692", CapitalCity = "Majuro", DotNetPowFlagName = DotNetPowFlagNames.Marshall_Islands },
                        new DotNetPowCountryIsoModel { Id = 244, Name = "Martinique", Iso2 = "MQ", Iso3 = "MQT", Fips = "", IsoNumeric = "474", PhoneCode = "596", CapitalCity = "Fort-de-France Bay", DotNetPowFlagName = DotNetPowFlagNames.Martinique },
                        new DotNetPowCountryIsoModel { Id = 31, Name = "Mauritania", Iso2 = "MR", Iso3 = "MRT", Fips = "MR", IsoNumeric = "478", PhoneCode = "222", CapitalCity = "Nouakchott", DotNetPowFlagName = DotNetPowFlagNames.Mauritania },
                        new DotNetPowCountryIsoModel { Id = 32, Name = "Mauritius", Iso2 = "MU", Iso3 = "MUS", Fips = "MP", IsoNumeric = "480", PhoneCode = "230", CapitalCity = "Port Louis", DotNetPowFlagName = DotNetPowFlagNames.Mauritius },
                        new DotNetPowCountryIsoModel { Id = 33, Name = "Mayotte", Iso2 = "YT", Iso3 = "MYT", Fips = "MF", IsoNumeric = "175", PhoneCode = "262", CapitalCity = "Mamoudzou", DotNetPowFlagName = DotNetPowFlagNames.Mayotte },
                        new DotNetPowCountryIsoModel { Id = 186, Name = "Mexico", Iso2 = "MX", Iso3 = "MEX", Fips = "MX", IsoNumeric = "484", PhoneCode = "52", CapitalCity = "Mexico City", DotNetPowFlagName = DotNetPowFlagNames.Mexico },
                        new DotNetPowCountryIsoModel { Id = 212, Name = "Micronesia", Iso2 = "FM", Iso3 = "FSM", Fips = "FM", IsoNumeric = "583", PhoneCode = "691", CapitalCity = "Palikir", DotNetPowFlagName = DotNetPowFlagNames.Micronesia },
                        new DotNetPowCountryIsoModel { Id = 144, Name = "Moldova", Iso2 = "MD", Iso3 = "MDA", Fips = "MD", IsoNumeric = "498", PhoneCode = "373", CapitalCity = "Chisinau", DotNetPowFlagName = DotNetPowFlagNames.Moldova },
                        new DotNetPowCountryIsoModel { Id = 145, Name = "Monaco", Iso2 = "MC", Iso3 = "MCO", Fips = "MN", IsoNumeric = "492", PhoneCode = "377", CapitalCity = "Monaco", DotNetPowFlagName = DotNetPowFlagNames.Monaco },
                        new DotNetPowCountryIsoModel { Id = 89, Name = "Mongolia", Iso2 = "MN", Iso3 = "MNG", Fips = "MG", IsoNumeric = "496", PhoneCode = "976", CapitalCity = "Ulan Bator", DotNetPowFlagName = DotNetPowFlagNames.Mongolia },
                        new DotNetPowCountryIsoModel { Id = 146, Name = "Montenegro", Iso2 = "ME", Iso3 = "MNE", Fips = "MJ", IsoNumeric = "499", PhoneCode = "382", CapitalCity = "Podgorica", DotNetPowFlagName = DotNetPowFlagNames.Montenegro },
                        new DotNetPowCountryIsoModel { Id = 187, Name = "Montserrat", Iso2 = "MS", Iso3 = "MSR", Fips = "MH", IsoNumeric = "500", PhoneCode = "1-664", CapitalCity = "Plymouth", DotNetPowFlagName = DotNetPowFlagNames.Montserrat },
                        new DotNetPowCountryIsoModel { Id = 34, Name = "Morocco", Iso2 = "MA", Iso3 = "MAR", Fips = "MO", IsoNumeric = "504", PhoneCode = "212", CapitalCity = "Rabat", DotNetPowFlagName = DotNetPowFlagNames.Morocco },
                        new DotNetPowCountryIsoModel { Id = 35, Name = "Mozambique", Iso2 = "MZ", Iso3 = "MOZ", Fips = "MZ", IsoNumeric = "508", PhoneCode = "258", CapitalCity = "Maputo", DotNetPowFlagName = DotNetPowFlagNames.Mozambique },
                        new DotNetPowCountryIsoModel { Id = 90, Name = "Myanmar", Iso2 = "MM", Iso3 = "MMR", Fips = "BM", IsoNumeric = "104", PhoneCode = "95", CapitalCity = "Nay Pyi Taw", DotNetPowFlagName = DotNetPowFlagNames.Myanmar },
                        new DotNetPowCountryIsoModel { Id = 36, Name = "Namibia", Iso2 = "NA", Iso3 = "NAM", Fips = "WA", IsoNumeric = "516", PhoneCode = "264", CapitalCity = "Windhoek", DotNetPowFlagName = DotNetPowFlagNames.Namibia },
                        new DotNetPowCountryIsoModel { Id = 213, Name = "Nauru", Iso2 = "NR", Iso3 = "NRU", Fips = "NR", IsoNumeric = "520", PhoneCode = "674", CapitalCity = "Yaren", DotNetPowFlagName = DotNetPowFlagNames.Nauru },
                        new DotNetPowCountryIsoModel { Id = 91, Name = "Nepal", Iso2 = "NP", Iso3 = "NPL", Fips = "NP", IsoNumeric = "524", PhoneCode = "977", CapitalCity = "Kathmandu", DotNetPowFlagName = DotNetPowFlagNames.Nepal },
                        new DotNetPowCountryIsoModel { Id = 147, Name = "Netherlands", Iso2 = "NL", Iso3 = "NLD", Fips = "NL", IsoNumeric = "528", PhoneCode = "31", CapitalCity = "Amsterdam", DotNetPowFlagName = DotNetPowFlagNames.Netherlands },
                        new DotNetPowCountryIsoModel { Id = 188, Name = "Netherlands Antilles", Iso2 = "AN", Iso3 = "ANT", Fips = "NT", IsoNumeric = "530", PhoneCode = "599", CapitalCity = "Willemstad", DotNetPowFlagName = DotNetPowFlagNames.Netherlands_Antilles },
                        new DotNetPowCountryIsoModel { Id = 214, Name = "New Caledonia", Iso2 = "NC", Iso3 = "NCL", Fips = "NC", IsoNumeric = "540", PhoneCode = "687", CapitalCity = "Noumea", DotNetPowFlagName = DotNetPowFlagNames.New_Caledonia },
                        new DotNetPowCountryIsoModel { Id = 215, Name = "New Zealand", Iso2 = "NZ", Iso3 = "NZL", Fips = "NZ", IsoNumeric = "554", PhoneCode = "64", CapitalCity = "Wellington", DotNetPowFlagName = DotNetPowFlagNames.New_Zealand },
                        new DotNetPowCountryIsoModel { Id = 189, Name = "Nicaragua", Iso2 = "NI", Iso3 = "NIC", Fips = "NU", IsoNumeric = "558", PhoneCode = "505", CapitalCity = "Managua", DotNetPowFlagName = DotNetPowFlagNames.Nicaragua },
                        new DotNetPowCountryIsoModel { Id = 37, Name = "Niger", Iso2 = "NE", Iso3 = "NER", Fips = "NG", IsoNumeric = "562", PhoneCode = "227", CapitalCity = "Niamey", DotNetPowFlagName = DotNetPowFlagNames.Niger },
                        new DotNetPowCountryIsoModel { Id = 38, Name = "Nigeria", Iso2 = "NG", Iso3 = "NGA", Fips = "NI", IsoNumeric = "566", PhoneCode = "234", CapitalCity = "Abuja", DotNetPowFlagName = DotNetPowFlagNames.Nigeria },
                        new DotNetPowCountryIsoModel { Id = 216, Name = "Niue", Iso2 = "NU", Iso3 = "NIU", Fips = "NE", IsoNumeric = "570", PhoneCode = "683", CapitalCity = "Alofi", DotNetPowFlagName = DotNetPowFlagNames.Niue },
                        new DotNetPowCountryIsoModel { Id = 92, Name = "North Korea", Iso2 = "KP", Iso3 = "PRK", Fips = "KN", IsoNumeric = "408", PhoneCode = "850", CapitalCity = "Pyongyang", DotNetPowFlagName = DotNetPowFlagNames.North_Korea },
                        new DotNetPowCountryIsoModel { Id = 217, Name = "Northern Mariana Islands", Iso2 = "MP", Iso3 = "MNP", Fips = "CQ", IsoNumeric = "580", PhoneCode = "1-670", CapitalCity = "Saipan", DotNetPowFlagName = DotNetPowFlagNames.Northern_Mariana_Islands },
                        new DotNetPowCountryIsoModel { Id = 148, Name = "Norway", Iso2 = "NO", Iso3 = "NOR", Fips = "NO", IsoNumeric = "578", PhoneCode = "47", CapitalCity = "Oslo", DotNetPowFlagName = DotNetPowFlagNames.Norway },
                        new DotNetPowCountryIsoModel { Id = 93, Name = "Oman", Iso2 = "OM", Iso3 = "OMN", Fips = "MU", IsoNumeric = "512", PhoneCode = "968", CapitalCity = "Muscat", DotNetPowFlagName = DotNetPowFlagNames.Oman },
                        new DotNetPowCountryIsoModel { Id = 94, Name = "Pakistan", Iso2 = "PK", Iso3 = "PAK", Fips = "PK", IsoNumeric = "586", PhoneCode = "92", CapitalCity = "Islamabad", DotNetPowFlagName = DotNetPowFlagNames.Pakistan },
                        new DotNetPowCountryIsoModel { Id = 218, Name = "Palau", Iso2 = "PW", Iso3 = "PLW", Fips = "PS", IsoNumeric = "585", PhoneCode = "680", CapitalCity = "Melekeok", DotNetPowFlagName = DotNetPowFlagNames.Palau },
                        new DotNetPowCountryIsoModel { Id = 95, Name = "Palestine", Iso2 = "PS", Iso3 = "PSE", Fips = "WE", IsoNumeric = "275", PhoneCode = "970", CapitalCity = "East Jerusalem", DotNetPowFlagName = DotNetPowFlagNames.Palestine },
                        new DotNetPowCountryIsoModel { Id = 190, Name = "Panama", Iso2 = "PA", Iso3 = "PAN", Fips = "PM", IsoNumeric = "591", PhoneCode = "507", CapitalCity = "Panama City", DotNetPowFlagName = DotNetPowFlagNames.Panama },
                        new DotNetPowCountryIsoModel { Id = 219, Name = "Papua New Guinea", Iso2 = "PG", Iso3 = "PNG", Fips = "PP", IsoNumeric = "598", PhoneCode = "675", CapitalCity = "Port Moresby", DotNetPowFlagName = DotNetPowFlagNames.Papua_New_Guinea },
                        new DotNetPowCountryIsoModel { Id = 236, Name = "Paraguay", Iso2 = "PY", Iso3 = "PRY", Fips = "PA", IsoNumeric = "600", PhoneCode = "595", CapitalCity = "Asuncion", DotNetPowFlagName = DotNetPowFlagNames.Paraguay },
                        new DotNetPowCountryIsoModel { Id = 237, Name = "Peru", Iso2 = "PE", Iso3 = "PER", Fips = "PE", IsoNumeric = "604", PhoneCode = "51", CapitalCity = "Lima", DotNetPowFlagName = DotNetPowFlagNames.Peru },
                        new DotNetPowCountryIsoModel { Id = 96, Name = "Philippines", Iso2 = "PH", Iso3 = "PHL", Fips = "RP", IsoNumeric = "608", PhoneCode = "63", CapitalCity = "Manila", DotNetPowFlagName = DotNetPowFlagNames.Philippines },
                        new DotNetPowCountryIsoModel { Id = 220, Name = "Pitcairn", Iso2 = "PN", Iso3 = "PCN", Fips = "PC", IsoNumeric = "612", PhoneCode = "64", CapitalCity = "Adamstown", DotNetPowFlagName = DotNetPowFlagNames.Pitcairn },
                        new DotNetPowCountryIsoModel { Id = 149, Name = "Poland", Iso2 = "PL", Iso3 = "POL", Fips = "PL", IsoNumeric = "616", PhoneCode = "48", CapitalCity = "Warsaw", DotNetPowFlagName = DotNetPowFlagNames.Poland },
                        new DotNetPowCountryIsoModel { Id = 150, Name = "Portugal", Iso2 = "PT", Iso3 = "PRT", Fips = "PO", IsoNumeric = "620", PhoneCode = "351", CapitalCity = "Lisbon", DotNetPowFlagName = DotNetPowFlagNames.Portugal },
                        new DotNetPowCountryIsoModel { Id = 191, Name = "Puerto Rico", Iso2 = "PR", Iso3 = "PRI", Fips = "RQ", IsoNumeric = "630", PhoneCode = "1-787", CapitalCity = "San Juan", DotNetPowFlagName = DotNetPowFlagNames.Puerto_Rico },
                        new DotNetPowCountryIsoModel { Id = 97, Name = "Qatar", Iso2 = "QA", Iso3 = "QAT", Fips = "QA", IsoNumeric = "634", PhoneCode = "974", CapitalCity = "Doha", DotNetPowFlagName = DotNetPowFlagNames.Qatar },
                        new DotNetPowCountryIsoModel { Id = 39, Name = "Republic of the Congo", Iso2 = "CG", Iso3 = "COG", Fips = "CF", IsoNumeric = "178", PhoneCode = "242", CapitalCity = "Brazzaville", DotNetPowFlagName = DotNetPowFlagNames.Republic_of_the_Congo },
                        new DotNetPowCountryIsoModel { Id = 40, Name = "Reunion", Iso2 = "RE", Iso3 = "REU", Fips = "RE", IsoNumeric = "638", PhoneCode = "262", CapitalCity = "Saint-Denis", DotNetPowFlagName = DotNetPowFlagNames.Reunion },
                        new DotNetPowCountryIsoModel { Id = 151, Name = "Romania", Iso2 = "RO", Iso3 = "ROU", Fips = "RO", IsoNumeric = "642", PhoneCode = "40", CapitalCity = "Bucharest", DotNetPowFlagName = DotNetPowFlagNames.Romania },
                        new DotNetPowCountryIsoModel { Id = 152, Name = "Russia", Iso2 = "RU", Iso3 = "RUS", Fips = "RS", IsoNumeric = "643", PhoneCode = "7", CapitalCity = "Moscow", DotNetPowFlagName = DotNetPowFlagNames.Russia },
                        new DotNetPowCountryIsoModel { Id = 41, Name = "Rwanda", Iso2 = "RW", Iso3 = "RWA", Fips = "RW", IsoNumeric = "646", PhoneCode = "250", CapitalCity = "Kigali", DotNetPowFlagName = DotNetPowFlagNames.Rwanda },
                        new DotNetPowCountryIsoModel { Id = 192, Name = "Saint Barthelemy", Iso2 = "BL", Iso3 = "BLM", Fips = "TB", IsoNumeric = "652", PhoneCode = "590", CapitalCity = "Gustavia", DotNetPowFlagName = DotNetPowFlagNames.Saint_Barthelemy },
                        new DotNetPowCountryIsoModel { Id = 42, Name = "Saint Helena", Iso2 = "SH", Iso3 = "SHN", Fips = "SH", IsoNumeric = "654", PhoneCode = "290", CapitalCity = "Jamestown", DotNetPowFlagName = DotNetPowFlagNames.Saint_Helena },
                        new DotNetPowCountryIsoModel { Id = 193, Name = "Saint Kitts and Nevis", Iso2 = "KN", Iso3 = "KNA", Fips = "SC", IsoNumeric = "659", PhoneCode = "1-869", CapitalCity = "Basseterre", DotNetPowFlagName = DotNetPowFlagNames.Saint_Kitts_And_Nevis },
                        new DotNetPowCountryIsoModel { Id = 194, Name = "Saint Lucia", Iso2 = "LC", Iso3 = "LCA", Fips = "ST", IsoNumeric = "662", PhoneCode = "1-758", CapitalCity = "Castries", DotNetPowFlagName = DotNetPowFlagNames.Saint_Lucia },
                        new DotNetPowCountryIsoModel { Id = 195, Name = "Saint Martin", Iso2 = "MF", Iso3 = "MAF", Fips = "RN", IsoNumeric = "663", PhoneCode = "590", CapitalCity = "Marigot", DotNetPowFlagName = DotNetPowFlagNames.Saint_Martin },
                        new DotNetPowCountryIsoModel { Id = 196, Name = "Saint Pierre and Miquelon", Iso2 = "PM", Iso3 = "SPM", Fips = "SB", IsoNumeric = "666", PhoneCode = "508", CapitalCity = "Saint-Pierre", DotNetPowFlagName = DotNetPowFlagNames.Saint_Pierre_And_Miquelon },
                        new DotNetPowCountryIsoModel { Id = 197, Name = "Saint Vincent and the Grenadines", Iso2 = "VC", Iso3 = "VCT", Fips = "VC", IsoNumeric = "670", PhoneCode = "1-784", CapitalCity = "Kingstown", DotNetPowFlagName = DotNetPowFlagNames.Saint_Vincent_And_the_Grenadines },
                        new DotNetPowCountryIsoModel { Id = 221, Name = "Samoa", Iso2 = "WS", Iso3 = "WSM", Fips = "WS", IsoNumeric = "882", PhoneCode = "685", CapitalCity = "Apia", DotNetPowFlagName = DotNetPowFlagNames.Samoa },
                        new DotNetPowCountryIsoModel { Id = 153, Name = "San Marino", Iso2 = "SM", Iso3 = "SMR", Fips = "SM", IsoNumeric = "674", PhoneCode = "378", CapitalCity = "San Marino", DotNetPowFlagName = DotNetPowFlagNames.San_Marino },
                        new DotNetPowCountryIsoModel { Id = 43, Name = "Sao Tome and Principe", Iso2 = "ST", Iso3 = "STP", Fips = "TP", IsoNumeric = "678", PhoneCode = "239", CapitalCity = "Sao Tome", DotNetPowFlagName = DotNetPowFlagNames.Sao_Tome_And_Principe },
                        new DotNetPowCountryIsoModel { Id = 98, Name = "Saudi Arabia", Iso2 = "SA", Iso3 = "SAU", Fips = "SA", IsoNumeric = "682", PhoneCode = "966", CapitalCity = "Riyadh", DotNetPowFlagName = DotNetPowFlagNames.Saudi_Arabia },
                        new DotNetPowCountryIsoModel { Id = 44, Name = "Senegal", Iso2 = "SN", Iso3 = "SEN", Fips = "SG", IsoNumeric = "686", PhoneCode = "221", CapitalCity = "Dakar", DotNetPowFlagName = DotNetPowFlagNames.Senegal },
                        new DotNetPowCountryIsoModel { Id = 154, Name = "Serbia", Iso2 = "RS", Iso3 = "SRB", Fips = "RI", IsoNumeric = "688", PhoneCode = "381", CapitalCity = "Belgrade", DotNetPowFlagName = DotNetPowFlagNames.Serbia },
                        new DotNetPowCountryIsoModel { Id = 45, Name = "Seychelles", Iso2 = "SC", Iso3 = "SYC", Fips = "SE", IsoNumeric = "690", PhoneCode = "248", CapitalCity = "Victoria", DotNetPowFlagName = DotNetPowFlagNames.Seychelles },
                        new DotNetPowCountryIsoModel { Id = 46, Name = "Sierra Leone", Iso2 = "SL", Iso3 = "SLE", Fips = "SL", IsoNumeric = "694", PhoneCode = "232", CapitalCity = "Freetown", DotNetPowFlagName = DotNetPowFlagNames.Sierra_Leone },
                        new DotNetPowCountryIsoModel { Id = 99, Name = "Singapore", Iso2 = "SG", Iso3 = "SGP", Fips = "SN", IsoNumeric = "702", PhoneCode = "65", CapitalCity = "Singapore", DotNetPowFlagName = DotNetPowFlagNames.Singapore },
                        new DotNetPowCountryIsoModel { Id = 198, Name = "Sint Maarten", Iso2 = "SX", Iso3 = "SXM", Fips = "NN", IsoNumeric = "534", PhoneCode = "1-721", CapitalCity = "Philipsburg", DotNetPowFlagName = DotNetPowFlagNames.Sint_Maarten },
                        new DotNetPowCountryIsoModel { Id = 155, Name = "Slovakia", Iso2 = "SK", Iso3 = "SVK", Fips = "LO", IsoNumeric = "703", PhoneCode = "421", CapitalCity = "Bratislava", DotNetPowFlagName = DotNetPowFlagNames.Slovakia },
                        new DotNetPowCountryIsoModel { Id = 156, Name = "Slovenia", Iso2 = "SI", Iso3 = "SVN", Fips = "SI", IsoNumeric = "705", PhoneCode = "386", CapitalCity = "Ljubljana", DotNetPowFlagName = DotNetPowFlagNames.Slovenia },
                        new DotNetPowCountryIsoModel { Id = 222, Name = "Solomon Islands", Iso2 = "SB", Iso3 = "SLB", Fips = "BP", IsoNumeric = "90", PhoneCode = "677", CapitalCity = "Honiara", DotNetPowFlagName = DotNetPowFlagNames.Solomon_Islands },
                        new DotNetPowCountryIsoModel { Id = 47, Name = "Somalia", Iso2 = "SO", Iso3 = "SOM", Fips = "SO", IsoNumeric = "706", PhoneCode = "252", CapitalCity = "Mogadishu", DotNetPowFlagName = DotNetPowFlagNames.Somalia },
                        new DotNetPowCountryIsoModel { Id = 48, Name = "South Africa", Iso2 = "ZA", Iso3 = "ZAF", Fips = "SF", IsoNumeric = "710", PhoneCode = "27", CapitalCity = "Pretoria", DotNetPowFlagName = DotNetPowFlagNames.South_Africa },
                        new DotNetPowCountryIsoModel { Id = 100, Name = "South Korea", Iso2 = "KR", Iso3 = "KOR", Fips = "KS", IsoNumeric = "410", PhoneCode = "82", CapitalCity = "Seoul", DotNetPowFlagName = DotNetPowFlagNames.South_Korea },
                        new DotNetPowCountryIsoModel { Id = 49, Name = "South Sudan", Iso2 = "SS", Iso3 = "SSD", Fips = "OD", IsoNumeric = "728", PhoneCode = "211", CapitalCity = "Juba", DotNetPowFlagName = DotNetPowFlagNames.South_Sudan },
                        new DotNetPowCountryIsoModel { Id = 157, Name = "Spain", Iso2 = "ES", Iso3 = "ESP", Fips = "SP", IsoNumeric = "724", PhoneCode = "34", CapitalCity = "Madrid", DotNetPowFlagName = DotNetPowFlagNames.Spain },
                        new DotNetPowCountryIsoModel { Id = 101, Name = "Sri Lanka", Iso2 = "LK", Iso3 = "LKA", Fips = "CE", IsoNumeric = "144", PhoneCode = "94", CapitalCity = "Colombo", DotNetPowFlagName = DotNetPowFlagNames.Sri_Lanka },
                        new DotNetPowCountryIsoModel { Id = 50, Name = "Sudan", Iso2 = "SD", Iso3 = "SDN", Fips = "SU", IsoNumeric = "729", PhoneCode = "249", CapitalCity = "Khartoum", DotNetPowFlagName = DotNetPowFlagNames.Sudan },
                        new DotNetPowCountryIsoModel { Id = 238, Name = "Suriname", Iso2 = "SR", Iso3 = "SUR", Fips = "NS", IsoNumeric = "740", PhoneCode = "597", CapitalCity = "Paramaribo", DotNetPowFlagName = DotNetPowFlagNames.Suriname },
                        new DotNetPowCountryIsoModel { Id = 158, Name = "Svalbard and Jan Mayen", Iso2 = "SJ", Iso3 = "SJM", Fips = "SV", IsoNumeric = "744", PhoneCode = "47", CapitalCity = "Longyearbyen", DotNetPowFlagName = DotNetPowFlagNames.Svalbard_And_Jan_Mayen },
                        new DotNetPowCountryIsoModel { Id = 51, Name = "Swaziland", Iso2 = "SZ", Iso3 = "SWZ", Fips = "WZ", IsoNumeric = "748", PhoneCode = "268", CapitalCity = "Mbabane", DotNetPowFlagName = DotNetPowFlagNames.Swaziland },
                        new DotNetPowCountryIsoModel { Id = 159, Name = "Sweden", Iso2 = "SE", Iso3 = "SWE", Fips = "SW", IsoNumeric = "752", PhoneCode = "46", CapitalCity = "Stockholm", DotNetPowFlagName = DotNetPowFlagNames.Sweden },
                        new DotNetPowCountryIsoModel { Id = 160, Name = "Switzerland", Iso2 = "CH", Iso3 = "CHE", Fips = "SZ", IsoNumeric = "756", PhoneCode = "41", CapitalCity = "Berne", DotNetPowFlagName = DotNetPowFlagNames.Switzerland },
                        new DotNetPowCountryIsoModel { Id = 102, Name = "Syria", Iso2 = "SY", Iso3 = "SYR", Fips = "SY", IsoNumeric = "760", PhoneCode = "963", CapitalCity = "Damascus", DotNetPowFlagName = DotNetPowFlagNames.Syria },
                        new DotNetPowCountryIsoModel { Id = 103, Name = "Taiwan", Iso2 = "TW", Iso3 = "TWN", Fips = "TW", IsoNumeric = "158", PhoneCode = "886", CapitalCity = "Taipei", DotNetPowFlagName = DotNetPowFlagNames.Taiwan },
                        new DotNetPowCountryIsoModel { Id = 104, Name = "Tajikistan", Iso2 = "TJ", Iso3 = "TJK", Fips = "TI", IsoNumeric = "762", PhoneCode = "992", CapitalCity = "Dushanbe", DotNetPowFlagName = DotNetPowFlagNames.Tajikistan },
                        new DotNetPowCountryIsoModel { Id = 52, Name = "Tanzania", Iso2 = "TZ", Iso3 = "TZA", Fips = "TZ", IsoNumeric = "834", PhoneCode = "255", CapitalCity = "Dodoma", DotNetPowFlagName = DotNetPowFlagNames.Tanzania },
                        new DotNetPowCountryIsoModel { Id = 105, Name = "Thailand", Iso2 = "TH", Iso3 = "THA", Fips = "TH", IsoNumeric = "764", PhoneCode = "66", CapitalCity = "Bangkok", DotNetPowFlagName = DotNetPowFlagNames.Thailand },
                        new DotNetPowCountryIsoModel { Id = 53, Name = "Togo", Iso2 = "TG", Iso3 = "TGO", Fips = "TO", IsoNumeric = "768", PhoneCode = "228", CapitalCity = "Lome", DotNetPowFlagName = DotNetPowFlagNames.Togo },
                        new DotNetPowCountryIsoModel { Id = 223, Name = "Tokelau", Iso2 = "TK", Iso3 = "TKL", Fips = "TL", IsoNumeric = "772", PhoneCode = "690", CapitalCity = "--", DotNetPowFlagName = DotNetPowFlagNames.Tokelau },
                        new DotNetPowCountryIsoModel { Id = 224, Name = "Tonga", Iso2 = "TO", Iso3 = "TON", Fips = "TN", IsoNumeric = "776", PhoneCode = "676", CapitalCity = "Nuku'alofa", DotNetPowFlagName = DotNetPowFlagNames.Tonga },
                        new DotNetPowCountryIsoModel { Id = 199, Name = "Trinidad and Tobago", Iso2 = "TT", Iso3 = "TTO", Fips = "TD", IsoNumeric = "780", PhoneCode = "1-868", CapitalCity = "Port of Spain", DotNetPowFlagName = DotNetPowFlagNames.Trinidad_And_Tobago },
                        new DotNetPowCountryIsoModel { Id = 54, Name = "Tunisia", Iso2 = "TN", Iso3 = "TUN", Fips = "TS", IsoNumeric = "788", PhoneCode = "216", CapitalCity = "Tunis", DotNetPowFlagName = DotNetPowFlagNames.Tunisia },
                        new DotNetPowCountryIsoModel { Id = 106, Name = "Turkey", Iso2 = "TR", Iso3 = "TUR", Fips = "TU", IsoNumeric = "792", PhoneCode = "90", CapitalCity = "Ankara", DotNetPowFlagName = DotNetPowFlagNames.Turkey },
                        new DotNetPowCountryIsoModel { Id = 107, Name = "Turkmenistan", Iso2 = "TM", Iso3 = "TKM", Fips = "TX", IsoNumeric = "795", PhoneCode = "993", CapitalCity = "Ashgabat", DotNetPowFlagName = DotNetPowFlagNames.Turkmenistan },
                        new DotNetPowCountryIsoModel { Id = 200, Name = "Turks and Caicos Islands", Iso2 = "TC", Iso3 = "TCA", Fips = "TK", IsoNumeric = "796", PhoneCode = "1-649", CapitalCity = "Cockburn Town", DotNetPowFlagName = DotNetPowFlagNames.Turks_And_Caicos_Islands },
                        new DotNetPowCountryIsoModel { Id = 225, Name = "Tuvalu", Iso2 = "TV", Iso3 = "TUV", Fips = "TV", IsoNumeric = "798", PhoneCode = "688", CapitalCity = "Funafuti", DotNetPowFlagName = DotNetPowFlagNames.Tuvalu },
                        new DotNetPowCountryIsoModel { Id = 201, Name = "U.S. Virgin Islands", Iso2 = "VI", Iso3 = "VIR", Fips = "VQ", IsoNumeric = "850", PhoneCode = "1-340", CapitalCity = "Charlotte Amalie", DotNetPowFlagName = DotNetPowFlagNames.US_Virgin_Islands },
                        new DotNetPowCountryIsoModel { Id = 55, Name = "Uganda", Iso2 = "UG", Iso3 = "UGA", Fips = "UG", IsoNumeric = "800", PhoneCode = "256", CapitalCity = "Kampala", DotNetPowFlagName = DotNetPowFlagNames.Uganda },
                        new DotNetPowCountryIsoModel { Id = 161, Name = "Ukraine", Iso2 = "UA", Iso3 = "UKR", Fips = "UP", IsoNumeric = "804", PhoneCode = "380", CapitalCity = "Kiev", DotNetPowFlagName = DotNetPowFlagNames.Ukraine },
                        new DotNetPowCountryIsoModel { Id = 108, Name = "United Arab Emirates", Iso2 = "AE", Iso3 = "ARE", Fips = "AE", IsoNumeric = "784", PhoneCode = "971", CapitalCity = "Abu Dhabi", DotNetPowFlagName = DotNetPowFlagNames.United_Arab_Emirates },
                        new DotNetPowCountryIsoModel { Id = 162, Name = "United Kingdom", Iso2 = "GB", Iso3 = "GBR", Fips = "UK", IsoNumeric = "826", PhoneCode = "44", CapitalCity = "London", DotNetPowFlagName = DotNetPowFlagNames.United_Kingdom },
                        new DotNetPowCountryIsoModel { Id = 202, Name = "United States", Iso2 = "US", Iso3 = "USA", Fips = "US", IsoNumeric = "840", PhoneCode = "1", CapitalCity = "Washington", DotNetPowFlagName = DotNetPowFlagNames.United_States },
                        new DotNetPowCountryIsoModel { Id = 239, Name = "Uruguay", Iso2 = "UY", Iso3 = "URY", Fips = "UY", IsoNumeric = "858", PhoneCode = "598", CapitalCity = "Montevideo", DotNetPowFlagName = DotNetPowFlagNames.Uruguay },
                        new DotNetPowCountryIsoModel { Id = 109, Name = "Uzbekistan", Iso2 = "UZ", Iso3 = "UZB", Fips = "UZ", IsoNumeric = "860", PhoneCode = "998", CapitalCity = "Tashkent", DotNetPowFlagName = DotNetPowFlagNames.Uzbekistan },
                        new DotNetPowCountryIsoModel { Id = 226, Name = "Vanuatu", Iso2 = "VU", Iso3 = "VUT", Fips = "NH", IsoNumeric = "548", PhoneCode = "678", CapitalCity = "Port Vila", DotNetPowFlagName = DotNetPowFlagNames.Vanuatu },
                        new DotNetPowCountryIsoModel { Id = 163, Name = "Vatican", Iso2 = "VA", Iso3 = "VAT", Fips = "VT", IsoNumeric = "336", PhoneCode = "379", CapitalCity = "Vatican City", DotNetPowFlagName = DotNetPowFlagNames.Vatican },
                        new DotNetPowCountryIsoModel { Id = 240, Name = "Venezuela", Iso2 = "VE", Iso3 = "VEN", Fips = "VE", IsoNumeric = "862", PhoneCode = "58", CapitalCity = "Caracas", DotNetPowFlagName = DotNetPowFlagNames.Venezuela },
                        new DotNetPowCountryIsoModel { Id = 110, Name = "Vietnam", Iso2 = "VN", Iso3 = "VNM", Fips = "VM", IsoNumeric = "704", PhoneCode = "84", CapitalCity = "Hanoi", DotNetPowFlagName = DotNetPowFlagNames.Vietnam },
                        new DotNetPowCountryIsoModel { Id = 227, Name = "Wallis and Futuna", Iso2 = "WF", Iso3 = "WLF", Fips = "WF", IsoNumeric = "876", PhoneCode = "681", CapitalCity = "Mata Utu", DotNetPowFlagName = DotNetPowFlagNames.Wallis_And_Futuna },
                        new DotNetPowCountryIsoModel { Id = 56, Name = "Western Sahara", Iso2 = "EH", Iso3 = "ESH", Fips = "WI", IsoNumeric = "732", PhoneCode = "212", CapitalCity = "El-Aaiun", DotNetPowFlagName = DotNetPowFlagNames.Western_Sahara },
                        new DotNetPowCountryIsoModel { Id = 111, Name = "Yemen", Iso2 = "YE", Iso3 = "YEM", Fips = "YM", IsoNumeric = "887", PhoneCode = "967", CapitalCity = "Sanaa", DotNetPowFlagName = DotNetPowFlagNames.Yemen },
                        new DotNetPowCountryIsoModel { Id = 57, Name = "Zambia", Iso2 = "ZM", Iso3 = "ZMB", Fips = "ZA", IsoNumeric = "894", PhoneCode = "260", CapitalCity = "Lusaka", DotNetPowFlagName = DotNetPowFlagNames.Zambia },
                        new DotNetPowCountryIsoModel { Id = 58, Name = "Zimbabwe", Iso2 = "ZW", Iso3 = "ZWE", Fips = "ZI", IsoNumeric = "716", PhoneCode = "263", CapitalCity = "Harare", DotNetPowFlagName = DotNetPowFlagNames.Zimbabwe },

                        // Variate Iso countries/territories
                        new DotNetPowCountryIsoModel { Id = 99001, Name = "Bouvet Island", Iso2 = "BV", Iso3 = "BVT", Fips = "NO", IsoNumeric = "578", PhoneCode = "47", CapitalCity = "Oslo", DotNetPowFlagName = DotNetPowFlagNames.Bouvet_Island },
                        new DotNetPowCountryIsoModel{ Id = 99002, Name = "Caribbean Netherlands", Iso2 = "BQ", Iso3 = "BES", Fips = "NL", IsoNumeric = "528", PhoneCode = "599", CapitalCity = "Amsterdam", DotNetPowFlagName = DotNetPowFlagNames.Caribbean_Netherlands },
                        new DotNetPowCountryIsoModel{ Id = 99003, Name = "French Southern Antarctic Lands", Iso2 = "TF", Iso3 = "ATF", Fips = "", IsoNumeric = "", PhoneCode = "262", CapitalCity = "Port-aux-Francais", DotNetPowFlagName = DotNetPowFlagNames.French_Southern_Antarctic_Lands },
                        new DotNetPowCountryIsoModel { Id = 99004,  Name = "Heard Island and McDonald Islands", Iso2 = "HM", Iso3 = "HMD", Fips = "", IsoNumeric = "", PhoneCode = "", CapitalCity = "", DotNetPowFlagName = DotNetPowFlagNames.Heard_McDonald_Islands },
                        new DotNetPowCountryIsoModel { Id = 99005, Name = "South Georgia and the South Sandwich Islands", Iso2 = "GS", Iso3 = "SGS", Fips = "", IsoNumeric = "", PhoneCode = "500", CapitalCity = "King Edward Point", DotNetPowFlagName = DotNetPowFlagNames.South_Georgia },
                        new DotNetPowCountryIsoModel { Id = 99006, Name = "Territory of Norfolk Island", Iso2 = "NF", Iso3 = "NFK", Fips = "", IsoNumeric = "", PhoneCode = "672", CapitalCity = "Kingston", DotNetPowFlagName = DotNetPowFlagNames.Territory_Norfolk_Island },
                        
                        new DotNetPowCountryIsoModel{ Id = 99010, Name = "Scotland", Iso2 = "gb-SCT", CapitalCity = "Edinburgh", PhoneCode = "44", Iso3 = "SCT", Fips = "UK", IsoNumeric = "826", DotNetPowFlagName = DotNetPowFlagNames.Scotland, 
                            Languages = new List<DotNetPowApplicationLanguageModel>
                            { 
                                new DotNetPowApplicationLanguageModel(CultureInfo.GetCultureInfo("gb-GD"), DotNetPowFlagNames.Scotland)
                            } 
                        },
                        new DotNetPowCountryIsoModel { Id = 99011, Name = "Northern Ireland", Iso2 = "gb-NIR", CapitalCity = "Belfast", Fips = "UK", Iso3 = "NIR", IsoNumeric = "826", DotNetPowFlagName = DotNetPowFlagNames.Northern_Ireland },
                        new DotNetPowCountryIsoModel { Id = 99012, Name = "England", Iso2 = "gb-ENG", CapitalCity = "London", PhoneCode = "44", Iso3 = "ENG", Fips = "UK", IsoNumeric = "826", DotNetPowFlagName = DotNetPowFlagNames.England },
                        new DotNetPowCountryIsoModel { Id = 99013, Name = "Wales", Iso2 = "gb-WLS", CapitalCity = "Cardiff", PhoneCode = "44", Iso3 = "WLS", Fips = "UK", IsoNumeric = "826", DotNetPowFlagName = DotNetPowFlagNames.Wales }
                    };
                    SetCountryLanguages();
                }

                return _dotNetPowCountryIsoModels.AsReadOnly();
            }
        }

        /// <summary>
        /// Set the country languages
        /// </summary>
        private static void SetCountryLanguages()
        {
            var availableCultureInfo = CultureInfo.GetCultures(CultureTypes.AllCultures);

            foreach (var country in _dotNetPowCountryIsoModels.Where(x => x.Id < 99000))
            {
                var iso2 = country.Iso2;
                var countryCultures = availableCultureInfo.Where(x =>
                    x.Name.ToLower().EndsWith("-" + iso2.ToLower())
                    || x.Name.ToLower() == iso2.ToLower() + "-" + iso2.ToLower()
                ).ToList();

                foreach (var countryCulture in countryCultures)
                {
                    country.Languages.Add(new DotNetPowApplicationLanguageModel(countryCulture, country.DotNetPowFlagName));
                }
            }
        }
    }
}
