using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyColors
{
    /// <summary>
    /// Color class properties to be used with datagridview,
    /// So data from System.Drawing.Color displays correctly
    /// </summary>
    public class MyColor
    {
        /// <summary>
        /// System.Drawing.Color object for storing all actual information of the color
        /// </summary>
        private Color _color;

        /// <summary>
        /// Name of the color is doesn't exist return null
        /// </summary>
        public string Name => (_color.IsNamedColor) ? _color.Name : null;

        /// <summary>
        /// Return hex code of color
        /// </summary>
        public string HtmlHex => _color.ToArgb().ToString("X6");

        /// <summary>
        /// Red 
        /// </summary>
        public byte R => _color.R;

        /// <summary>
        /// Green
        /// </summary>
        public byte G => _color.G;

        /// <summary>
        /// Blue
        /// </summary>
        public byte B => _color.B;

        /// <summary>
        /// Alpha transparency
        /// </summary>
        public byte A => _color.A;

        public MyColor(Color color)
        {
            _color = color;
        }
    }
}
