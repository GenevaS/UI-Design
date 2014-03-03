namespace WindowsFormsApplication1
{
    partial class Coins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Coins));
            this.BackButton = new System.Windows.Forms.Button();
            this.PayLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CoinLabel = new System.Windows.Forms.Label();
            this.NickelButton = new System.Windows.Forms.Button();
            this.DollarButton = new System.Windows.Forms.Button();
            this.QuarterButton = new System.Windows.Forms.Button();
            this.DimeButton = new System.Windows.Forms.Button();
            this.ToonieButton = new System.Windows.Forms.Button();
            this.CoinListPanel = new System.Windows.Forms.Panel();
            this.CoinListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BackButton.Location = new System.Drawing.Point(592, 474);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(170, 60);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "Back";
            this.BackButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // PayLabel
            // 
            this.PayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayLabel.Location = new System.Drawing.Point(170, 141);
            this.PayLabel.Name = "PayLabel";
            this.PayLabel.Size = new System.Drawing.Size(442, 75);
            this.PayLabel.TabIndex = 14;
            this.PayLabel.Text = "Amount Due";
            this.PayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabel.Location = new System.Drawing.Point(290, 66);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(206, 37);
            this.AmountLabel.TabIndex = 13;
            this.AmountLabel.Text = "Amount Due";
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelButton.Image")));
            this.CancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelButton.Location = new System.Drawing.Point(12, 474);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(170, 60);
            this.CancelButton.TabIndex = 12;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CoinLabel
            // 
            this.CoinLabel.AutoSize = true;
            this.CoinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoinLabel.Location = new System.Drawing.Point(197, 20);
            this.CoinLabel.Name = "CoinLabel";
            this.CoinLabel.Size = new System.Drawing.Size(250, 37);
            this.CoinLabel.TabIndex = 15;
            this.CoinLabel.Text = "Coins Accepted:";
            // 
            // NickelButton
            // 
            this.NickelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NickelButton.BackgroundImage")));
            this.NickelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NickelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NickelButton.Location = new System.Drawing.Point(34, 90);
            this.NickelButton.Name = "NickelButton";
            this.NickelButton.Size = new System.Drawing.Size(100, 100);
            this.NickelButton.TabIndex = 16;
            this.NickelButton.Text = "5c";
            this.NickelButton.UseVisualStyleBackColor = true;
            this.NickelButton.Click += new System.EventHandler(this.NickelButton_Click);
            // 
            // DollarButton
            // 
            this.DollarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DollarButton.BackgroundImage")));
            this.DollarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DollarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DollarButton.Location = new System.Drawing.Point(395, 90);
            this.DollarButton.Name = "DollarButton";
            this.DollarButton.Size = new System.Drawing.Size(100, 100);
            this.DollarButton.TabIndex = 17;
            this.DollarButton.Text = "$1";
            this.DollarButton.UseVisualStyleBackColor = true;
            this.DollarButton.Click += new System.EventHandler(this.DollarButton_Click);
            // 
            // QuarterButton
            // 
            this.QuarterButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QuarterButton.BackgroundImage")));
            this.QuarterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.QuarterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuarterButton.Location = new System.Drawing.Point(273, 90);
            this.QuarterButton.Name = "QuarterButton";
            this.QuarterButton.Size = new System.Drawing.Size(100, 100);
            this.QuarterButton.TabIndex = 18;
            this.QuarterButton.Text = "25c";
            this.QuarterButton.UseVisualStyleBackColor = true;
            this.QuarterButton.Click += new System.EventHandler(this.QuarterButton_Click);
            // 
            // DimeButton
            // 
            this.DimeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DimeButton.BackgroundImage")));
            this.DimeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DimeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DimeButton.Location = new System.Drawing.Point(152, 90);
            this.DimeButton.Name = "DimeButton";
            this.DimeButton.Size = new System.Drawing.Size(100, 100);
            this.DimeButton.TabIndex = 19;
            this.DimeButton.Text = "10c";
            this.DimeButton.UseVisualStyleBackColor = true;
            this.DimeButton.Click += new System.EventHandler(this.DimeButton_Click);
            // 
            // ToonieButton
            // 
            this.ToonieButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ToonieButton.BackgroundImage")));
            this.ToonieButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ToonieButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToonieButton.Location = new System.Drawing.Point(510, 90);
            this.ToonieButton.Name = "ToonieButton";
            this.ToonieButton.Size = new System.Drawing.Size(100, 100);
            this.ToonieButton.TabIndex = 20;
            this.ToonieButton.Text = "$2";
            this.ToonieButton.UseVisualStyleBackColor = true;
            this.ToonieButton.Click += new System.EventHandler(this.ToonieButton_Click);
            // 
            // CoinListPanel
            // 
            this.CoinListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CoinListPanel.Controls.Add(this.ToonieButton);
            this.CoinListPanel.Controls.Add(this.DimeButton);
            this.CoinListPanel.Controls.Add(this.QuarterButton);
            this.CoinListPanel.Controls.Add(this.DollarButton);
            this.CoinListPanel.Controls.Add(this.NickelButton);
            this.CoinListPanel.Controls.Add(this.CoinLabel);
            this.CoinListPanel.Location = new System.Drawing.Point(70, 243);
            this.CoinListPanel.Name = "CoinListPanel";
            this.CoinListPanel.Size = new System.Drawing.Size(641, 205);
            this.CoinListPanel.TabIndex = 21;
            // 
            // Coins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 552);
            this.Controls.Add(this.CoinListPanel);
            this.Controls.Add(this.PayLabel);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.BackButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Coins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PayCoins";
            this.Load += new System.EventHandler(this.Coins_Load);
            this.Shown += new System.EventHandler(this.Coins_Shown);
            this.CoinListPanel.ResumeLayout(false);
            this.CoinListPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label PayLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label CoinLabel;
        private System.Windows.Forms.Button NickelButton;
        private System.Windows.Forms.Button DollarButton;
        private System.Windows.Forms.Button QuarterButton;
        private System.Windows.Forms.Button DimeButton;
        private System.Windows.Forms.Button ToonieButton;
        private System.Windows.Forms.Panel CoinListPanel;
    }
}