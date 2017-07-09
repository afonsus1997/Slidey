namespace Slidey
{
    partial class SliderEmulator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TrackBar1 = new MetroFramework.Controls.MetroTrackBar();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.metroProgressBar2 = new MetroFramework.Controls.MetroProgressBar();
            this.TrackBar2 = new MetroFramework.Controls.MetroTrackBar();
            this.sendTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(461, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // TrackBar1
            // 
            this.TrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.TrackBar1.Location = new System.Drawing.Point(13, 76);
            this.TrackBar1.Name = "TrackBar1";
            this.TrackBar1.Size = new System.Drawing.Size(442, 23);
            this.TrackBar1.TabIndex = 6;
            this.TrackBar1.Text = "TrackBar1";
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(14, 106);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(441, 23);
            this.metroProgressBar1.TabIndex = 7;
            // 
            // metroProgressBar2
            // 
            this.metroProgressBar2.Location = new System.Drawing.Point(14, 194);
            this.metroProgressBar2.Name = "metroProgressBar2";
            this.metroProgressBar2.Size = new System.Drawing.Size(441, 23);
            this.metroProgressBar2.TabIndex = 9;
            // 
            // TrackBar2
            // 
            this.TrackBar2.BackColor = System.Drawing.Color.Transparent;
            this.TrackBar2.Location = new System.Drawing.Point(13, 164);
            this.TrackBar2.Name = "TrackBar2";
            this.TrackBar2.Size = new System.Drawing.Size(442, 23);
            this.TrackBar2.TabIndex = 8;
            this.TrackBar2.Text = "metroTrackBar2";
            // 
            // sendTimer
            // 
            this.sendTimer.Interval = 10;
            this.sendTimer.Tick += new System.EventHandler(this.sendTimer_Tick);
            // 
            // SliderEmulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 497);
            this.Controls.Add(this.metroProgressBar2);
            this.Controls.Add(this.TrackBar2);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.TrackBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SliderEmulator";
            this.Text = "SliderEmulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTrackBar TrackBar1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar2;
        private MetroFramework.Controls.MetroTrackBar TrackBar2;
        private System.Windows.Forms.Timer sendTimer;
    }
}