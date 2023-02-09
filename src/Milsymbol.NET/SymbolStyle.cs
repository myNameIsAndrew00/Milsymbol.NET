using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milsymbol.NET
{
    internal class SymbolStyle
    {
        private static readonly Color DefaultOutlineColor = Color.FromArgb(239, 239, 239);

        /// <summary>
        /// 2525D lets you choose between MEDAL icn and alternate MEDAL icn for Mines; default is set to MEDAL.
        /// </summary>
        public bool AlternateMedal { get; set; } = false;

        /// <remarks>
        /// Should we use the Civilian Purple defined in 2525? (We set this to default because I like the color.
        /// </remarks>
        public bool CivilianColor { get; set; } = true;

        /// <summary>
        /// 2525C Allows you to use Dark; Medium or Light colors. The values you can set are "Dark";"Medium" or "Light".
        /// </summary>
        //todo: should be changed to a enumeration
        public string ColorMode { get; set; } = "Light";

        /// <summary>
        /// Specify if icon should be filled with color.
        /// </summary>
        public bool Fill { get; set; } = true;  

        /// <summary>
        /// Possibility to change the fill opacity.
        /// </summary>
        public int FillOpacity { get; set; } = 1;

        /// <summary>
        /// The font family to use. 
        /// </summary>
        public FontFamily FontFamily { get; set; } = new FontFamily("Arial");

        /// <summary>
        /// Specify if icon should be framed.
        /// </summary>
        public bool Frame { get; set; } = true; 

        /// <summary>
        /// Overrides the frame default color (black).
        /// </summary>
        public string? FrameColor { get; set; }

        /// <summary>
        /// The default length of the HQ staf 
        /// </summary>
        public int HQStaffLength { get; set; } = 0; 

        /// <summary>
        /// Specify if icon should be displayed.
        /// </summary>
        public bool Icon { get; set; } = true; 

        public string? IconColor { get; set; }

        /// <summary>
        /// Specify the color behind texts.
        /// </summary>
        public string? InfoBackground { get; set; }  

        /// <summary>
        /// Specify the color of sqares frame.
        /// </summary>
        public string? InfoBackgroundFrame { get; set; }

        /// <summary>
        /// Changes the color of the info fields. 
        /// </summary>
        public string? InfoColor { get; set; }

        /// <summary>
        /// If you have set all info fields but don't want the displayed; then just set this to false. 
        /// </summary>
        public bool InfoFields { get; set; } = true;

        /// <summary>
        /// Color of the text outline.
        /// </summary>
        public Color InfoOutlineColor { get; set; } = DefaultOutlineColor;

        /// <summary>
        /// Width of the text-field outline. 
        /// </summary>
        public bool InfoOutlineWidth { get; set; } = false;

        /// <summary>
        /// Relative size of the info fields
        /// </summary>
        public int InfoSize { get; set; } = 40;

        /// <summary>
        /// Check if icon should be monocromatic.
        /// </summary>
        public string? MonoColor { get; set; }

        /// <summary>
        /// Color of the outline
        /// </summary>
        public Color OutlineColor { get; set; } = DefaultOutlineColor;

        /// <summary>
        /// Width of the outline.
        /// </summary>
        public int OutlineWidth { get; set; }

        /// <summary>
        /// Extra padding around the symbol
        /// </summary>
        public int Padding { get; set; }

        /// <summary>
        /// Force use of simple status modifiers 
        /// </summary>
        public bool SimpleStatusModifier { get; set; } = false;

        /// <summary>
        /// The symbol size is actually the L variable in the symbols so the symbol will be larger than this size.
        /// </summary>
        public int Size { get; set; } = 100;

        /// <summary>
        /// If the symbol should be square. 
        /// </summary>
        public bool Square { get; set; } = false;

        /// <summary>
        /// Set standard override.
        /// </summary>
        public string? Standard { get; set; }

        /// <summary>
        /// The stroke width of he icon frame. 
        /// </summary>
        public int StrokeWidth { get; set; } = 4; 
    }
}
