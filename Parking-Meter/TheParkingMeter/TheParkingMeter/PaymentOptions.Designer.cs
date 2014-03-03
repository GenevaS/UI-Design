namespace WindowsFormsApplication1
{
    partial class PaymentOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentOptions));
            this.CoinButton = new System.Windows.Forms.Button();
            this.DebitButton = new System.Windows.Forms.Button();
            this.CreditButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.PayLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CoinButton
            // 
            this.CoinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoinButton.Image = ((System.Drawing.Image)(resources.GetObject("CoinButton.Image")));
            this.CoinButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.CoinButton.Location = new System.Drawing.Point(12, 276);
            this.CoinButton.Name = "CoinButton";
            this.CoinButton.Size = new System.Drawing.Size(224, 114);
            this.CoinButton.TabIndex = 0;
            this.CoinButton.Text = "Coins";
            this.CoinButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CoinButton.UseVisualStyleBackColor = true;
            this.CoinButton.Click += new System.EventHandler(this.CoinButton_Click);
            // 
            // DebitButton
            // 
            this.DebitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebitButton.Image = ((System.Drawing.Image)(resources.GetObject("DebitButton.Image")));
            this.DebitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DebitButton.Location = new System.Drawing.Point(275, 276);
            this.DebitButton.Name = "DebitButton";
            this.DebitButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.DebitButton.Size = new System.Drawing.Size(224, 114);
            this.DebitButton.TabIndex = 1;
            this.DebitButton.Text = "Debit";
            this.DebitButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DebitButton.UseVisualStyleBackColor = true;
            this.DebitButton.Click += new System.EventHandler(this.DebitButton_Click);
            // 
            // CreditButton
            // 
            this.CreditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditButton.Image = ((System.Drawing.Image)(resources.GetObject("CreditButton.Image")));
            this.CreditButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreditButton.Location = new System.Drawing.Point(538, 276);
            this.CreditButton.Name = "CreditButton";
            this.CreditButton.Size = new System.Drawing.Size(224, 114);
            this.CreditButton.TabIndex = 2;
            this.CreditButton.Text = "Credit";
            this.CreditButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CreditButton.UseVisualStyleBackColor = true;
            this.CreditButton.Click += new System.EventHandler(this.CreditButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelButton.Image")));
            this.CancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelButton.Location = new System.Drawing.Point(27, 474);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(170, 60);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabel.Location = new System.Drawing.Point(283, 43);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(206, 37);
            this.AmountLabel.TabIndex = 8;
            this.AmountLabel.Text = "Amount Due";
            // 
            // PayLabel
            // 
            this.PayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayLabel.Location = new System.Drawing.Point(165, 133);
            this.PayLabel.Name = "PayLabel";
            this.PayLabel.Size = new System.Drawing.Size(442, 75);
            this.PayLabel.TabIndex = 9;
            this.PayLabel.Text = "Amount Due";
            this.PayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.BackButton.TabIndex = 10;
            this.BackButton.Text = "Back";
            this.BackButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // PaymentOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 552);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.PayLabel);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CreditButton);
            this.Controls.Add(this.DebitButton);
            this.Controls.Add(this.CoinButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaymentOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentOptions";
            this.Load += new System.EventHandler(this.PaymentOptions_Load);
            this.Shown += new System.EventHandler(this.PaymentOptions_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CoinButton;
        private System.Windows.Forms.Button DebitButton;
        private System.Windows.Forms.Button CreditButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label PayLabel;
        private System.Windows.Forms.Button BackButton;
    }
}