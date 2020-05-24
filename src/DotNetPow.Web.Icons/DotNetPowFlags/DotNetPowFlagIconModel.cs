using System.Drawing;
using System.Drawing.Drawing2D;

namespace DotNetPow.Web.Icons.DotNetPowFlags
{
    /// <summary>
    /// Reference model for .Net Pow! Flag Icons
    /// </summary>
    public class DotNetPowFlagIconModel : IconModel<DotNetPowFlagNames>
    {
        private DotNetPowFlagNames _flagName = DotNetPowFlagNames.DotNetPowAlt;
        private DotNetPowFlagSizes _flagSize = DotNetPowFlagSizes.H48;

        /// <summary>
        /// Create reference model using the flag name.
        /// </summary>
        public DotNetPowFlagIconModel(DotNetPowFlagNames flagName)
        {
            Name = flagName;
        }

        /// <summary>
        /// Create reference model using the flag name and size.
        /// </summary>
        public DotNetPowFlagIconModel(DotNetPowFlagNames flagName, DotNetPowFlagSizes flagSize)
        {
            _flagSize = flagSize;
            Name = flagName;
        }

        /// <summary>
        /// Create reference model using the flag name, the base flag size used to resize
        /// </summary>
        /// <param name="resizeToHeight">Resize to height; if 0, size is proportional to the width.</param>
        /// <param name="resizeToWidth">Resize to width; if 0, size is proportional to the height</param>
        public DotNetPowFlagIconModel(DotNetPowFlagNames flagName, DotNetPowFlagSizes baseFlagSize, int resizeToHeight, int resizeToWidth, string customFlagSizeCssClassName)
        {
            _flagSize = baseFlagSize;
            FlagSizeCssClassName = customFlagSizeCssClassName;
            Height = resizeToHeight;
            Width = resizeToWidth;
            Name = flagName;
        }

        /// <summary>
        /// Which flag it is; also sets model properties
        /// </summary>
        public override DotNetPowFlagNames Name
        {
            get 
            {
                return _flagName;
            }
            set
            {
                _flagName = value;

                // No height or width / no resizing
                if(Height == 0 && Width == 0)
                {
                    var flagDirectory = _flagSize.ToDefaultImageDirectoryName();
                    IconImage = Image.FromFile("DotNetPowFlags\\Images\\" + flagDirectory + "\\" + StaticDotNetPowFlagDefinitions.DotNetPowFlagImages[_flagName]);
                    Height = IconImage.Height;
                    Width = IconImage.Width;
                    IconCssClass = StaticDotNetPowFlagDefinitions.DotNetPowFlagsCssClassNames[_flagName];
                    FlagSizeCssClassName = _flagSize.ToString().ToLower();
                }
                else
                {
                    var flagDirectory = _flagSize.ToDefaultImageDirectoryName();
                    var img = Image.FromFile("DotNetPowFlags\\Images\\" + flagDirectory + "\\" + StaticDotNetPowFlagDefinitions.DotNetPowFlagImages[_flagName]);
                    var imgWidth = img.Width;
                    var imgHeight = img.Height;
                    IconCssClass = StaticDotNetPowFlagDefinitions.DotNetPowFlagsCssClassNames[_flagName];

                    // Width proportional
                    if (Height == 0)
                    {
                        var widthPercent = ((float)Width / (float)imgWidth);
                        var newHeight = (int)(imgHeight * widthPercent);

                        var newImage = new Bitmap(Width, newHeight);
                        using (var graphics = Graphics.FromImage(newImage))
                        {
                            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                            graphics.DrawImage(img, 0, 0, Width, newHeight);
                        }

                        IconImage = newImage;
                    } 
                    // Height proportional
                    else if (Width == 0)
                    {
                        var heightPercent = ((float)Height / (float)imgHeight);
                        var newWidth = (int)(imgWidth * heightPercent);

                        var newImage = new Bitmap(newWidth, Height);
                        using (var graphics = Graphics.FromImage(newImage))
                        {
                            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                            graphics.DrawImage(img, 0, 0, newWidth, Height);
                        }

                        IconImage = newImage;
                    }
                    // Stretch
                    else
                    {
                        var newImage = new Bitmap(Width, Height);
                        using (var graphics = Graphics.FromImage(newImage))
                        {
                            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                            graphics.DrawImage(img, 0, 0, Width, Height);
                        }

                        IconImage = newImage;
                    }
                }
            }
        }

        /// <summary>
        /// Height in pixels of the icon image
        /// </summary>
        public int Height { get; set; } = 0;

        /// <summary>
        /// Width in pixels of the icon image
        /// </summary>
        public int Width { get; set; } = 0;

        /// <summary>
        /// The CSS Classname for the size. Also used as the directory with multiple image output directories.
        /// </summary>
        public string FlagSizeCssClassName { get; private set; }
    }
}
