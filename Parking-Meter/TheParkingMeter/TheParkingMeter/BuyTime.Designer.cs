namespace WindowsFormsApplication1
{
    partial class BuyTime
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyTime));
            this.CurrentTimeLabel = new System.Windows.Forms.Label();
            this.UpdateClock = new System.Windows.Forms.Timer(this.components);
            this.CurrentDate = new System.Windows.Forms.Label();
            this.CurrentTime = new System.Windows.Forms.Label();
            this.CurrentTimePanel = new System.Windows.Forms.Panel();
            this.BuyTimePanel = new System.Windows.Forms.Panel();
            this.MinutesSlider = new System.Windows.Forms.TrackBar();
            this.MinuteLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.LessButton = new System.Windows.Forms.Button();
            this.BuyTimeLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TicketExpireTime = new System.Windows.Forms.Label();
            this.TicketExpireDate = new System.Windows.Forms.Label();
            this.ExpireLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.CurrentTimePanel.SuspendLayout();
            this.BuyTimePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesSlider)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CurrentTimeLabel
            // 
            this.CurrentTimeLabel.AutoSize = true;
            this.CurrentTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTimeLabel.Location = new System.Drawing.Point(17, 40);
            this.CurrentTimeLabel.Name = "CurrentTimeLabel";
            this.CurrentTimeLabel.Size = new System.Drawing.Size(226, 37);
            this.CurrentTimeLabel.TabIndex = 0;
            this.CurrentTimeLabel.Text = "Current Time:";
            // 
            // UpdateClock
            // 
            this.UpdateClock.Enabled = true;
            this.UpdateClock.Interval = 1000;
            this.UpdateClock.Tick += new System.EventHandler(this.UpdateClock_Tick);
            // 
            // CurrentDate
            // 
            this.CurrentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentDate.Location = new System.Drawing.Point(461, 40);
            this.CurrentDate.Name = "CurrentDate";
            this.CurrentDate.Size = new System.Drawing.Size(262, 37);
            this.CurrentDate.TabIndex = 1;
            this.CurrentDate.Text = "Date";
            // 
            // CurrentTime
            // 
            this.CurrentTime.AutoSize = true;
            this.CurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTime.Location = new System.Drawing.Point(260, 40);
            this.CurrentTime.Name = "CurrentTime";
            this.CurrentTime.Size = new System.Drawing.Size(88, 37);
            this.CurrentTime.TabIndex = 2;
            this.CurrentTime.Text = "Time";
            // 
            // CurrentTimePanel
            // 
            this.CurrentTimePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentTimePanel.Controls.Add(this.CurrentTime);
            this.CurrentTimePanel.Controls.Add(this.CurrentDate);
            this.CurrentTimePanel.Controls.Add(this.CurrentTimeLabel);
            this.CurrentTimePanel.Location = new System.Drawing.Point(27, 39);
            this.CurrentTimePanel.Name = "CurrentTimePanel";
            this.CurrentTimePanel.Size = new System.Drawing.Size(728, 114);
            this.CurrentTimePanel.TabIndex = 3;
            // 
            // BuyTimePanel
            // 
            this.BuyTimePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BuyTimePanel.Controls.Add(this.MinutesSlider);
            this.BuyTimePanel.Controls.Add(this.MinuteLabel);
            this.BuyTimePanel.Controls.Add(this.AddButton);
            this.BuyTimePanel.Controls.Add(this.LessButton);
            this.BuyTimePanel.Controls.Add(this.BuyTimeLabel);
            this.BuyTimePanel.Location = new System.Drawing.Point(27, 159);
            this.BuyTimePanel.Name = "BuyTimePanel";
            this.BuyTimePanel.Size = new System.Drawing.Size(728, 171);
            this.BuyTimePanel.TabIndex = 4;
            // 
            // MinutesSlider
            // 
            this.MinutesSlider.BackColor = System.Drawing.SystemColors.GrayText;
            this.MinutesSlider.LargeChange = 1;
            this.MinutesSlider.Location = new System.Drawing.Point(298, 109);
            this.MinutesSlider.Maximum = 36;
            this.MinutesSlider.Minimum = 3;
            this.MinutesSlider.Name = "MinutesSlider";
            this.MinutesSlider.Size = new System.Drawing.Size(390, 45);
            this.MinutesSlider.TabIndex = 4;
            this.MinutesSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.MinutesSlider.Value = 6;
            this.MinutesSlider.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // MinuteLabel
            // 
            this.MinuteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinuteLabel.Location = new System.Drawing.Point(364, 38);
            this.MinuteLabel.Name = "MinuteLabel";
            this.MinuteLabel.Size = new System.Drawing.Size(258, 49);
            this.MinuteLabel.TabIndex = 3;
            this.MinuteLabel.Text = "Time";
            this.MinuteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddButton
            // 
            this.AddButton.AutoSize = true;
            this.AddButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddButton.BackgroundImage")));
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.Red;
            this.AddButton.Location = new System.Drawing.Point(628, 27);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(60, 60);
            this.AddButton.TabIndex = 2;
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // LessButton
            // 
            this.LessButton.AutoSize = true;
            this.LessButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LessButton.BackgroundImage")));
            this.LessButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LessButton.ForeColor = System.Drawing.Color.Red;
            this.LessButton.Location = new System.Drawing.Point(298, 27);
            this.LessButton.Name = "LessButton";
            this.LessButton.Size = new System.Drawing.Size(60, 60);
            this.LessButton.TabIndex = 1;
            this.LessButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LessButton.UseVisualStyleBackColor = true;
            this.LessButton.Click += new System.EventHandler(this.LessButton_Click);
            // 
            // BuyTimeLabel
            // 
            this.BuyTimeLabel.AutoSize = true;
            this.BuyTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyTimeLabel.Location = new System.Drawing.Point(39, 66);
            this.BuyTimeLabel.Name = "BuyTimeLabel";
            this.BuyTimeLabel.Size = new System.Drawing.Size(169, 37);
            this.BuyTimeLabel.TabIndex = 0;
            this.BuyTimeLabel.Text = "Buy Time:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TicketExpireTime);
            this.panel1.Controls.Add(this.TicketExpireDate);
            this.panel1.Controls.Add(this.ExpireLabel);
            this.panel1.Location = new System.Drawing.Point(27, 336);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 114);
            this.panel1.TabIndex = 4;
            // 
            // TicketExpireTime
            // 
            this.TicketExpireTime.AutoSize = true;
            this.TicketExpireTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketExpireTime.Location = new System.Drawing.Point(260, 41);
            this.TicketExpireTime.Name = "TicketExpireTime";
            this.TicketExpireTime.Size = new System.Drawing.Size(88, 37);
            this.TicketExpireTime.TabIndex = 2;
            this.TicketExpireTime.Text = "Time";
            // 
            // TicketExpireDate
            // 
            this.TicketExpireDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketExpireDate.Location = new System.Drawing.Point(461, 41);
            this.TicketExpireDate.Name = "TicketExpireDate";
            this.TicketExpireDate.Size = new System.Drawing.Size(262, 37);
            this.TicketExpireDate.TabIndex = 1;
            this.TicketExpireDate.Text = "Date";
            // 
            // ExpireLabel
            // 
            this.ExpireLabel.AutoSize = true;
            this.ExpireLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpireLabel.Location = new System.Drawing.Point(3, 41);
            this.ExpireLabel.Name = "ExpireLabel";
            this.ExpireLabel.Size = new System.Drawing.Size(240, 37);
            this.ExpireLabel.TabIndex = 0;
            this.ExpireLabel.Text = "Ticket Expires:";
            // 
            // BackButton
            // 
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BackButton.Location = new System.Drawing.Point(403, 474);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(170, 60);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back";
            this.BackButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelButton.Image")));
            this.CancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelButton.Location = new System.Drawing.Point(27, 474);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(170, 60);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Image = ((System.Drawing.Image)(resources.GetObject("NextButton.Image")));
            this.NextButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NextButton.Location = new System.Drawing.Point(585, 474);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(170, 60);
            this.NextButton.TabIndex = 7;
            this.NextButton.Text = "Next";
            this.NextButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BuyTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BuyTimePanel);
            this.Controls.Add(this.CurrentTimePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuyTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuyTime";
            this.Load += new System.EventHandler(this.BuyTime_Load);
            this.CurrentTimePanel.ResumeLayout(false);
            this.CurrentTimePanel.PerformLayout();
            this.BuyTimePanel.ResumeLayout(false);
            this.BuyTimePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesSlider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CurrentTimeLabel;
        private System.Windows.Forms.Timer UpdateClock;
        private System.Windows.Forms.Label CurrentDate;
        private System.Windows.Forms.Label CurrentTime;
        private System.Windows.Forms.Panel CurrentTimePanel;
        private System.Windows.Forms.Panel BuyTimePanel;
        private System.Windows.Forms.Button LessButton;
        private System.Windows.Forms.Label BuyTimeLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TicketExpireTime;
        private System.Windows.Forms.Label TicketExpireDate;
        private System.Windows.Forms.Label ExpireLabel;
        private System.Windows.Forms.Label MinuteLabel;
        private System.Windows.Forms.TrackBar MinutesSlider;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;

    }
}