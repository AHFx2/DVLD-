using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace DVLD_Interface
{

    static public class SeetingsColor

    {
        public static Color PrimaryColor { get; set; }

        public static Color SecondaryColor { get; set; }
        public static Color ThirdColor { get; set; }
        public static Color FourthColor { get; set; }


        public static List<string> Colors = new List<string>() { "#1E2F42", "#1F3A4D", "#253849", "#2A4C5E", "#3A4E6A", "#4C5D76", "#4A6374", "#4F6D7C", "#5F7087", "#6A7F93", "#2F465B", "#324C62", "#3A4E5A", "#3E5660", "#2C4D5B", "#2A4F58", "#2D3A4B", "#2F4759", "#33424A", "#365157", "#2A3340", "#2C3B47", "#2F3B48", "#3C4B5A", "#2D3C4A", "#31474F", "#3A3E5D", "#3D4B63", "#2A3246", "#2F3A4C"

 };


        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            // If correction factor is less than 0, darken color.
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            // If correction factor is greater than zero, lighten color.
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }

            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }

        private static byte TempIndex;
        
        private static Random rand = new Random();

        static public Color RandomColor()
        {

            // this function will pick a random color and generate analogous color system

            byte index = 0;

            do
            {
                index = Convert.ToByte(rand.Next(Colors.Count));
            } while (index == TempIndex);
            TempIndex = index;
            PrimaryColor = ColorTranslator.FromHtml(Colors[index]);
            
            Color[] colors = GenerateAnalogousColors(PrimaryColor);

            SecondaryColor = colors[0];
            
            ThirdColor = colors[1];

            return PrimaryColor;
        }

        public static Color[] GenerateAnalogousColors(Color baseColor)
        {
            // Convert the base color to HSB (Hue, Saturation, Brightness)
            float hue, saturation, brightness;
            ColorToHSB(baseColor, out hue, out saturation, out brightness);

            // Generate analogous colors by adjusting the hue
            float analogousHue1 = (hue + 30) % 360; // 30 degrees clockwise
            float analogousHue2 = (hue - 30 + 360) % 360; // 30 degrees counterclockwise

            // Convert back to RGB
            Color color1 = HSBToColor(analogousHue1, saturation, brightness);
            Color color2 = HSBToColor(analogousHue2, saturation, brightness);

            return new Color[] { color1, color2 };
        }

        private static void ColorToHSB(Color color, out float hue, out float saturation, out float brightness)
        {
            float r = color.R / 255f;
            float g = color.G / 255f;
            float b = color.B / 255f;

            float max = Math.Max(r, Math.Max(g, b));
            float min = Math.Min(r, Math.Min(g, b));
            float delta = max - min;

            // Calculate hue
            if (delta == 0)
                hue = 0;
            else if (max == r)
                hue = 60 * (((g - b) / delta) % 6);
            else if (max == g)
                hue = 60 * (((b - r) / delta) + 2);
            else
                hue = 60 * (((r - g) / delta) + 4);

            if (hue < 0) hue += 360;

            // Calculate saturation
            saturation = (max == 0) ? 0 : delta / max;

            // Calculate brightness
            brightness = max;
        }

        private static Color HSBToColor(float hue, float saturation, float brightness)
        {
            float c = brightness * saturation;
            float x = c * (1 - Math.Abs((hue / 60) % 2 - 1));
            float m = brightness - c;

            float r = 0, g = 0, b = 0;

            if (0 <= hue && hue < 60)
                (r, g, b) = (c, x, 0);
            else if (60 <= hue && hue < 120)
                (r, g, b) = (x, c, 0);
            else if (120 <= hue && hue < 180)
                (r, g, b) = (0, c, x);
            else if (180 <= hue && hue < 240)
                (r, g, b) = (0, x, c);
            else if (240 <= hue && hue < 300)
                (r, g, b) = (x, 0, c);
            else if (300 <= hue && hue < 360)
                (r, g, b) = (c, 0, x);

            return Color.FromArgb(
                (int)((r + m) * 255),
                (int)((g + m) * 255),
                (int)((b + m) * 255)
            );
        }

        public static Color ChangeHue(Color color, float hueOffset)
        {
            // Convert RGB to HSB
            float hue, saturation, brightness;
            ColorToHSB(color, out hue, out saturation, out brightness);

            // Adjust hue and wrap around to [0, 360] range
            hue = (hue + hueOffset) % 360;
            if (hue < 0) hue += 360;

            // Convert back to RGB and return
            return HSBToColor(hue, saturation, brightness);
        }

        public static double GetLuminance(Color color)
        {
            double r = color.R / 255.0;
            double g = color.G / 255.0;
            double b = color.B / 255.0;

            // Using the luminance formula
            return 0.2126 * r + 0.7152 * g + 0.0722 * b;
        }

        // Function to determine the best font color (black or white)
        public static Color GetFontColorBasedOnBackground(Color backgroundColor)
        {
            double luminance = GetLuminance(backgroundColor);

            // Choose white for dark backgrounds and black for light backgrounds
            return luminance > 0.5 ? Color.Black : Color.DarkGray;
        }


    }
}
