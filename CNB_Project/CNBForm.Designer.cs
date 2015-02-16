namespace CNB_Project
{
    partial class CNBForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public int year = 1990;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CNBForm));
            this.welcomePanel = new System.Windows.Forms.Panel();
            this.timeQuestiosPanel = new System.Windows.Forms.Panel();
            this.seasonBox = new System.Windows.Forms.ComboBox();
            this.dayBox = new System.Windows.Forms.ComboBox();
            this.monthBox = new System.Windows.Forms.ComboBox();
            this.yearBox = new System.Windows.Forms.ComboBox();
            this.seasonLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.timeQuestionsLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.locationPanel = new System.Windows.Forms.Panel();
            this.locationLabel = new System.Windows.Forms.Label();
            this.floorBox = new System.Windows.Forms.ComboBox();
            this.cityBox = new System.Windows.Forms.ComboBox();
            this.countryBox = new System.Windows.Forms.ComboBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.floorLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.brainImgBox = new System.Windows.Forms.PictureBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.wlcmMsgLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.nextBtn = new System.Windows.Forms.Button();
            this.welcomePanel.SuspendLayout();
            this.timeQuestiosPanel.SuspendLayout();
            this.locationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brainImgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomePanel
            // 
            this.welcomePanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.welcomePanel.Controls.Add(this.timeQuestiosPanel);
            this.welcomePanel.Controls.Add(this.locationPanel);
            this.welcomePanel.Controls.Add(this.brainImgBox);
            this.welcomePanel.Controls.Add(this.idTextBox);
            this.welcomePanel.Controls.Add(this.wlcmMsgLabel);
            this.welcomePanel.Controls.Add(this.welcomeLabel);
            this.welcomePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.welcomePanel.Location = new System.Drawing.Point(0, 0);
            this.welcomePanel.Name = "welcomePanel";
            this.welcomePanel.Size = new System.Drawing.Size(444, 266);
            this.welcomePanel.TabIndex = 0;
            // 
            // timeQuestiosPanel
            // 
            this.timeQuestiosPanel.Controls.Add(this.seasonBox);
            this.timeQuestiosPanel.Controls.Add(this.dayBox);
            this.timeQuestiosPanel.Controls.Add(this.monthBox);
            this.timeQuestiosPanel.Controls.Add(this.yearBox);
            this.timeQuestiosPanel.Controls.Add(this.seasonLabel);
            this.timeQuestiosPanel.Controls.Add(this.yearLabel);
            this.timeQuestiosPanel.Controls.Add(this.timeQuestionsLabel);
            this.timeQuestiosPanel.Controls.Add(this.dayLabel);
            this.timeQuestiosPanel.Controls.Add(this.monthLabel);
            this.timeQuestiosPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeQuestiosPanel.Location = new System.Drawing.Point(0, 0);
            this.timeQuestiosPanel.Name = "timeQuestiosPanel";
            this.timeQuestiosPanel.Size = new System.Drawing.Size(444, 266);
            this.timeQuestiosPanel.TabIndex = 5;
            this.timeQuestiosPanel.Visible = false;
            // 
            // seasonBox
            // 
            this.seasonBox.FormattingEnabled = true;
            this.seasonBox.Items.AddRange(new object[] {
            "Summer",
            "Spring",
            "Autumn",
            "Winter"});
            this.seasonBox.Location = new System.Drawing.Point(221, 178);
            this.seasonBox.Name = "seasonBox";
            this.seasonBox.Size = new System.Drawing.Size(80, 21);
            this.seasonBox.TabIndex = 19;
            // 
            // dayBox
            // 
            this.dayBox.DropDownHeight = 150;
            this.dayBox.FormattingEnabled = true;
            this.dayBox.IntegralHeight = false;
            this.dayBox.Location = new System.Drawing.Point(221, 136);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(42, 21);
            this.dayBox.TabIndex = 17;
            // 
            // monthBox
            // 
            this.monthBox.FormattingEnabled = true;
            this.monthBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthBox.Location = new System.Drawing.Point(221, 97);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(80, 21);
            this.monthBox.TabIndex = 16;
            // 
            // yearBox
            // 
            this.yearBox.DropDownHeight = 150;
            this.yearBox.FormattingEnabled = true;
            this.yearBox.IntegralHeight = false;
            this.yearBox.Location = new System.Drawing.Point(221, 55);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(57, 21);
            this.yearBox.TabIndex = 15;
            // 
            // seasonLabel
            // 
            this.seasonLabel.AutoSize = true;
            this.seasonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.seasonLabel.Location = new System.Drawing.Point(33, 176);
            this.seasonLabel.Name = "seasonLabel";
            this.seasonLabel.Size = new System.Drawing.Size(139, 20);
            this.seasonLabel.TabIndex = 13;
            this.seasonLabel.Text = "What season is it?";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.yearLabel.Location = new System.Drawing.Point(33, 53);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(117, 20);
            this.yearLabel.TabIndex = 12;
            this.yearLabel.Text = "What year is it?";
            // 
            // timeQuestionsLabel
            // 
            this.timeQuestionsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeQuestionsLabel.AutoSize = true;
            this.timeQuestionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.timeQuestionsLabel.Location = new System.Drawing.Point(62, 15);
            this.timeQuestionsLabel.Name = "timeQuestionsLabel";
            this.timeQuestionsLabel.Size = new System.Drawing.Size(308, 25);
            this.timeQuestionsLabel.TabIndex = 7;
            this.timeQuestionsLabel.Text = "Please answer the time questions:";
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dayLabel.Location = new System.Drawing.Point(33, 134);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(112, 20);
            this.dayLabel.TabIndex = 10;
            this.dayLabel.Text = "What day is it?";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.monthLabel.Location = new System.Drawing.Point(33, 95);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(132, 20);
            this.monthLabel.TabIndex = 9;
            this.monthLabel.Text = "What month is it?";
            // 
            // locationPanel
            // 
            this.locationPanel.Controls.Add(this.locationLabel);
            this.locationPanel.Controls.Add(this.floorBox);
            this.locationPanel.Controls.Add(this.cityBox);
            this.locationPanel.Controls.Add(this.countryBox);
            this.locationPanel.Controls.Add(this.countryLabel);
            this.locationPanel.Controls.Add(this.floorLabel);
            this.locationPanel.Controls.Add(this.cityLabel);
            this.locationPanel.Location = new System.Drawing.Point(0, 0);
            this.locationPanel.Name = "locationPanel";
            this.locationPanel.Size = new System.Drawing.Size(444, 266);
            this.locationPanel.TabIndex = 20;
            this.locationPanel.Visible = false;
            // 
            // locationLabel
            // 
            this.locationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.locationLabel.Location = new System.Drawing.Point(62, 9);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(339, 25);
            this.locationLabel.TabIndex = 20;
            this.locationLabel.Text = "Please answer the location questions:";
            // 
            // floorBox
            // 
            this.floorBox.DropDownHeight = 150;
            this.floorBox.FormattingEnabled = true;
            this.floorBox.IntegralHeight = false;
            this.floorBox.Location = new System.Drawing.Point(244, 136);
            this.floorBox.Name = "floorBox";
            this.floorBox.Size = new System.Drawing.Size(42, 21);
            this.floorBox.TabIndex = 17;
            // 
            // cityBox
            // 
            this.cityBox.FormattingEnabled = true;
            this.cityBox.Items.AddRange(new object[] {
            "Tel Aviv",
            "Rishon Lezion",
            "Ashdod",
            "Ashkelon",
            "Eilat",
            "Haifa",
            "Jerusalem"});
            this.cityBox.Location = new System.Drawing.Point(244, 97);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(80, 21);
            this.cityBox.TabIndex = 16;
            // 
            // countryBox
            // 
            this.countryBox.DropDownHeight = 150;
            this.countryBox.FormattingEnabled = true;
            this.countryBox.IntegralHeight = false;
            this.countryBox.Location = new System.Drawing.Point(244, 54);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(80, 21);
            this.countryBox.TabIndex = 15;
            this.countryBox.Items.AddRange(new object[] {
            "Israel",
            "United States",
            "Canada",
            "Argentina",
            "Brazil",
            "France",
            "England"});
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.countryLabel.Location = new System.Drawing.Point(33, 53);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(190, 20);
            this.countryLabel.TabIndex = 12;
            this.countryLabel.Text = "Which country you are in?";
            // 
            // floorLabel
            // 
            this.floorLabel.AutoSize = true;
            this.floorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.floorLabel.Location = new System.Drawing.Point(33, 134);
            this.floorLabel.Name = "floorLabel";
            this.floorLabel.Size = new System.Drawing.Size(147, 20);
            this.floorLabel.TabIndex = 10;
            this.floorLabel.Text = "What floor are you?";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cityLabel.Location = new System.Drawing.Point(33, 95);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(161, 20);
            this.cityLabel.TabIndex = 9;
            this.cityLabel.Text = "Which city you are in?";
            // 
            // brainImgBox
            // 
            this.brainImgBox.Image = ((System.Drawing.Image)(resources.GetObject("brainImgBox.Image")));
            this.brainImgBox.Location = new System.Drawing.Point(148, 54);
            this.brainImgBox.Name = "brainImgBox";
            this.brainImgBox.Size = new System.Drawing.Size(185, 146);
            this.brainImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.brainImgBox.TabIndex = 4;
            this.brainImgBox.TabStop = false;
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.idTextBox.Location = new System.Drawing.Point(178, 241);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 2;
            this.idTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // wlcmMsgLabel
            // 
            this.wlcmMsgLabel.AutoSize = true;
            this.wlcmMsgLabel.Location = new System.Drawing.Point(34, 202);
            this.wlcmMsgLabel.Name = "wlcmMsgLabel";
            this.wlcmMsgLabel.Size = new System.Drawing.Size(375, 13);
            this.wlcmMsgLabel.TabIndex = 1;
            this.wlcmMsgLabel.Text = "To start the Computerized Neurocognitive Battery please enter you ID number:";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Ravie", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(102, 5);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(240, 45);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome!";
            // 
            // nextBtn
            // 
            this.nextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nextBtn.Location = new System.Drawing.Point(189, 284);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(74, 26);
            this.nextBtn.TabIndex = 6;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // CNBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(444, 322);
            this.Controls.Add(this.welcomePanel);
            this.Controls.Add(this.nextBtn);
            this.Name = "CNBForm";
            this.Text = "Computerized Neurocognitive Battery (CNB)";
            this.welcomePanel.ResumeLayout(false);
            this.welcomePanel.PerformLayout();
            this.timeQuestiosPanel.ResumeLayout(false);
            this.timeQuestiosPanel.PerformLayout();
            this.locationPanel.ResumeLayout(false);
            this.locationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brainImgBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel welcomePanel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label wlcmMsgLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.PictureBox brainImgBox;
        private System.Windows.Forms.Panel timeQuestiosPanel;
        private System.Windows.Forms.Label timeQuestionsLabel;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label seasonLabel;
        private System.Windows.Forms.ComboBox dayBox;
        private System.Windows.Forms.ComboBox monthBox;
        private System.Windows.Forms.ComboBox yearBox;
        private System.Windows.Forms.ComboBox seasonBox;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Panel locationPanel;
        private System.Windows.Forms.ComboBox floorBox;
        private System.Windows.Forms.ComboBox cityBox;
        private System.Windows.Forms.ComboBox countryBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label floorLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label locationLabel;



    }
}

