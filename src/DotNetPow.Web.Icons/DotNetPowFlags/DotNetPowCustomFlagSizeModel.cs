namespace DotNetPow.Web.Icons.DotNetPowFlags
{
    /// <summary>
    /// Used for custom flag sizes during library generation
    /// </summary>
    public class DotNetPowCustomFlagSizeModel
    {
        /// <summary>
        /// The base flag size / image used to generate new image sizes
        /// </summary>
        public DotNetPowFlagSizes BaseFlagSize { get; set; } = DotNetPowFlagSizes.W2560;

        /// <summary>
        ///  What the CSS Class name will be; "h100", "w250", etc.
        /// </summary>
        /// <remarks>If multiple image folders are used, this is also the folder name.</remarks>
        public string CssClassName { get; set; }
        
        /// <summary>
        /// How the custom sized images are generated. 
        /// </summary>
        public DotNetPowFlagImageGenerationMethods DotNetPowFlagImageGenerationMethod { get; set; } = DotNetPowFlagImageGenerationMethods.StretchImage;

        /// <summary>
        /// Height of images
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Width of images
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// If this will be used as the default size
        /// </summary>
        public bool IsDefaultSize { get; set; }
    }
}
