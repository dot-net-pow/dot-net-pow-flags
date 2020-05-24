using System.Drawing;

namespace DotNetPow.Web.Icons.MaterialDesignIcons
{
    /// <summary>
    /// Icon model for Material Design Icon
    /// </summary>
    public class MaterialDesignIconModel : IconModel<MaterialDesignIconNames>
    {
        private MaterialDesignIconNames _iconName = MaterialDesignIconNames.NotSet;

        public MaterialDesignIconModel(MaterialDesignIconNames iconName)
        {
            Name = iconName;
        }

        public override MaterialDesignIconNames Name 
        {
            get { return _iconName; }
            set
            {
                _iconName = value;
                IconCssClass = StaticMaterialDesignIconDefinitions.MaterialDesignIconCssClasses[_iconName];
                UnicodeCharacter = StaticMaterialDesignIconDefinitions.MaterialDesignIconUnicodeCharacters[_iconName];

                var img = new Bitmap(28, 28);
                using (var font = new Font("Material Design Icons", 20, GraphicsUnit.Pixel))
                {
                    var rect = new Rectangle(0, 0, 28, 28);
                    var format = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };

                    using (var graphics = Graphics.FromImage(img))
                    {
                        graphics.DrawString(UnicodeCharacter, font, Brushes.Gray, rect, format);
                        graphics.DrawRectangle(Pens.Transparent, rect);
                    }
                }

                IconImage = img;
            }
        }
        public string UnicodeCharacter
        {
            get; private set;
        }
    }
}
