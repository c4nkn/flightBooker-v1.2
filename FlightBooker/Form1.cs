using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightBooker
{
    public partial class MainForm : Form
    {
        private bool isMouseDown;
        private Point lastLocation;
        private PrivateFontCollection fontCollection = new PrivateFontCollection();

        public MainForm()
        {
            InitializeComponent();
            LoadFonts();

            label1.Font = new Font(fontCollection.Families[0], label1.Font.Size);
        }

        private void LoadFonts()
        {
            fontCollection.AddFontFile("..\\..\\Fonts\\GeistMono-Light.ttf");
        }

        public void closeButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        public void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.FromArgb(37, 38, 44);
        }

        public void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.FromArgb(24, 24, 27);
        }

        public void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void minimizeButton_MouseEnter(object sender, EventArgs e)
        {
            minimizeButton.BackColor = Color.FromArgb(37, 38, 44);
        }

        public void minimizeButton_MouseLeave(object sender, EventArgs e)
        {
            minimizeButton.BackColor = Color.FromArgb(24, 24, 27);
        }

        public void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            lastLocation = e.Location;
        }

        public void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        public void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }
    }
}
