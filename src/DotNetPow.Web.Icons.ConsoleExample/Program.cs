using System.Collections.Generic;
using System.IO;
using System.Reflection;
using DotNetPow.Web.Icons.DotNetPowFlags;

namespace DotNetPow.Web.Icons.ConsoleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------------------------------------------------------------------------------------------------------------------------------------------
            // Grab instance of the generator and set some generation properties/options with single images directory
            var dotNetPowFlagsGenerator = new DotNetPowFlagsGenerator()
            {
                // Generate files to directory; default is the current project in the "dot-net-pow-flags" folder
                DotNetPowFlagsLibraryPath = GetOutputDirectory("dot-net-pow-flags"),

                // Flag sizes; these are predefined image sizes either height or width proportional, default is all predefined sizes 
                GenerateFlagSizes = new List<DotNetPowFlagSizes> {  DotNetPowFlagSizes.H24, DotNetPowFlagSizes.H48 },

                // Use custom default size
                UseCustomSizeAsDefaultSize = false,

                // Default size for flags
                DefaultDotNetPowFlagSize = DotNetPowFlagSizes.H20,

                // Only generate a single images directory, styles for DotNetPowFlagSizes are applied using CSS dimensions, 
                // different images are not used for size classes
                GenerateSingleImageDirectory = false,

                // The base images used if a single image directory is used
                BaseFlagSizeForSingleImageGeneration = DotNetPowFlagSizes.H120,

                // Include culture specific CSS Classes
                //      .dot-net-pow-flags.en-us ~ English (United States)
                //      .dot-net-pow-flags.en-es ~ Spanish (United States)
                GenerateIso2CultureSpecificCssClasses = true,

                // Include ISO2 Country Code CSS Classes;
                //      .dot-net-pow-flags.us
                //      .dot-net-pow-flags.mx
                GenerateIso2CountryCodeCssClasses = true,

                // Including verbose CSS Class names; will make the css file larger but can be used if 
                // verbosity in naming is a convention used/preferred in the application; default is false
                //      -------------------------------------------------------------------------------
                //      .dot-net-pow-flags.iso2-language-code-en-iso2-country-code-us,
                //      -------------------------------------------------------------------------------
                IncludeVerboseClassNames = false,

                // Generate an example page to view/use as a reference 
                GenerateExampleHtmlPage = true
            };

            // Generate
            dotNetPowFlagsGenerator.GenerateDotNetPowFlagsLibrary();

            // ---------------------------------------------------------------------------------------------------------------------------------------------
            // Grab instance of the generator and set some generation properties/options with multiple images directory
            var dotNetPowFlagsGenerator2 = new DotNetPowFlagsGenerator()
            {
                // Generate files to directory; default is the current project in the "dot-net-pow-flags-2" folder
                DotNetPowFlagsLibraryPath = GetOutputDirectory("dot-net-pow-flags-2"),

                // Flag sizes; these are predefined image sizes either height or width proportional, default is all predefined sizes 
                GenerateFlagSizes = new List<DotNetPowFlagSizes> { DotNetPowFlagSizes.H160 },

                // Use custom default size
                UseCustomSizeAsDefaultSize = true,

                // Custom sizes
                GenerateCustomFlagSizes = new List<DotNetPowCustomFlagSizeModel>
                {
                    new DotNetPowCustomFlagSizeModel { BaseFlagSize = DotNetPowFlagSizes.W2560, CssClassName = "w36h24", DotNetPowFlagImageGenerationMethod = DotNetPowFlagImageGenerationMethods.StretchImage, Height = 24, Width = 36, IsDefaultSize = true },
                    new DotNetPowCustomFlagSizeModel { BaseFlagSize = DotNetPowFlagSizes.W2560, CssClassName = "w60", DotNetPowFlagImageGenerationMethod = DotNetPowFlagImageGenerationMethods.WidthProportional, Width = 60}
                },

                // Default size for flags; size if no size class is added
                //      dot-net-pow-flags us h48
                //      dot-net-pow-flags us h160
                DefaultDotNetPowFlagSize = DotNetPowFlagSizes.H160,

                // Only generate a single images directory, styles for DotNetPowFlagSizes are applied using CSS dimensions, 
                // different images are not used for size classes
                GenerateSingleImageDirectory = false,

                // The base images used if a single image directory is used
                BaseFlagSizeForSingleImageGeneration = DotNetPowFlagSizes.H120,

                // Include culture specific CSS Classes
                //      .dot-net-pow-flags.en-us ~ English (United States)
                //      .dot-net-pow-flags.en-es ~ Spanish (United States)
                GenerateIso2CultureSpecificCssClasses = false,

                // Include ISO2 Country Code CSS Classes;
                //      .dot-net-pow-flags.us
                //      .dot-net-pow-flags.mx
                GenerateIso2CountryCodeCssClasses = true,

                // Including verbose CSS Class names; will make the css file larger but can be used if 
                // verbosity in naming is a convention used/preferred in the application; default is false
                //      -------------------------------------------------------------------------------
                //      .dot-net-pow-flags.iso2-language-code-en-iso2-country-code-us,
                //      -------------------------------------------------------------------------------
                IncludeVerboseClassNames = false,

                // Generate an example page to view/use as a reference 
                GenerateExampleHtmlPage = true
            };

            // Generate
            dotNetPowFlagsGenerator2.GenerateDotNetPowFlagsLibrary();
        }

        /// <summary>
        /// Get /create folder to write files to in the current project
        /// </summary>
        static string GetOutputDirectory(string outputDirectoryName)
        {
            // Get the root project directory
            var currentPathDirectory = new DirectoryInfo(Assembly.GetExecutingAssembly().Location);
            var currentPath = currentPathDirectory.FullName;

            while (!currentPath.EndsWith("DotNetPow.Web.Icons.ConsoleExample"))
            {
                currentPathDirectory = currentPathDirectory.Parent;
                currentPath = currentPathDirectory.FullName;
            }

            // Get the default path; change to whatever
            var directory = Path.Combine(currentPath, outputDirectoryName);

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            return directory;
        }
    }
}
