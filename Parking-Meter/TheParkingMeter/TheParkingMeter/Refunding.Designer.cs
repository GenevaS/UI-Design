namespace WindowsFormsApplication1
{
    partial class Refunding
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
            this.ChangeLabel = new System.Windows.Forms.Label();
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.CancelLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChangeLabel
            // 
            this.ChangeLabel.AutoSize = true;
            this.ChangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeLabel.Location = new System.Drawing.Point(225, 348);
            this.ChangeLabel.Name = "ChangeLabel";
            this.ChangeLabel.Size = new System.Drawing.Size(214, 37);
            this.ChangeLabel.TabIndex = 5;
            this.ChangeLabel.Text = "Change Due: ";
            // 
            // Progress
            // 
            this.Progress.Location = new System.Drawing.Point(265, 259);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(240, 42);
            this.Progress.TabIndex = 4;
            // 
            // CancelLabel
            // 
            this.CancelLabel.AutoSize = true;
            this.CancelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelLabel.Location = new System.Drawing.Point(188, 163);
            this.CancelLabel.Name = "CancelLabel";
            this.CancelLabel.Size = new System.Drawing.Size(384, 55);
            this.CancelLabel.TabIndex = 3;
            this.CancelLabel.Text = "Refunding Ticket";
            // 
            // Refunding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 552);
            this.Controls.Add(this.ChangeLabel);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.CancelLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Refunding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Refunding";
            this.Load += new System.EventHandler(this.Refunding_Load);
            this.Shown += new System.EventHandler(this.Refunding_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChangeLabel;
        private System.Windows.Forms.ProgressBar Progress;
        private System.Windows.Forms.Label CancelLabel;
    }
}