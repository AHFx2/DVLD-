using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Interface.GlobalClasses
{
    public class clsFormat
    {
        public static string DateToShort(DateTime Dt1)
        {

            return Dt1.ToString("dd/MMM/yyyy");
        }

        public static void CenterLabelToPictureBox(Control Chaild, Control Parent)
        {
            // Assuming `pictureBox1` is your PictureBox and `label1` is your Label.

            int pictureLeft = Parent.Left;
            int pictureTop = Parent.Top;
            int pictureWidth = Parent.Width;
            int pictureHeight = Parent.Height;

            int labelWidth = Chaild.Width;

            // Center the Label horizontally relative to the PictureBox
            Chaild.Left = pictureLeft + (pictureWidth - labelWidth) / 2;

            // Position the Label below the PictureBox
            Chaild.Top = pictureTop + pictureHeight - 5; // 10px spacing below the PictureBox
        }


    }
}
