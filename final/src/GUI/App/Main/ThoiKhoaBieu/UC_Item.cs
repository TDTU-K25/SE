using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.App.Main.ThoiKhoaBieu
{
    public partial class UC_Item : UserControl
    {
        public UC_Item()
        {
            InitializeComponent();
            SetRoundedCorners(10);
        }

        public void setMonHoc(string str)
        {
            txt_tenmonhoc.Text = str;
        }

        public void setPhongHoc(string str) { 
            txt_phonghoc.Text = str;
        }

        public void setDayStart(string str)
        {
            txt_ngaubatdau.Text = str;
        }

        public void setDayEnd(string str)
        {
            txt_ngayketthuc.Text = str;
        }


        public void setBackGround(Color color)
        {
            this.BackColor = color;
        }

        // SET BORDER RADIUS FOR USER CONTROL
        private void SetRoundedCorners(int radius)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                int width = this.Width;
                int height = this.Height;

                // Create a path with rounded corners
                path.AddArc(0, 0, radius, radius, 180, 90); // Top-left corner
                path.AddArc(width - radius, 0, radius, radius, 270, 90); // Top-right corner
                path.AddArc(width - radius, height - radius, radius, radius, 0, 90); // Bottom-right corner
                path.AddArc(0, height - radius, radius, radius, 90, 90); // Bottom-left corner
                path.CloseAllFigures();

                // Set the Region property with the created path
                this.Region = new Region(path);
            }
        }
    }
}
