using FlightBooker.Data;
using FlightBooker.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace FlightBooker
{
    public partial class ReservationForm : Form
    {
        private bool isMouseDown;
        private Point lastLocation;
        private Airport departureAirport;
        private Airport arrivalAirport;
        public List<string> selectedSeats = new List<string>();
        public int selectedFlight, newId;
        bool tab2, tab3, tab4, isFlightSelected = false;
        private PrivateFontCollection fontCollection = new PrivateFontCollection();
        private List<TextBox> passengerTextBoxes = new List<TextBox>();
        private string GeneratedPNRCode;

        public ReservationForm(int departureAirportId, int arrivalAirportId)
        {
            InitializeComponent();
            LoadFonts();

            using (var context = new AppDbContext())
            {
                departureAirport = context.Airports
                    .Where(a => a.Id == departureAirportId)
                    .FirstOrDefault();

                arrivalAirport = context.Airports
                    .Where(a => a.Id == arrivalAirportId)
                    .FirstOrDefault();

                var filteredFlights = context.Flights
                    .Where(f => f.Departure.Id == departureAirportId && f.Destination.Id == arrivalAirportId)
                    .Include(f => f.Aircraft)
                    .Include(f => f.Departure)
                    .Include (f => f.Destination)
                    .Select(f => new Flight
                    {
                        Id = f.Id,
                        FlightNumber = f.FlightNumber,
                        Date = f.Date,
                        FlightTime = f.FlightTime,
                        DepartureTime = f.DepartureTime,
                        ArrivalTime = f.ArrivalTime,
                        Airline = f.Airline,
                        Aircraft = f.Aircraft,
                        TakenSeats = f.TakenSeats,
                        Departure = f.Departure,
                        Destination = f.Destination,
                        TotalPrice = f.TotalPrice,
                    })
                    .ToList();

                ShowFlights(filteredFlights);
            }

            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.DrawItem += new DrawItemEventHandler(this.tabControl1_DrawItem);

            fromLabel1.Text = departureAirport.City + " (" + departureAirport.ICAOCode + ")";
            toLabel1.Text = arrivalAirport.City + " (" + arrivalAirport.ICAOCode + ")";
            getSeatsBtn.Enabled = false;
        }

        public void ShowFlights(List<Flight> filteredFlights)
        {
            foreach (var flight in filteredFlights)
            {
                if (flight != null)
                {
                    DataGridViewRow dataGridViewRow = new DataGridViewRow();

                    List<string> reservedSeats = flight.TakenSeats.Split(',').Select(seat => seat.Trim()).ToList();
                    int availableSeatsCount = 102 - reservedSeats.Count;
                    string availability = availableSeatsCount.ToString() + " seat(s) left.";

                    dataGridViewRow.CreateCells(
                        dataGridView1,
                        flight.Id,
                        flight.Date,
                        flight.Airline,
                        flight.DepartureTime,
                        flight.ArrivalTime,
                        availability
                    );

                    if (availableSeatsCount < 10)
                    {
                        dataGridViewRow.Cells[5].Style.ForeColor = Color.IndianRed;
                    }
                    else
                    {
                        dataGridViewRow.Cells[5].Style.ForeColor = Color.Green;
                    }

                    dataGridView1.Rows.Add(dataGridViewRow);
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            isFlightSelected = true;
            getSeatsBtn.Enabled = dataGridView1.SelectedRows.Count > 0;

            if (tab2)
            {
                ClearSeatTab();

                if (selectedSeats.Any())
                {
                    foreach (var seat in selectedSeats)
                    {
                        selectedSeats.Remove(seat);
                    }
                }

                tab2 = false;
            }

            if (tab3)
            {
                ClearPassengersTab();
                tab3 = false;
            }

            if (tab4)
            {
                ClearSummaryTab();
                tab4 = false;
            }
        }

        private void getSeatsBtn_Click(object sender, EventArgs e)
        {
            tab2 = true;
            tabControl1.SelectedTab = tabPage2;
            fromLabel2.Text = departureAirport.City + " (" + departureAirport.ICAOCode + ")";

            if (isFlightSelected && dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                int selectedFlightId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells[0].Value);
                selectedFlight = selectedFlightId;

                using (var context = new AppDbContext())
                {
                    var selectedFlight = context.Flights
                        .Where(s => s.Id == selectedFlightId)
                        .FirstOrDefault();

                    toAndDateLbl1.Text = arrivalAirport.City + " (" + arrivalAirport.ICAOCode + "), " + selectedFlight.Date;
                    DrawSeats(selectedFlight.TakenSeats, tabPage2);
                }
            }

            if (!selectedSeats.Any())
            {
                getDetailsBtn.Enabled = false;
            }
        }

        private void DrawSeats(string _reservedSeats, TabPage tabPage)
        {
            List<string> reservedSeats = _reservedSeats.Split(',').Select(seat => seat.Trim()).ToList();

            int leftSectionSize = 3;
            int rightSectionSize = 3;
            int totalRows = leftSectionSize + rightSectionSize;
            int columnSize = 17;

            int buttonWidth = 30;
            int buttonHeight = 30;
            int spacing = 5;
            int aisleSpacing = 20;

            int totalHeight = (leftSectionSize + rightSectionSize) * (buttonHeight + spacing) + aisleSpacing;
            int startX = 120;
            int startY = (tabPage.Height - totalHeight) / 2 - 10;

            for (int i = 0; i < columnSize; i++)
            {
                char rowLetter = (char)('A' + i);

                for (int j = 0; j < leftSectionSize; j++)
                {
                    DrawSeatButton(tabPage, reservedSeats, rowLetter, j + 1, startX, startY, i, j, buttonWidth, buttonHeight, spacing, true);
                }

                for (int j = 0; j < rightSectionSize; j++)
                {
                    DrawSeatButton(tabPage, reservedSeats, rowLetter, leftSectionSize + j + 1, startX, startY + leftSectionSize * (buttonHeight + spacing) + aisleSpacing, i, j, buttonWidth, buttonHeight, spacing, false);
                }
            }
        }

        private void DrawSeatButton(TabPage tabPage, List<string> reservedSeats, char rowLetter, int seatNumber, int startX, int startY, int rowIndex, int colIndex, int buttonWidth, int buttonHeight, int spacing, bool isLeftSection)
        {
            string seatName = $"{rowLetter}{seatNumber}";

            Button seatButton = new Button
            {
                Name = seatName,
                Tag = seatName,
                Image = Image.FromFile("..\\..\\Images\\EmptySeat.png"),
                FlatStyle = FlatStyle.Flat,
                Width = buttonWidth,
                Height = buttonHeight,
                Location = new Point(startX + rowIndex * (buttonWidth + spacing), startY + colIndex * (buttonHeight + spacing))
            };

            if (reservedSeats.Contains(seatName))
            {
                seatButton.Image = Image.FromFile("..\\..\\Images\\TakenSeat.png");
            }
            else
            {
                seatButton.Click += SeatBtn_Click;
            }

            seatButton.FlatAppearance.BorderSize = 0;
            tabPage.Controls.Add(seatButton);
        }

        private void SeatBtn_Click(object sender, EventArgs e)
        {
            if (tab3)
            {
                ClearPassengersTab();
                tab3 = false;
            }

            if (tab4)
            {
                summarySeatsLbl.Text = string.Join(", ", selectedSeats);
                tab4 = false;
            }

            Button seatButton = sender as Button;
            string seatName = seatButton.Name;

            if (selectedSeats.Contains(seatName))
            {
                selectedSeats.Remove(seatName);
                seatButton.Image = Image.FromFile("..\\..\\Images\\EmptySeat.png");
            }
            else
            {
                if (selectedSeats.Count < 8)
                {
                    selectedSeats.Add(seatName);
                    seatButton.Image = Image.FromFile("..\\..\\Images\\SelectedSeat.png");

                    if (selectedSeats.Count > 0)
                    {
                        getDetailsBtn.Enabled = true;
                        getDetailsBtn.FlatAppearance.BorderColor = Color.SeaGreen;
                        getDetailsBtn.ForeColor = Color.SeaGreen;
                    }
                }
                else
                {
                    MessageBox.Show("You can select up to 8 seats.", "Seat Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (selectedSeats.Count == 0)
            {
                getDetailsBtn.Enabled = false;
                getDetailsBtn.FlatAppearance.BorderColor = Color.DimGray;
                getDetailsBtn.ForeColor = Color.Gray;
            }

            UpdateSelectedSeatsText();
        }

        private void UpdateSelectedSeatsText()
        {
            string selectedSeatsText = string.Join(", ", selectedSeats);
            lblSelectedSeats.Text = $"Selected seats: {selectedSeatsText}";
            lblSelectedSeats.Location = new Point(this.ClientSize.Width / 2 - lblSelectedSeats.Width / 2, lblSelectedSeats.Location.Y);
        }

        private void getDetailsBtn_Click(object sender, EventArgs e)
        {
            tab3 = true;
            tabControl1.SelectedTab = tabPage3;
            fromLabel3.Text = departureAirport.City + " (" + departureAirport.ICAOCode + ")";
            toAndDateLbl2.Text = toAndDateLbl1.Text;

            int startX1 = 24;
            int startY1 = 97;
            int startX2 = 124;
            int startY2 = 97;
            int y1 = startY1;
            int y2 = startY2;

            const int maxVerticalPosition = 300;
            const int newX = 410;
            int labelCount = 0;

            passengerTextBoxes.Clear();

            for (int i = 0; i < selectedSeats.Count; i++)
            {
                Label seatLbl = new Label()
                {
                    ForeColor = Color.White,
                    Text = $"{selectedSeats[i]}:",
                    Font = new Font(fontCollection.Families[0], 11),
                };

                TextBox inputTF = new TextBox()
                {
                    BackColor = Color.FromArgb(39, 39, 42),
                    ForeColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                    MaxLength = 50,
                    Size = new Size(250, 25),
                    MaximumSize = new Size(250, 25),
                    MinimumSize = new Size(250, 25)
                };

                if (y2 + (labelCount + 1) * 45 > maxVerticalPosition)
                {
                    startX1 = newX;
                    startX2 = newX + 100;

                    y1 = startY1;
                    y2 = startY2;
                    labelCount = 0;
                }

                seatLbl.Location = new Point(startX1, y1 + labelCount * 45);
                inputTF.Location = new Point(startX2, y2 + labelCount * 45);

                tabPage3.Controls.Add(seatLbl);
                tabPage3.Controls.Add(inputTF);
                passengerTextBoxes.Add(inputTF);

                labelCount++;
            }
        }

        private bool AreAllNamesValid()
        {
            if (tabControl1.SelectedTab != tabPage3) return true;

            foreach (TextBox textBox in passengerTextBoxes)
            {
                string[] parts = textBox.Text.Trim().Split(' ');
                if (parts.Length != 2 || string.IsNullOrWhiteSpace(parts[0]) || string.IsNullOrWhiteSpace(parts[1]))
                {
                    return false;
                }
            }
            return true;
        }

        private void showSummaryBtn_Click(object sender, EventArgs e)
        {
            if (!AreAllNamesValid())
            {
                MessageBox.Show("Please enter passenger names in the format 'John Smith'.", "Invalid Names", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tab4 = true;
            tabControl1.SelectedTab = tabPage4;

            using (var context = new AppDbContext())
            {
                var flight = context.Flights
                    .Include(f => f.Departure)
                    .Include(f => f.Destination)
                    .FirstOrDefault(s => s.Id == selectedFlight);

                var departureAirport = context.Airports
                    .FirstOrDefault(a => a.Id == flight.DepartureId);

                var destinationAirport = context.Airports
                    .FirstOrDefault(a => a.Id == flight.DestinationId);

                if (flight != null)
                {
                    summaryDepartureLbl.Text = departureAirport.Name;
                    summaryArrivalLbl.Text = destinationAirport.Name;
                    summaryDateLbl.Text = flight.Date.ToString();
                    summaryFnLbl.Text = flight.FlightNumber;
                    PNRLbl.Text = GeneratePNRCode();
                    GeneratedPNRCode = PNRLbl.Text;

                    if (DateTime.TryParse(flight.DepartureTime, out DateTime departureTime))
                    {
                        summaryDepartTLbl.Text = departureTime.ToString("HH:mm");
                        summaryBoardingTLbl.Text = departureTime.AddHours(-2).ToString("HH:mm");
                    }
                    else
                    {
                        summaryDepartTLbl.Text = "Invalid time";
                        summaryBoardingTLbl.Text = "Invalid time";
                    }

                    List<string> passengerNames = new List<string>();
                    foreach (var textBox in passengerTextBoxes)
                    {
                        passengerNames.Add(textBox.Text);
                    }
                    namesLbl.Text = string.Join(", ", passengerNames);

                    List<string> seatInfo = new List<string>();
                    for (int i = 0; i < selectedSeats.Count; i++)
                    {
                        string seat = selectedSeats[i];
                        string passenger = passengerTextBoxes[i].Text;
                        string[] nameParts = passenger.Split(' ');
                        string initials = $"{nameParts[0][0]}{nameParts[1][0]}";
                        seatInfo.Add($"{seat} ({initials})");
                    }
                    summarySeatsLbl.Text = string.Join(", ", seatInfo);
                }
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var flight = context.Flights.FirstOrDefault(s => s.Id == selectedFlight);

                foreach (var seat in selectedSeats)
                {
                    flight.TakenSeats += (flight.TakenSeats == "") ? seat : $", {seat}";
                }


                for (int i = 0; i < selectedSeats.Count; i++)
                {
                    string passengerName = passengerTextBoxes[i].Text.Split(' ')[0];
                    string passengerSurname = passengerTextBoxes[i].Text.Split(' ')[1];

                    var reservation = new Reservation
                    {
                        Id = newId++,
                        PassengerName = passengerName,
                        PassengerSurname = passengerSurname,
                        SelectedFlightId = selectedFlight,
                        SelectedFlight = flight,
                        SelectedSeat = selectedSeats[i],
                        PNRCode = GeneratedPNRCode
                    };

                    context.Reservations.Add(reservation);
                }

                context.SaveChanges();
            }

            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Owner = mainForm;
            this.Hide();
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            string copyText = $"PNR: {PNRLbl.Text}, Flight Number: {summaryFnLbl.Text}, Date: {summaryDateLbl.Text}, Boarding Time: {summaryBoardingTLbl.Text}, Boarding Time: {summaryDepartTLbl.Text}, Seat(s): {summarySeatsLbl.Text}.";
            Clipboard.SetText(copyText);
        }

        private string GeneratePNRCode()
        {
            return Guid.NewGuid().ToString().Substring(0, 6).ToUpper();
        }

        private void ClearSeatTab()
        {
            foreach (Control control in tabPage2.Controls)
            {
                if (!(control.Name == "getDetailsBtn" || control.Name == "selectSeatsHeader" || control.Name == "fromLabel2" || control.Name == "arrowLbl2" || control.Name == "toAndDateLbl1" || control.Name == "lblSelectedSeats"))
                {
                    tabPage2.Controls.Remove(control);
                }
            }

            selectedSeats.Clear();
            UpdateSelectedSeatsText();
        }

        private void ClearSummaryTab()
        {
            summaryDepartureLbl.Text = "Departure";
            summaryArrivalLbl.Text = "Arrival";
            namesLbl.Text = "Name Surname";
            PNRLbl.Text = "PNR: 762453276";
            summaryFnLbl.Text = "AB1234";
            summaryBoardingTLbl.Text = "00:00";
            summaryDepartTLbl.Text = "00:00";
            summarySeatsLbl.Text = "A1";
            GeneratedPNRCode = "";
        }

        private void ClearPassengersTab()
        {
            foreach (Control control in tabPage3.Controls.OfType<TextBox>().ToList())
            {
                tabPage3.Controls.Remove(control);
                control.Dispose();
            }

            foreach (Control control in tabPage3.Controls.OfType<Label>().Where(lbl => lbl.Text.EndsWith(":")).ToList())
            {
                tabPage3.Controls.Remove(control);
                control.Dispose();
            }

            passengerTextBoxes.Clear();
        }

        private void LoadFonts()
        {
            fontCollection.AddFontFile("..\\..\\Fonts\\GeistMono-Light.ttf");
            fontCollection.AddFontFile("..\\..\\Fonts\\Geist-Regular.ttf");
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tabPage2)
            {
                if (tab2 == false) { e.Cancel = true; }
            }
            else if (e.TabPage == tabPage3)
            {
                if (tab3 == false) { e.Cancel = true; }
            }
            else if (e.TabPage == tabPage4)
            {
                if (tab4 == false) { e.Cancel = true; }
            }
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Rectangle rectangle = tabControl1.ClientRectangle;

            StringFormat StrFormat = new StringFormat();
            StrFormat.LineAlignment = StringAlignment.Center;
            StrFormat.Alignment = StringAlignment.Center;

            SolidBrush backColor = new SolidBrush(Color.FromArgb(32, 32, 34));
            SolidBrush fontColor;

            e.Graphics.FillRectangle(backColor, rectangle);
            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(39, 39, 42), 10), tabPage1.Bounds);

            Font fntTab = e.Font;
            Brush bshBack = new SolidBrush(Color.FromArgb(39, 39, 42));

            for (int i = 0; i < tabControl1.TabPages.Count; i++)
            {
                bool bSelected = (tabControl1.SelectedIndex == i);
                Rectangle recBounds = tabControl1.GetTabRect(i);
                RectangleF tabTextArea = (RectangleF)tabControl1.GetTabRect(i);
                if (bSelected)
                {
                    e.Graphics.FillRectangle(bshBack, recBounds);
                    fontColor = new SolidBrush(Color.White);
                    e.Graphics.DrawString(tabControl1.TabPages[i].Text, fntTab, fontColor, tabTextArea, StrFormat);
                }
                else
                {
                    fontColor = new SolidBrush(Color.Silver);
                    e.Graphics.DrawString(tabControl1.TabPages[i].Text, fntTab, fontColor, tabTextArea, StrFormat);
                }
            }
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

        public void ReservationForm_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            lastLocation = e.Location;
        }

        public void ReservationForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        public void ReservationForm_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }
    }
}
