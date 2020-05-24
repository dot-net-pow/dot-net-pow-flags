using DotNetPow.Core.Addresses;
using Newtonsoft.Json;
using NUglify;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace DotNetPow.Web.Icons.DotNetPowFlags
{
    /// <summary>
    /// .Net Pow! Flags Library Generator; used to generate the Css file and images based on the settings of the class.
    /// </summary>
    public class DotNetPowFlagsGenerator
    {
        /// <summary>
        /// Create a new instance of the .Net Pow! Flags Generator.
        /// </summary>
        public DotNetPowFlagsGenerator() { }

        /// <summary>
        /// Where the .Net Pow! Flags Library will be generated.
        /// </summary>
        /// <example>
        /// var generator = new DotNetPowFlagsGenerator();
        /// generator.DotNetPowFlagsLibraryPath = @"C:\MyProject\MyWeb\wwwroot\lib\dot-net-pow-flags";
        /// generator.GenerateDotNetPowFlagsLibrary();
        /// </example>
        public string DotNetPowFlagsLibraryPath { get; set; }

        /// <summary>
        /// If true, verbose CSS Classes are generated; 
        /// dot-net-pow-flags.country-iso2-us
        /// dot-net-pow-flags.language-iso2-en-country-iso2-us
        /// dot-net-pow-flags.us
        /// dot-net-pow-flags.en-us
        /// dot-net-pow-flags.united-states
        /// </summary>
        public bool IncludeVerboseClassNames { get; set; } = false;

        /// <summary>
        /// Generate CSS Classes for ISO 2 digit country codes; default is true
        /// us: United States
        /// es: Spain
        /// mx: Mexico
        /// fr: France
        /// ...
        /// </summary>
        public bool GenerateIso2CountryCodeCssClasses { get; set; } = true;

        /// <summary>
        /// Generate CSS Classes using the country names; default is true
        ///     dot-net-pow-flags united-states
        /// </summary>
        public bool GenerateCountryNameCssClasses { get; set; } = true;

        /// <summary>
        /// Generate culture specific CSS Classes. 
        /// es-ES: Spain
        /// es-MX: Mexico
        /// </summary>
        /// <remarks>
        /// Languages defined in the Iso2LanguageFlags dictionary are ignored if GenerateIso2LanguageToFlagCssClasses is true.
        /// </remarks>
        public bool GenerateIso2CultureSpecificCssClasses { get; set; } = true;

        /// <summary>
        /// Only create a single image directory and "cover" / stretch the flag images
        /// </summary>
        public bool GenerateSingleImageDirectory { get; set; } = true;

        /// <summary>
        /// Default size of flag images
        /// </summary>
        public DotNetPowFlagSizes DefaultDotNetPowFlagSize { get; set; } = DotNetPowFlagSizes.H48;

        /// <summary>
        /// If a custom defined size should be used as the default size.
        /// </summary>
        public bool UseCustomSizeAsDefaultSize { get; set; }

        /// <summary>
        /// Which flag image to use for creating image styles with a single images directory. 
        /// </summary>
        public DotNetPowFlagSizes BaseFlagSizeForSingleImageGeneration { get; set; } = DotNetPowFlagSizes.H160;
        
        /// <summary>
        /// The list of sizes to generate CSS Classes for; default is all. This will also create all of the images directories if GenerateSingleImageDirectory is false.
        /// </summary>
        public List<DotNetPowFlagSizes> GenerateFlagSizes { get; set; } = new List<DotNetPowFlagSizes>() 
        {
            DotNetPowFlagSizes.H20,
            DotNetPowFlagSizes.H24, 
            DotNetPowFlagSizes.H48, 
            DotNetPowFlagSizes.H80,
            DotNetPowFlagSizes.H120,
            DotNetPowFlagSizes.H160,
            DotNetPowFlagSizes.H240,

            DotNetPowFlagSizes.W320,
            DotNetPowFlagSizes.W550,
            DotNetPowFlagSizes.W640,
            DotNetPowFlagSizes.W702,
            DotNetPowFlagSizes.W1160,
            DotNetPowFlagSizes.W1600,
            DotNetPowFlagSizes.W2560
        };

        /// <summary>
        /// List of any custom sizes to generate; default is empty list.
        /// </summary>
        public List<DotNetPowCustomFlagSizeModel> GenerateCustomFlagSizes { get; set; } = new List<DotNetPowCustomFlagSizeModel>();

        /// <summary>
        /// Generate an example page with all of the flags.  
        /// </summary>
        public bool GenerateExampleHtmlPage { get; set; } = true;

        /// <summary>
        /// Generate the .Net Pow! Flags Library.
        /// </summary>
        public void GenerateDotNetPowFlagsLibrary(bool clearOutputDirectory = true)
        {
            var styleBuilder = new StringBuilder();
            var prefix = StaticDotNetPowFlagDefinitions.DotNetPowCssClassPrefix;
            var dotPrefix = "." + prefix;
            
            styleBuilder.Append(dotPrefix + " { \r\n");
            styleBuilder.Append("\tbackground-position-x: center;\r\n");
            styleBuilder.Append("\tbackground-position-y: center;\r\n");
            styleBuilder.Append("\tbackground-repeat: no-repeat;\r\n");
            styleBuilder.Append("\tdisplay: inline-block;\r\n");
            styleBuilder.Append("}\r\n\r\n");

            var countries = StaticDotNetPowAddressDefinitions.DotNetPowCountryIsoModels;
            var defaultCustomSize = GenerateCustomFlagSizes.FirstOrDefault(x => x.IsDefaultSize);
            var flagIcons = new List<DotNetPowFlagIconModel>();
            var backgroundUrl = "\tbackground-image: url(images/{0});\r\n";
            var backgroundSize = "\tbackground-size: {0}px {1}px;\r\n";
            var width = "\twidth: {0}px;\r\n";
            var height = "\theight: {0}px;\r\n";

            foreach (var country in countries)
            {
                // Placeholder for CSS Classes
                var countryClasses = new List<string>();

                // Placeholder for CSS Styles
                var countryStyles = new List<string>();

                // dot-net-pow-flags.us
                if (GenerateIso2CountryCodeCssClasses)
                {
                    countryClasses.Add(country.Iso2.ToLower());

                    // .dot-net-pow-flags.country-iso2-us
                    if (IncludeVerboseClassNames)
                    {
                        countryClasses.Add("country-iso2-" + country.Iso2.ToLower());
                    }
                }

                // .dot-net-pow-flags.united-states
                if (GenerateCountryNameCssClasses)
                {
                    countryClasses.Add(country.Name.Replace(" ", "-").Replace(".", "").ToLower());
                }

                // .dot-net-pow-flags.en-us
                if (GenerateIso2CultureSpecificCssClasses)
                {
                    foreach(var language in country.Languages)
                    {
                        countryClasses.Add(language.Name.ToLower());

                        // .dot-net-pow-flags.country-iso2-*-language-iso2-*
                        if (IncludeVerboseClassNames)
                        {
                            countryClasses.Add("country-iso2-" + country.Iso2.ToLower() + "-language-iso2-" + language.Iso2LanguageCode.ToLower());
                        }
                    }
                }

                // ------------------------------------------------------------------------------------------------------------------------------
                // Append Default CSS Classes
                for(var i = 0; i < countryClasses.Count; i++)
                {
                    styleBuilder.Append(dotPrefix + "." + countryClasses[i] + (i == countryClasses.Count - 1 ? "\r\n" : ",\r\n"));
                }

                // ------------------------------------------------------------------------------------------------------------------------------
                // Determine default image path and size for country flag(s)
                DotNetPowFlagIconModel defaultCountryFlagIcon;
                
                string imageUrl = null;
                if (GenerateSingleImageDirectory)
                {
                    imageUrl = country.DotNetPowFlagName.ToDotNetPowFlagImageName();

                    if (UseCustomSizeAsDefaultSize)
                    {
                        defaultCountryFlagIcon = new DotNetPowFlagIconModel(country.DotNetPowFlagName, defaultCustomSize.BaseFlagSize, defaultCustomSize.Height, defaultCustomSize.Width, defaultCustomSize.CssClassName);
                    }
                    else
                    {
                        defaultCountryFlagIcon = new DotNetPowFlagIconModel(country.DotNetPowFlagName, DefaultDotNetPowFlagSize);
                    }
                }
                else
                {
                    if (UseCustomSizeAsDefaultSize)
                    {
                        defaultCountryFlagIcon = new DotNetPowFlagIconModel(country.DotNetPowFlagName, defaultCustomSize.BaseFlagSize, defaultCustomSize.Height, defaultCustomSize.Width, defaultCustomSize.CssClassName);
                        imageUrl = defaultCustomSize.CssClassName + "/" + country.DotNetPowFlagName.ToDotNetPowFlagImageName();
                    }
                    else
                    {
                        defaultCountryFlagIcon = new DotNetPowFlagIconModel(country.DotNetPowFlagName, DefaultDotNetPowFlagSize);
                        imageUrl = DefaultDotNetPowFlagSize.ToDefaultImageDirectoryName() + "/" + country.DotNetPowFlagName.ToDotNetPowFlagImageName();
                    }
                }

                // ------------------------------------------------------------------------------------------------------------------------------
                // styles
                styleBuilder.Append("{\r\n");
                styleBuilder.Append(string.Format(backgroundUrl, imageUrl));
                styleBuilder.Append(string.Format(backgroundSize, defaultCountryFlagIcon.IconImage.Width, defaultCountryFlagIcon.IconImage.Height));
                styleBuilder.Append(string.Format(width, defaultCountryFlagIcon.IconImage.Width));
                styleBuilder.Append(string.Format(height, defaultCountryFlagIcon.IconImage.Height));
                styleBuilder.Append("}\r\n\r\n");

                flagIcons.Add(defaultCountryFlagIcon);

                // ------------------------------------------------------------------------------------------------------------------------------
                // individual sizes
                foreach(var flagSize in GenerateFlagSizes)
                {
                    if (GenerateSingleImageDirectory)
                    {
                        imageUrl = country.DotNetPowFlagName.ToDotNetPowFlagImageName();
                    }
                    else
                    {
                        imageUrl = flagSize.ToDefaultImageDirectoryName() + "/" + country.DotNetPowFlagName.ToDotNetPowFlagImageName();
                    }

                    for (var i = 0; i < countryClasses.Count; i++)
                    {
                        styleBuilder.Append(dotPrefix + "." + countryClasses[i] + "." + flagSize.ToDefaultImageDirectoryName() + (i == countryClasses.Count - 1 ? "\r\n" : ",\r\n"));
                    }

                    var flagIcon = new DotNetPowFlagIconModel(country.DotNetPowFlagName, flagSize);
                    styleBuilder.Append("{\r\n");
                    styleBuilder.Append(string.Format(backgroundUrl, imageUrl));
                    styleBuilder.Append(string.Format(backgroundSize, flagIcon.IconImage.Width, flagIcon.IconImage.Height));
                    styleBuilder.Append(string.Format(width, flagIcon.IconImage.Width));
                    styleBuilder.Append(string.Format(height, flagIcon.IconImage.Height));
                    styleBuilder.Append("}\r\n\r\n");

                    flagIcons.Add(flagIcon);
                }

                foreach(var customSize in GenerateCustomFlagSizes)
                {
                    var flagIcon = new DotNetPowFlagIconModel(country.DotNetPowFlagName, 
                        customSize.BaseFlagSize, customSize.Height, customSize.Width, customSize.CssClassName);

                    if (GenerateSingleImageDirectory)
                    {
                        imageUrl = country.DotNetPowFlagName.ToDotNetPowFlagImageName();
                    }
                    else
                    {
                        imageUrl = customSize.CssClassName + "/" + country.DotNetPowFlagName.ToDotNetPowFlagImageName();
                    }

                    for (var i = 0; i < countryClasses.Count; i++)
                    {
                        styleBuilder.Append(dotPrefix + "." + countryClasses[i] + "." + customSize.CssClassName + (i == countryClasses.Count - 1 ? "\r\n" : ",\r\n"));
                    }

                    styleBuilder.Append("{\r\n");
                    styleBuilder.Append(string.Format(backgroundUrl, imageUrl));
                    styleBuilder.Append(string.Format(backgroundSize, flagIcon.IconImage.Width, flagIcon.IconImage.Height));
                    styleBuilder.Append(string.Format(width, flagIcon.IconImage.Width));
                    styleBuilder.Append(string.Format(height, flagIcon.IconImage.Height));
                    styleBuilder.Append("}\r\n\r\n");

                    flagIcons.Add(flagIcon);
                }
            }
            // end default country flag styles

            // Add generic border styles
            styleBuilder.Append(".flag-border-1 {\r\n");
            styleBuilder.Append("\tborder: 1px solid rgba(51,51,51, .6);\r\n");
            styleBuilder.Append("}\r\n\r\n");

            styleBuilder.Append(".flag-border-2 {\r\n");
            styleBuilder.Append("\tborder: 2px solid rgba(51,51,51, .6);\r\n");
            styleBuilder.Append("}\r\n\r\n");

            styleBuilder.Append(".flag-border-1-rounded-2 {\r\n");
            styleBuilder.Append("\tborder: 1px solid rgba(51,51,51, .6);\r\n");
            styleBuilder.Append("\tborder-radius: 2px;\r\n");
            styleBuilder.Append("}\r\n\r\n");

            styleBuilder.Append(".flag-border-1-rounded-4 {\r\n");
            styleBuilder.Append("\tborder: 1px solid rgba(51,51,51, .6);\r\n");
            styleBuilder.Append("\tborder-radius: 4px;\r\n");
            styleBuilder.Append("}\r\n\r\n");

            styleBuilder.Append(".flag-border-2-rounded-2 {\r\n");
            styleBuilder.Append("\tborder: 1px solid rgba(51,51,51, .6);\r\n");
            styleBuilder.Append("\tborder-radius: 2px;\r\n");
            styleBuilder.Append("}\r\n\r\n");

            styleBuilder.Append(".flag-border-2-rounded-4 {\r\n");
            styleBuilder.Append("\tborder: 1px solid rgba(51,51,51, .6);\r\n");
            styleBuilder.Append("\tborder-radius: 4px;\r\n");
            styleBuilder.Append("}\r\n\r\n");


            // Create Destination Directories
            if (!Directory.Exists(DotNetPowFlagsLibraryPath))
            {
                Directory.CreateDirectory(DotNetPowFlagsLibraryPath);
            }

            if (!Directory.Exists(DotNetPowFlagsLibraryPath + "\\Images"))
            {
                Directory.CreateDirectory(DotNetPowFlagsLibraryPath + "\\Images");
            }

            // get stylesheet text
            var stylesheet = styleBuilder.ToString();

            // Save css file
            using (var writer = new StreamWriter(DotNetPowFlagsLibraryPath + "\\dot-net-pow-flags.css"))
            {
                writer.Write(stylesheet);
            }

            // Save minified css file
            using (var writer = new StreamWriter(DotNetPowFlagsLibraryPath + "\\dot-net-pow-flags.min.css"))
            {
                writer.Write(Uglify.Css(stylesheet));
            }

            // Copy ico
            if(!File.Exists(DotNetPowFlagsLibraryPath + "\\favicon.ico"))
            {
                File.Copy("favicon.ico", DotNetPowFlagsLibraryPath + "\\favicon.ico");
            }

            // Determine/generate images
            if (GenerateSingleImageDirectory)
            {
                var imageFileDirectory = new DirectoryInfo("DotNetPowFlags\\Images\\" + BaseFlagSizeForSingleImageGeneration.ToDefaultImageDirectoryName());
                var imageFiles = imageFileDirectory.GetFiles("*.png", SearchOption.TopDirectoryOnly);

                foreach (var imageFile in imageFiles)
                {
                    if(File.Exists(DotNetPowFlagsLibraryPath + "\\Images\\" + imageFile.Name))
                    {
                        File.Delete(DotNetPowFlagsLibraryPath + "\\Images\\" + imageFile.Name);
                    }

                    File.Copy(imageFile.FullName, DotNetPowFlagsLibraryPath + "\\Images\\" + imageFile.Name);
                }
            }
            else
            {
                foreach (var flagIcon in flagIcons)
                {
                    if(!Directory.Exists(DotNetPowFlagsLibraryPath + "\\Images\\" + flagIcon.FlagSizeCssClassName))
                    {
                        Directory.CreateDirectory(DotNetPowFlagsLibraryPath + "\\Images\\" + flagIcon.FlagSizeCssClassName);
                    }

                    if(File.Exists(DotNetPowFlagsLibraryPath + "\\Images\\" + flagIcon.FlagSizeCssClassName + "\\" + flagIcon.Name.ToDotNetPowFlagImageName()))
                    {
                        File.Delete(DotNetPowFlagsLibraryPath + "\\Images\\" + flagIcon.FlagSizeCssClassName + "\\" + flagIcon.Name.ToDotNetPowFlagImageName());
                    }

                    flagIcon.IconImage.Save(DotNetPowFlagsLibraryPath + "\\Images\\" + flagIcon.FlagSizeCssClassName + "\\" + flagIcon.Name.ToDotNetPowFlagImageName());
                }
            }

            // Generate html page
            if (GenerateExampleHtmlPage)
            {
                var htmlBuilder = new StringBuilder();
                htmlBuilder.Append("<html>\r\n");
                htmlBuilder.Append("\t<head>\r\n");
                htmlBuilder.Append("\t\t<title>Dot Net Pow Flags Examples</title>\r\n");
                htmlBuilder.Append("\t\t<link rel=\"shortcut icon\" href=\"favicon.ico\" />\r\n");
                htmlBuilder.Append("\t\t<link href=\"dot-net-pow-flags.css\" rel=\"stylesheet\" type=\"text/css\" />\r\n");
                htmlBuilder.Append("\t</head>\r\n");
                htmlBuilder.Append("\t<body>\r\n");

                htmlBuilder.Append("<h2>.Net Pow! Flags Style Generator<br /><span class='" + StaticDotNetPowFlagDefinitions.DotNetPowCssClassPrefix + " dot-net-pow-alt flag-border-1-rounded-2'>&nbsp;</span></h2>");
                htmlBuilder.Append("\t\t<table style=\"width: 100%\" border=\"1\">\r\n");

                var col = 0; 
                foreach(var flagIcon in flagIcons)
                {
                    if(col == 0)
                    {
                        htmlBuilder.Append("\t\t\t<tr>\r\n");
                    }
                    else if (col % 10 == 0)
                    {
                        htmlBuilder.Append("\t\t\t</tr>\r\n<tr>\r\n");
                    }

                    var sizeDisplay = "w" + flagIcon.IconImage.Width.ToString() + "px &nbsp;&nbsp; h" + flagIcon.IconImage.Height.ToString() + "px";

                    htmlBuilder.Append("\t\t\t\t<td style=\"text-align: center;padding: 6px 6px 6px 6px;\">");
                    htmlBuilder.Append("<strong>" + flagIcon.Name.ToString().Replace("_", " ") + "</strong><br />");
                    htmlBuilder.Append("<strong>" + flagIcon.IconCssClass + " " + flagIcon.FlagSizeCssClassName + "</strong><br /><br />");
                    htmlBuilder.Append("<span class=\"" + flagIcon.IconCssClass + " " + flagIcon.FlagSizeCssClassName + " flag-border-1-rounded-2\">&nbsp;</span>");
                    htmlBuilder.Append("</td>\r\n");
                    col++;
                }

                htmlBuilder.Append("\t\t</tr></table>\r\n");
                htmlBuilder.Append("\t</body>\r\n");
                htmlBuilder.Append("</html>\r\n");

                using(var writer = new StreamWriter(DotNetPowFlagsLibraryPath + "\\dot-net-pow-flags-examples.html"))
                {
                    writer.Write(htmlBuilder.ToString());
                }
            }
        }
    }
}
