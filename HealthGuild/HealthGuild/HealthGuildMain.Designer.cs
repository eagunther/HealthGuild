namespace HealthGuild
{
    partial class HealthGuildMain
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
            this.ctlFileSubmissionTracker = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctlFileSubmissionTracker
            // 
            this.ctlFileSubmissionTracker.Location = new System.Drawing.Point(63, 74);
            this.ctlFileSubmissionTracker.Name = "ctlFileSubmissionTracker";
            this.ctlFileSubmissionTracker.Size = new System.Drawing.Size(155, 23);
            this.ctlFileSubmissionTracker.TabIndex = 0;
            this.ctlFileSubmissionTracker.Text = "File Submission Tracker";
            this.ctlFileSubmissionTracker.UseVisualStyleBackColor = true;
            this.ctlFileSubmissionTracker.Click += new System.EventHandler(this.ctlFileSubmissionTracker_Click);
            // 
            // HealthGuildMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ctlFileSubmissionTracker);
            this.Name = "HealthGuildMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ctlFileSubmissionTracker;
    }
}

