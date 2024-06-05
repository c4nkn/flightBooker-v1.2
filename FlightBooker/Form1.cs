using FlightBooker.Data;
using FlightBooker.Models;
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
        private List<Airport> departureAirports;

        public MainForm()
        {
            using (var context = new AppDbContext())
            {
                context.Database.EnsureCreated();

                if (!context.Aircrafts.Any() && !context.Airports.Any() && !context.Flights.Any())
                {
                    DbLoader.InitDatabase(context);
                }
                departureAirports = context.Flights
                    .Select(f => f.Departure)
                    .Distinct()
                    .ToList();
            }

            InitializeComponent();
            LoadFonts();

            //label1.Font = new Font(fontCollection.Families[0], label1.Font.Size);
            comboBox1.DataSource = departureAirports;
            comboBox1.DisplayMember = "Name";
            comboBox1.SelectedIndex = -1;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;

            if(comboBox1.SelectedIndex <= -1)
            {
                comboBox2.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Airport selectedDeparture = (Airport)comboBox1.SelectedItem;

            using (var context = new AppDbContext())
            {
                List<Airport> arrivalAirports = context.Flights
                    .Where(f => f.Departure.ICAOCode == selectedDeparture.ICAOCode)
                    .Select(f => f.Destination)
                    .Distinct()
                    .ToList();


                comboBox2.DataSource = arrivalAirports;
                comboBox2.DisplayMember = "Name";
                comboBox2.SelectedIndexChanged += ComboBox2_SelectedIndexChanged;
                comboBox2.SelectedIndex = -1;
                comboBox2.Enabled = true;
            }
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex > -1)
            {
                button1.Enabled = true;
            }
        }

        private void LoadFonts()
        {
            fontCollection.AddFontFile("..\\..\\Fonts\\GeistMono-Light.ttf");
            fontCollection.AddFontFile("..\\..\\Fonts\\Geist-Regular.ttf");
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Airport selectedDeparture = (Airport)comboBox1.SelectedItem;
            Airport selectedArrival = (Airport)comboBox2.SelectedItem;

            ReservationForm reservationForm = new ReservationForm(selectedDeparture.Id, selectedArrival.Id);
            reservationForm.Show();
            this.Owner = reservationForm;
            this.Hide();
        }
    }
}
