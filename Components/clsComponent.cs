
using System.Drawing;
using System.Windows.Forms; 
namespace Restaurent.Components
{
    public static class clsComponent
    {
     
        public static Panel CreatePanel(int Pid, Color BackGroundColor, Size size, int padding)
        {
            Panel panel = new Panel
            {
                Name = string.Format("pnlProduct{0}", Pid),
                BackColor = BackGroundColor,
                Size = size,
                Margin = new Padding(padding),
                Tag = Pid.ToString()
            };

            return panel;
        }

    

        public static PictureBox CreatePictureBox(int Pid, Image PImage, Size size, Point Location, PictureBoxSizeMode sizeMood)
        {
            PictureBox picBox = new PictureBox
            {
                Image = PImage,
                Name = string.Format("picBox{0}", Pid),
                Size = size,
                Location = Location,
                SizeMode = sizeMood
            };

            return picBox;
        }

       


        public static Label CreateLabel(int Pid, string text, Point location, Font font, ContentAlignment alignment)
        {
            Label label = new Label
            {
                Text = text,
                Tag = string.Format("ProductLabel{0}", Pid),
                Location = location,
                Font = font,
                TextAlign = alignment
            };


            return label;
        }


        public static NumericUpDown CreateNumericUpDown(int Pid , Point Location , bool ReadOnly) {

            NumericUpDown numericUpDown = new NumericUpDown
            {
                Name = string.Format("numericUpdown{0}", Pid),
                Location = Location,
                Minimum = 1,
                Maximum = 100,
                ReadOnly = ReadOnly
            };
            return numericUpDown;

        }

        public static Button CreateButton(int Pid , string text , string name , Font font , string BackColor , ContentAlignment alignment , Point Location  ,Size size )
        {

            Button btn = new Button
            {
                Text = text,
                Name = name,
                Font = font,
                Size = size,
                BackColor = ColorTranslator.FromHtml(BackColor),
                TextAlign = alignment,
                Location = Location, 
                Tag = Pid.ToString()
            };

            return btn;
        }

        public static Panel CreateItemUi(int Pid, string name, Image PImage)
        {
            Panel panel = CreatePanel(Pid, Color.White, new Size(125, 220), 10);

            PictureBox picBox = CreatePictureBox(Pid, PImage, new Size(100, 100), new Point(12, 10),
                PictureBoxSizeMode.Zoom);

            Label label = CreateLabel(Pid, name, new Point(12, 120),
                new Font(new FontFamily("Arial"), 9.5f, FontStyle.Bold), ContentAlignment.MiddleCenter);

            NumericUpDown numericUpDown = CreateNumericUpDown(Pid, new Point(3, 150), true);

            Button btn = CreateButton(Pid, "Add Product", "btnAddProduct",
                            new Font(new FontFamily("Arial"), 9.5f, FontStyle.Bold), "#f6edb4"
                            , ContentAlignment.MiddleCenter, new Point(7, 180), new Size(110, 30));

            panel.Controls.Add(picBox);
            panel.Controls.Add(label);
            panel.Controls.Add(numericUpDown);
            panel.Controls.Add(btn);
            return panel;

        }

    }
}