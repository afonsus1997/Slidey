namespace Slidey
{
    partial class Form1
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.Start = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.About = new MetroFramework.Controls.MetroTabPage();
            this.fromSerial = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.Start);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.About);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(567, 100);
            this.metroTabControl1.TabIndex = 0;
            // 
            // Start
            // 
            this.Start.HorizontalScrollbarBarColor = true;
            this.Start.Location = new System.Drawing.Point(4, 35);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(559, 61);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.VerticalScrollbarBarColor = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(559, 61);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "metroTabPage2";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // About
            // 
            this.About.HorizontalScrollbarBarColor = true;
            this.About.Location = new System.Drawing.Point(4, 35);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(559, 61);
            this.About.TabIndex = 2;
            this.About.Text = "metroTabPage3";
            this.About.VerticalScrollbarBarColor = true;
            // 
            // fromSerial
            // 
            this.fromSerial.AutoSize = true;
            this.fromSerial.Location = new System.Drawing.Point(27, 170);
            this.fromSerial.Name = "fromSerial";
            this.fromSerial.Size = new System.Drawing.Size(59, 13);
            this.fromSerial.TabIndex = 1;
            this.fromSerial.Text = "From Serial";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 300);
            this.Controls.Add(this.fromSerial);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Form1";
            this.Text = "Slidey Settings";
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage Start;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage About;
        private System.Windows.Forms.Label fromSerial;
        private System.Windows.Forms.Timer timer1;
    }
}

