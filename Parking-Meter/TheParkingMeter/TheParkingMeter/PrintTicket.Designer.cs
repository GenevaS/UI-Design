namespace WindowsFormsApplication1
{
    partial class PrintTicket
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
            this.PrintLabel = new System.Windows.Forms.Label();
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.ChangeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PrintLabel
            // 
            this.PrintLabel.AutoSize = true;
            this.PrintLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintLabel.Location = new System.Drawing.Point(222, 126);
            this.PrintLabel.Name = "PrintLabel";
            this.PrintLabel.Size = new System.Drawing.Size(326, 55);
            this.PrintLabel.TabIndex = 0;
            this.PrintLabel.Text = "Printing Ticket";
            // 
            // Progress
            // 
            this.Progress.Location = new System.Drawing.Point(263, 214);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(240, 42);
            this.Progress.TabIndex = 1;
            // 
            // ChangeLabel
            // 
            this.ChangeLabel.AutoSize = true;
            this.ChangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeLabel.Location = new System.Drawing.Point(238, 309);
            this.ChangeLabel.Name = "ChangeLabel";
            this.ChangeLabel.Size = new System.Drawing.Size(214, 37);
            this.ChangeLabel.TabIndex = 2;
            this.ChangeLabel.Text = "Change Due: ";
            // 
            // PrintTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 552);
            this.Controls.Add(this.ChangeLabel);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.PrintLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrintTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintTicket";
            this.Load += new System.EventHandler(this.PrintTicket_Load);
            this.Shown += new System.EventHandler(this.PrintTicket_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PrintLabel;
        private System.Windows.Forms.ProgressBar Progress;
        private System.Windows.Forms.Label ChangeLabel;

    }
}