namespace DotNetPow.Web.Icons.DotNetPowFlags
{
    /// <summary>
    /// Used to determine how custom flag sizes/images are generated.
    /// </summary>
    public enum DotNetPowFlagImageGenerationMethods
    {
        /// <summary>
        /// Stretch the image to the specific size using both Height and Width
        /// </summary>
        StretchImage,

        /// <summary>
        /// Scale the image to the Height, Width is ignored.
        /// </summary>
        HeightProportional,

        /// <summary>
        /// Scale the image to the Width, Height is ignored.
        /// </summary>
        WidthProportional
    }
}
