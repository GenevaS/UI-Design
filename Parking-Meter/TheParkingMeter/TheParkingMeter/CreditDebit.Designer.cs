namespace WindowsFormsApplication1
{
    partial class CreditDebit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditDebit));
            this.TypeLabel = new System.Windows.Forms.Label();
            this.InstructLabel = new System.Windows.Forms.Label();
            this.DebitPic = new System.Windows.Forms.PictureBox();
            this.CreditPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DebitPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditPic)).BeginInit();
            this.SuspendLayout();
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.Location = new System.Drawing.Point(239, 340);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(184, 37);
            this.TypeLabel.TabIndex = 4;
            this.TypeLabel.Text = "Card Type: ";
            // 
            // InstructLabel
            // 
            this.InstructLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructLabel.Location = new System.Drawing.Point(-6, 138);
            this.InstructLabel.Name = "InstructLabel";
            this.InstructLabel.Size = new System.Drawing.Size(768, 153);
            this.InstructLabel.TabIndex = 3;
            this.InstructLabel.Text = "Please follow the instructions on the card reader";
            this.InstructLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DebitPic
            // 
            this.DebitPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DebitPic.BackgroundImage")));
            this.DebitPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DebitPic.Location = new System.Drawing.Point(420, 305);
            this.DebitPic.Name = "DebitPic";
            this.DebitPic.Size = new System.Drawing.Size(126, 114);
            this.DebitPic.TabIndex = 5;
            this.DebitPic.TabStop = false;
            this.DebitPic.Visible = false;
            // 
            // CreditPic
            // 
            this.CreditPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CreditPic.BackgroundImage")));
            this.CreditPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CreditPic.Location = new System.Drawing.Point(429, 294);
            this.CreditPic.Name = "CreditPic";
            this.CreditPic.Size = new System.Drawing.Size(126, 114);
            this.CreditPic.TabIndex = 6;
            this.CreditPic.TabStop = false;
            this.CreditPic.Visible = false;
            // 
            // CreditDebit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 552);
            this.Controls.Add(this.CreditPic);
            this.Controls.Add(this.DebitPic);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.InstructLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreditDebit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DebitCredit";
            this.Load += new System.EventHandler(this.CreditDebit_Load);
            this.Shown += new System.EventHandler(this.CreditDebit_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DebitPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label InstructLabel;
        private System.Windows.Forms.PictureBox DebitPic;
        private System.Windows.Forms.PictureBox CreditPic;
    }
}