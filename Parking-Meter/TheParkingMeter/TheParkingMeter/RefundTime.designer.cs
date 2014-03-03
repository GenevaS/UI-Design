namespace WindowsFormsApplication1
{
    partial class RefundTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RefundTime));
            this.CurrentTimeLabel = new System.Windows.Forms.Label();
            this.UpdateClock = new System.Windows.Forms.Timer(this.components);
            this.CurrentDate = new System.Windows.Forms.Label();
            this.CurrentTime = new System.Windows.Forms.Label();
            this.CurrentTimePanel = new System.Windows.Forms.Panel();
            this.BuyTimePanel = new System.Windows.Forms.Panel();
            this.MinuteLabel = new System.Windows.Forms.Label();
            this.RemainingTimeLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TicketExpireTime = new System.Windows.Forms.Label();
            this.TicketExpireDate = new System.Windows.Forms.Label();
            this.ExpireLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.CurrentTimePanel.SuspendLayout();
            this.BuyTimePanel.SuspendLayout();
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
            this.CurrentDate.AutoSize = true;
            this.CurrentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentDate.Location = new System.Drawing.Point(461, 40);
            this.CurrentDate.Name = "CurrentDate";
            this.CurrentDate.Size = new System.Drawing.Size(84, 37);
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
            this.BuyTimePanel.Controls.Add(this.MinuteLabel);
            this.BuyTimePanel.Controls.Add(this.RemainingTimeLabel);
            this.BuyTimePanel.Location = new System.Drawing.Point(27, 159);
            this.BuyTimePanel.Name = "BuyTimePanel";
            this.BuyTimePanel.Size = new System.Drawing.Size(728, 171);
            this.BuyTimePanel.TabIndex = 4;
            // 
            // MinuteLabel
            // 
            this.MinuteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinuteLabel.Location = new System.Drawing.Point(365, 54);
            this.MinuteLabel.Name = "MinuteLabel";
            this.MinuteLabel.Size = new System.Drawing.Size(221, 49);
            this.MinuteLabel.TabIndex = 3;
            this.MinuteLabel.Text = "Time";
            this.MinuteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RemainingTimeLabel
            // 
            this.RemainingTimeLabel.AutoSize = true;
            this.RemainingTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainingTimeLabel.Location = new System.Drawing.Point(15, 66);
            this.RemainingTimeLabel.Name = "RemainingTimeLabel";
            this.RemainingTimeLabel.Size = new System.Drawing.Size(228, 37);
            this.RemainingTimeLabel.TabIndex = 0;
            this.RemainingTimeLabel.Text = "Unused Time:";
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
            this.TicketExpireDate.AutoSize = true;
            this.TicketExpireDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketExpireDate.Location = new System.Drawing.Point(461, 41);
            this.TicketExpireDate.Name = "TicketExpireDate";
            this.TicketExpireDate.Size = new System.Drawing.Size(84, 37);
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
            // RefundTime
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
            this.Name = "RefundTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Refund Time";
            this.Load += new System.EventHandler(this.BuyTime_Load);
            this.CurrentTimePanel.ResumeLayout(false);
            this.CurrentTimePanel.PerformLayout();
            this.BuyTimePanel.ResumeLayout(false);
            this.BuyTimePanel.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TicketExpireTime;
        private System.Windows.Forms.Label TicketExpireDate;
        private System.Windows.Forms.Label ExpireLabel;
        private System.Windows.Forms.Label MinuteLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label RemainingTimeLabel;

    }
}