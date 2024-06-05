namespace FlightBooker
{
    partial class ReservationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.getSeatsBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Airline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Features = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Availability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.toLabel1 = new System.Windows.Forms.Label();
            this.fromLabel1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.arrowLbl2 = new System.Windows.Forms.Label();
            this.toAndDateLbl1 = new System.Windows.Forms.Label();
            this.fromLabel2 = new System.Windows.Forms.Label();
            this.getDetailsBtn = new System.Windows.Forms.Button();
            this.lblSelectedSeats = new System.Windows.Forms.Label();
            this.selectSeatsHeader = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.showSummaryBtn = new System.Windows.Forms.Button();
            this.arrowLbl3 = new System.Windows.Forms.Label();
            this.toAndDateLbl2 = new System.Windows.Forms.Label();
            this.fromLabel3 = new System.Windows.Forms.Label();
            this.enterDetailsHeader = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.summaryBoardingTLbl = new System.Windows.Forms.Label();
            this.boardingHeader = new System.Windows.Forms.Label();
            this.summaryDepartTLbl = new System.Windows.Forms.Label();
            this.departureHeader = new System.Windows.Forms.Label();
            this.summaryDepartureLbl = new System.Windows.Forms.Label();
            this.summaryFnLbl = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.summaryArrivalLbl = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.namesLbl = new System.Windows.Forms.Label();
            this.flightNumHeader = new System.Windows.Forms.Label();
            this.seatsHeader = new System.Windows.Forms.Label();
            this.summarySeatsLbl = new System.Windows.Forms.Label();
            this.PNRLbl = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label23 = new System.Windows.Forms.Label();
            this.copyButton = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.summaryDateLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.minimizeButton);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 30);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ReservationForm_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ReservationForm_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ReservationForm_MouseUp);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.minimizeButton.ForeColor = System.Drawing.Color.DarkGray;
            this.minimizeButton.Location = new System.Drawing.Point(774, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(35, 30);
            this.minimizeButton.TabIndex = 7;
            this.minimizeButton.Text = "―";
            this.minimizeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            this.minimizeButton.MouseEnter += new System.EventHandler(this.minimizeButton_MouseEnter);
            this.minimizeButton.MouseLeave += new System.EventHandler(this.minimizeButton_MouseLeave);
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.Firebrick;
            this.closeButton.Location = new System.Drawing.Point(809, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(36, 30);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "✖";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 30);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(85, 10);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(845, 465);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.tabPage1.Controls.Add(this.getSeatsBtn);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.toLabel1);
            this.tabPage1.Controls.Add(this.fromLabel1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(837, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Flights";
            // 
            // getSeatsBtn
            // 
            this.getSeatsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getSeatsBtn.Font = new System.Drawing.Font("Geist", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getSeatsBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.getSeatsBtn.Location = new System.Drawing.Point(28, 349);
            this.getSeatsBtn.Name = "getSeatsBtn";
            this.getSeatsBtn.Size = new System.Drawing.Size(780, 42);
            this.getSeatsBtn.TabIndex = 8;
            this.getSeatsBtn.Text = "Continue";
            this.getSeatsBtn.UseVisualStyleBackColor = true;
            this.getSeatsBtn.Click += new System.EventHandler(this.getSeatsBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Date,
            this.Airline,
            this.Departure,
            this.Features,
            this.Availability});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(28, 79);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(780, 264);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "#";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Airline
            // 
            this.Airline.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Airline.HeaderText = "Airline";
            this.Airline.Name = "Airline";
            // 
            // Departure
            // 
            this.Departure.HeaderText = "Departure";
            this.Departure.Name = "Departure";
            // 
            // Features
            // 
            this.Features.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Features.HeaderText = "Arrival";
            this.Features.Name = "Features";
            // 
            // Availability
            // 
            this.Availability.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Availability.HeaderText = "Availability";
            this.Availability.Name = "Availability";
            // 
            // label5
            // 
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(124, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "➜";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.UseCompatibleTextRendering = true;
            // 
            // toLabel1
            // 
            this.toLabel1.AutoSize = true;
            this.toLabel1.Font = new System.Drawing.Font("Geist", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.toLabel1.Location = new System.Drawing.Point(153, 53);
            this.toLabel1.Name = "toLabel1";
            this.toLabel1.Size = new System.Drawing.Size(73, 16);
            this.toLabel1.TabIndex = 2;
            this.toLabel1.Text = "City (ICAO)";
            // 
            // fromLabel1
            // 
            this.fromLabel1.Font = new System.Drawing.Font("Geist", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.fromLabel1.Location = new System.Drawing.Point(25, 53);
            this.fromLabel1.Name = "fromLabel1";
            this.fromLabel1.Size = new System.Drawing.Size(100, 16);
            this.fromLabel1.TabIndex = 1;
            this.fromLabel1.Text = "City (ICAO)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Geist", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(23, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Flight selection";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.tabPage2.Controls.Add(this.arrowLbl2);
            this.tabPage2.Controls.Add(this.toAndDateLbl1);
            this.tabPage2.Controls.Add(this.fromLabel2);
            this.tabPage2.Controls.Add(this.getDetailsBtn);
            this.tabPage2.Controls.Add(this.lblSelectedSeats);
            this.tabPage2.Controls.Add(this.selectSeatsHeader);
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(837, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Seats";
            // 
            // arrowLbl2
            // 
            this.arrowLbl2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.arrowLbl2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrowLbl2.ForeColor = System.Drawing.Color.White;
            this.arrowLbl2.Location = new System.Drawing.Point(124, 53);
            this.arrowLbl2.Name = "arrowLbl2";
            this.arrowLbl2.Size = new System.Drawing.Size(23, 16);
            this.arrowLbl2.TabIndex = 14;
            this.arrowLbl2.Text = "➜";
            this.arrowLbl2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.arrowLbl2.UseCompatibleTextRendering = true;
            // 
            // toAndDateLbl1
            // 
            this.toAndDateLbl1.AutoSize = true;
            this.toAndDateLbl1.Font = new System.Drawing.Font("Geist", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toAndDateLbl1.ForeColor = System.Drawing.SystemColors.Control;
            this.toAndDateLbl1.Location = new System.Drawing.Point(153, 53);
            this.toAndDateLbl1.Name = "toAndDateLbl1";
            this.toAndDateLbl1.Size = new System.Drawing.Size(106, 16);
            this.toAndDateLbl1.TabIndex = 13;
            this.toAndDateLbl1.Text = "City (ICAO), Date";
            // 
            // fromLabel2
            // 
            this.fromLabel2.Font = new System.Drawing.Font("Geist", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.fromLabel2.Location = new System.Drawing.Point(25, 53);
            this.fromLabel2.Name = "fromLabel2";
            this.fromLabel2.Size = new System.Drawing.Size(100, 16);
            this.fromLabel2.TabIndex = 12;
            this.fromLabel2.Text = "City (ICAO)";
            // 
            // getDetailsBtn
            // 
            this.getDetailsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getDetailsBtn.Font = new System.Drawing.Font("Geist", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getDetailsBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.getDetailsBtn.Location = new System.Drawing.Point(28, 349);
            this.getDetailsBtn.Name = "getDetailsBtn";
            this.getDetailsBtn.Size = new System.Drawing.Size(780, 42);
            this.getDetailsBtn.TabIndex = 11;
            this.getDetailsBtn.Text = "Continue";
            this.getDetailsBtn.UseVisualStyleBackColor = true;
            this.getDetailsBtn.Click += new System.EventHandler(this.getDetailsBtn_Click);
            // 
            // lblSelectedSeats
            // 
            this.lblSelectedSeats.AutoSize = true;
            this.lblSelectedSeats.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSelectedSeats.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblSelectedSeats.Location = new System.Drawing.Point(325, 326);
            this.lblSelectedSeats.Name = "lblSelectedSeats";
            this.lblSelectedSeats.Size = new System.Drawing.Size(187, 20);
            this.lblSelectedSeats.TabIndex = 10;
            this.lblSelectedSeats.Text = "You didn\'t choose any seat.";
            // 
            // selectSeatsHeader
            // 
            this.selectSeatsHeader.AutoSize = true;
            this.selectSeatsHeader.Font = new System.Drawing.Font("Geist", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectSeatsHeader.ForeColor = System.Drawing.SystemColors.Control;
            this.selectSeatsHeader.Location = new System.Drawing.Point(23, 27);
            this.selectSeatsHeader.Name = "selectSeatsHeader";
            this.selectSeatsHeader.Size = new System.Drawing.Size(133, 26);
            this.selectSeatsHeader.TabIndex = 1;
            this.selectSeatsHeader.Text = "Select seats";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.tabPage3.Controls.Add(this.showSummaryBtn);
            this.tabPage3.Controls.Add(this.arrowLbl3);
            this.tabPage3.Controls.Add(this.toAndDateLbl2);
            this.tabPage3.Controls.Add(this.fromLabel3);
            this.tabPage3.Controls.Add(this.enterDetailsHeader);
            this.tabPage3.Location = new System.Drawing.Point(4, 36);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(837, 425);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Passengers";
            // 
            // showSummaryBtn
            // 
            this.showSummaryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showSummaryBtn.Font = new System.Drawing.Font("Geist", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showSummaryBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.showSummaryBtn.Location = new System.Drawing.Point(28, 349);
            this.showSummaryBtn.Name = "showSummaryBtn";
            this.showSummaryBtn.Size = new System.Drawing.Size(777, 42);
            this.showSummaryBtn.TabIndex = 18;
            this.showSummaryBtn.Text = "Continue";
            this.showSummaryBtn.UseVisualStyleBackColor = true;
            this.showSummaryBtn.Click += new System.EventHandler(this.showSummaryBtn_Click);
            // 
            // arrowLbl3
            // 
            this.arrowLbl3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.arrowLbl3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrowLbl3.ForeColor = System.Drawing.Color.White;
            this.arrowLbl3.Location = new System.Drawing.Point(124, 53);
            this.arrowLbl3.Name = "arrowLbl3";
            this.arrowLbl3.Size = new System.Drawing.Size(23, 16);
            this.arrowLbl3.TabIndex = 17;
            this.arrowLbl3.Text = "➜";
            this.arrowLbl3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.arrowLbl3.UseCompatibleTextRendering = true;
            // 
            // toAndDateLbl2
            // 
            this.toAndDateLbl2.AutoSize = true;
            this.toAndDateLbl2.Font = new System.Drawing.Font("Geist", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toAndDateLbl2.ForeColor = System.Drawing.SystemColors.Control;
            this.toAndDateLbl2.Location = new System.Drawing.Point(153, 53);
            this.toAndDateLbl2.Name = "toAndDateLbl2";
            this.toAndDateLbl2.Size = new System.Drawing.Size(106, 16);
            this.toAndDateLbl2.TabIndex = 16;
            this.toAndDateLbl2.Text = "City (ICAO), Date";
            // 
            // fromLabel3
            // 
            this.fromLabel3.Font = new System.Drawing.Font("Geist", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLabel3.ForeColor = System.Drawing.SystemColors.Control;
            this.fromLabel3.Location = new System.Drawing.Point(25, 53);
            this.fromLabel3.Name = "fromLabel3";
            this.fromLabel3.Size = new System.Drawing.Size(100, 16);
            this.fromLabel3.TabIndex = 15;
            this.fromLabel3.Text = "City (ICAO)";
            // 
            // enterDetailsHeader
            // 
            this.enterDetailsHeader.AutoSize = true;
            this.enterDetailsHeader.Font = new System.Drawing.Font("Geist", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterDetailsHeader.ForeColor = System.Drawing.SystemColors.Control;
            this.enterDetailsHeader.Location = new System.Drawing.Point(23, 27);
            this.enterDetailsHeader.Name = "enterDetailsHeader";
            this.enterDetailsHeader.Size = new System.Drawing.Size(243, 26);
            this.enterDetailsHeader.TabIndex = 2;
            this.enterDetailsHeader.Text = "Enter details (full name)";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.tabPage4.Controls.Add(this.label24);
            this.tabPage4.Controls.Add(this.copyButton);
            this.tabPage4.Controls.Add(this.confirmBtn);
            this.tabPage4.Controls.Add(this.label23);
            this.tabPage4.Controls.Add(this.panel2);
            this.tabPage4.Controls.Add(this.panel3);
            this.tabPage4.Location = new System.Drawing.Point(4, 36);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(837, 425);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Summary";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Location = new System.Drawing.Point(143, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 14);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AliceBlue;
            this.panel3.Controls.Add(this.summaryDateLbl);
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.PNRLbl);
            this.panel3.Controls.Add(this.summarySeatsLbl);
            this.panel3.Controls.Add(this.seatsHeader);
            this.panel3.Controls.Add(this.flightNumHeader);
            this.panel3.Controls.Add(this.namesLbl);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.summaryArrivalLbl);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.summaryBoardingTLbl);
            this.panel3.Controls.Add(this.boardingHeader);
            this.panel3.Controls.Add(this.summaryDepartTLbl);
            this.panel3.Controls.Add(this.departureHeader);
            this.panel3.Controls.Add(this.summaryDepartureLbl);
            this.panel3.Controls.Add(this.summaryFnLbl);
            this.panel3.Location = new System.Drawing.Point(143, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(550, 194);
            this.panel3.TabIndex = 1;
            // 
            // summaryBoardingTLbl
            // 
            this.summaryBoardingTLbl.AutoSize = true;
            this.summaryBoardingTLbl.Font = new System.Drawing.Font("Geist", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryBoardingTLbl.Location = new System.Drawing.Point(251, 96);
            this.summaryBoardingTLbl.Name = "summaryBoardingTLbl";
            this.summaryBoardingTLbl.Size = new System.Drawing.Size(68, 24);
            this.summaryBoardingTLbl.TabIndex = 5;
            this.summaryBoardingTLbl.Text = "00:00";
            // 
            // boardingHeader
            // 
            this.boardingHeader.AutoSize = true;
            this.boardingHeader.Font = new System.Drawing.Font("Geist", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boardingHeader.Location = new System.Drawing.Point(252, 82);
            this.boardingHeader.Name = "boardingHeader";
            this.boardingHeader.Size = new System.Drawing.Size(63, 14);
            this.boardingHeader.TabIndex = 4;
            this.boardingHeader.Text = "BOARDING";
            // 
            // summaryDepartTLbl
            // 
            this.summaryDepartTLbl.AutoSize = true;
            this.summaryDepartTLbl.Font = new System.Drawing.Font("Geist", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryDepartTLbl.Location = new System.Drawing.Point(332, 96);
            this.summaryDepartTLbl.Name = "summaryDepartTLbl";
            this.summaryDepartTLbl.Size = new System.Drawing.Size(68, 24);
            this.summaryDepartTLbl.TabIndex = 3;
            this.summaryDepartTLbl.Text = "00:00";
            // 
            // departureHeader
            // 
            this.departureHeader.AutoSize = true;
            this.departureHeader.Font = new System.Drawing.Font("Geist", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departureHeader.Location = new System.Drawing.Point(333, 82);
            this.departureHeader.Name = "departureHeader";
            this.departureHeader.Size = new System.Drawing.Size(70, 14);
            this.departureHeader.TabIndex = 2;
            this.departureHeader.Text = "DEPARTURE";
            // 
            // summaryDepartureLbl
            // 
            this.summaryDepartureLbl.AutoSize = true;
            this.summaryDepartureLbl.Font = new System.Drawing.Font("Geist", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryDepartureLbl.Location = new System.Drawing.Point(39, 51);
            this.summaryDepartureLbl.Name = "summaryDepartureLbl";
            this.summaryDepartureLbl.Size = new System.Drawing.Size(67, 16);
            this.summaryDepartureLbl.TabIndex = 1;
            this.summaryDepartureLbl.Text = "Departure";
            // 
            // summaryFnLbl
            // 
            this.summaryFnLbl.AutoSize = true;
            this.summaryFnLbl.Font = new System.Drawing.Font("Geist", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryFnLbl.Location = new System.Drawing.Point(251, 48);
            this.summaryFnLbl.Name = "summaryFnLbl";
            this.summaryFnLbl.Size = new System.Drawing.Size(83, 24);
            this.summaryFnLbl.TabIndex = 0;
            this.summaryFnLbl.Text = "AB1234";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Geist", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(13, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(132, 19);
            this.label16.TabIndex = 6;
            this.label16.Text = "BOARDING PASS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(17, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // summaryArrivalLbl
            // 
            this.summaryArrivalLbl.AutoSize = true;
            this.summaryArrivalLbl.Font = new System.Drawing.Font("Geist", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryArrivalLbl.Location = new System.Drawing.Point(39, 73);
            this.summaryArrivalLbl.Name = "summaryArrivalLbl";
            this.summaryArrivalLbl.Size = new System.Drawing.Size(47, 16);
            this.summaryArrivalLbl.TabIndex = 9;
            this.summaryArrivalLbl.Text = "Arrival";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(17, 117);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 16);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // namesLbl
            // 
            this.namesLbl.AutoEllipsis = true;
            this.namesLbl.Font = new System.Drawing.Font("Geist", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namesLbl.Location = new System.Drawing.Point(39, 117);
            this.namesLbl.Name = "namesLbl";
            this.namesLbl.Size = new System.Drawing.Size(206, 16);
            this.namesLbl.TabIndex = 11;
            this.namesLbl.Text = "Name Surname";
            // 
            // flightNumHeader
            // 
            this.flightNumHeader.AutoSize = true;
            this.flightNumHeader.Font = new System.Drawing.Font("Geist", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightNumHeader.Location = new System.Drawing.Point(252, 34);
            this.flightNumHeader.Name = "flightNumHeader";
            this.flightNumHeader.Size = new System.Drawing.Size(94, 14);
            this.flightNumHeader.TabIndex = 12;
            this.flightNumHeader.Text = "FLIGHT NUMBER";
            // 
            // seatsHeader
            // 
            this.seatsHeader.AutoSize = true;
            this.seatsHeader.Font = new System.Drawing.Font("Geist", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seatsHeader.Location = new System.Drawing.Point(252, 131);
            this.seatsHeader.Name = "seatsHeader";
            this.seatsHeader.Size = new System.Drawing.Size(33, 14);
            this.seatsHeader.TabIndex = 13;
            this.seatsHeader.Text = "SEAT";
            // 
            // summarySeatsLbl
            // 
            this.summarySeatsLbl.AutoEllipsis = true;
            this.summarySeatsLbl.Font = new System.Drawing.Font("Geist", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summarySeatsLbl.Location = new System.Drawing.Point(251, 145);
            this.summarySeatsLbl.Name = "summarySeatsLbl";
            this.summarySeatsLbl.Size = new System.Drawing.Size(149, 35);
            this.summarySeatsLbl.TabIndex = 14;
            this.summarySeatsLbl.Text = "A1";
            // 
            // PNRLbl
            // 
            this.PNRLbl.AutoSize = true;
            this.PNRLbl.Font = new System.Drawing.Font("Geist", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNRLbl.Location = new System.Drawing.Point(14, 166);
            this.PNRLbl.Name = "PNRLbl";
            this.PNRLbl.Size = new System.Drawing.Size(70, 14);
            this.PNRLbl.TabIndex = 15;
            this.PNRLbl.Text = "762453276";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(410, 37);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(128, 128);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Geist", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.Control;
            this.label23.Location = new System.Drawing.Point(318, 27);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(201, 26);
            this.label23.TabIndex = 2;
            this.label23.Text = "Reservation Details";
            // 
            // copyButton
            // 
            this.copyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyButton.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.copyButton.Image = ((System.Drawing.Image)(resources.GetObject("copyButton.Image")));
            this.copyButton.Location = new System.Drawing.Point(763, 349);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(42, 42);
            this.copyButton.TabIndex = 17;
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmBtn.Font = new System.Drawing.Font("Geist", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.confirmBtn.Location = new System.Drawing.Point(28, 349);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(729, 42);
            this.confirmBtn.TabIndex = 16;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Geist", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.Control;
            this.label24.Location = new System.Drawing.Point(223, 53);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(391, 16);
            this.label24.TabIndex = 18;
            this.label24.Text = "Here is an example boarding app. Please keep this informations.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Geist Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "FlightBooker";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Geist", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 14);
            this.label4.TabIndex = 17;
            this.label4.Text = "PNR";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(17, 95);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(16, 16);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // summaryDateLbl
            // 
            this.summaryDateLbl.AutoSize = true;
            this.summaryDateLbl.Font = new System.Drawing.Font("Geist", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryDateLbl.Location = new System.Drawing.Point(39, 96);
            this.summaryDateLbl.Name = "summaryDateLbl";
            this.summaryDateLbl.Size = new System.Drawing.Size(34, 16);
            this.summaryDateLbl.TabIndex = 19;
            this.summaryDateLbl.Text = "Date";
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(845, 495);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationForm";
            this.Text = "ReservationForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ReservationForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ReservationForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ReservationForm_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label minimizeButton;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label toLabel1;
        private System.Windows.Forms.Label fromLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button getSeatsBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Airline;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Features;
        private System.Windows.Forms.DataGridViewTextBoxColumn Availability;
        private System.Windows.Forms.Label selectSeatsHeader;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label enterDetailsHeader;
        private System.Windows.Forms.Button getDetailsBtn;
        private System.Windows.Forms.Label lblSelectedSeats;
        private System.Windows.Forms.Label arrowLbl2;
        private System.Windows.Forms.Label toAndDateLbl1;
        private System.Windows.Forms.Label fromLabel2;
        private System.Windows.Forms.Button showSummaryBtn;
        private System.Windows.Forms.Label arrowLbl3;
        private System.Windows.Forms.Label toAndDateLbl2;
        private System.Windows.Forms.Label fromLabel3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label summaryBoardingTLbl;
        private System.Windows.Forms.Label boardingHeader;
        private System.Windows.Forms.Label summaryDepartTLbl;
        private System.Windows.Forms.Label departureHeader;
        private System.Windows.Forms.Label summaryDepartureLbl;
        private System.Windows.Forms.Label summaryFnLbl;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label PNRLbl;
        private System.Windows.Forms.Label summarySeatsLbl;
        private System.Windows.Forms.Label seatsHeader;
        private System.Windows.Forms.Label flightNumHeader;
        private System.Windows.Forms.Label namesLbl;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label summaryArrivalLbl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label summaryDateLbl;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}