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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.Start = new MetroFramework.Controls.MetroTabPage();
            this.Serial = new MetroFramework.Controls.MetroTabPage();
            this.serialLabel = new MetroFramework.Controls.MetroLabel();
            this.connectButton = new MetroFramework.Controls.MetroButton();
            this.comboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.Debug = new MetroFramework.Controls.MetroTabPage();
            this.fromSerial = new System.Windows.Forms.Label();
            this.About = new MetroFramework.Controls.MetroTabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Modes = new MetroFramework.Controls.MetroTabPage();
            this.comboS1 = new MetroFramework.Controls.MetroComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboS2 = new MetroFramework.Controls.MetroComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.metroTabControl1.SuspendLayout();
            this.Start.SuspendLayout();
            this.Serial.SuspendLayout();
            this.Debug.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.Modes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.Start);
            this.metroTabControl1.Controls.Add(this.Modes);
            this.metroTabControl1.Controls.Add(this.Serial);
            this.metroTabControl1.Controls.Add(this.Debug);
            this.metroTabControl1.Controls.Add(this.About);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(665, 373);
            this.metroTabControl1.TabIndex = 0;
            // 
            // Start
            // 
            this.Start.Controls.Add(this.pictureBox3);
            this.Start.HorizontalScrollbarBarColor = true;
            this.Start.Location = new System.Drawing.Point(4, 35);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(657, 334);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.VerticalScrollbarBarColor = true;
            // 
            // Serial
            // 
            this.Serial.Controls.Add(this.serialLabel);
            this.Serial.Controls.Add(this.connectButton);
            this.Serial.Controls.Add(this.comboBox1);
            this.Serial.HorizontalScrollbarBarColor = true;
            this.Serial.Location = new System.Drawing.Point(4, 35);
            this.Serial.Name = "Serial";
            this.Serial.Size = new System.Drawing.Size(657, 334);
            this.Serial.TabIndex = 1;
            this.Serial.Text = "Serial";
            this.Serial.VerticalScrollbarBarColor = true;
            // 
            // serialLabel
            // 
            this.serialLabel.AutoSize = true;
            this.serialLabel.Location = new System.Drawing.Point(283, 35);
            this.serialLabel.Name = "serialLabel";
            this.serialLabel.Size = new System.Drawing.Size(55, 19);
            this.serialLabel.TabIndex = 4;
            this.serialLabel.Text = "rx serial";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(3, 35);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(113, 29);
            this.connectButton.TabIndex = 3;
            this.connectButton.Text = "Connect";
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 23;
            this.comboBox1.Location = new System.Drawing.Point(141, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 29);
            this.comboBox1.TabIndex = 2;
            // 
            // Debug
            // 
            this.Debug.Controls.Add(this.fromSerial);
            this.Debug.HorizontalScrollbarBarColor = true;
            this.Debug.Location = new System.Drawing.Point(4, 35);
            this.Debug.Name = "Debug";
            this.Debug.Size = new System.Drawing.Size(657, 334);
            this.Debug.TabIndex = 3;
            this.Debug.Text = "Debug";
            this.Debug.VerticalScrollbarBarColor = true;
            // 
            // fromSerial
            // 
            this.fromSerial.AutoSize = true;
            this.fromSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromSerial.Location = new System.Drawing.Point(21, 30);
            this.fromSerial.Name = "fromSerial";
            this.fromSerial.Size = new System.Drawing.Size(122, 25);
            this.fromSerial.TabIndex = 1;
            this.fromSerial.Text = "From Serial";
            // 
            // About
            // 
            this.About.HorizontalScrollbarBarColor = true;
            this.About.Location = new System.Drawing.Point(4, 35);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(657, 334);
            this.About.TabIndex = 2;
            this.About.Text = "About";
            this.About.VerticalScrollbarBarColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // Modes
            // 
            this.Modes.Controls.Add(this.pictureBox2);
            this.Modes.Controls.Add(this.pictureBox1);
            this.Modes.Controls.Add(this.comboS2);
            this.Modes.Controls.Add(this.comboS1);
            this.Modes.HorizontalScrollbarBarColor = true;
            this.Modes.Location = new System.Drawing.Point(4, 35);
            this.Modes.Name = "Modes";
            this.Modes.Size = new System.Drawing.Size(657, 334);
            this.Modes.TabIndex = 4;
            this.Modes.Text = "Modes";
            this.Modes.VerticalScrollbarBarColor = true;
            // 
            // comboS1
            // 
            this.comboS1.FormattingEnabled = true;
            this.comboS1.ItemHeight = 23;
            this.comboS1.Items.AddRange(new object[] {
            "Master",
            "Current App"});
            this.comboS1.Location = new System.Drawing.Point(184, 271);
            this.comboS1.Name = "comboS1";
            this.comboS1.Size = new System.Drawing.Size(121, 29);
            this.comboS1.TabIndex = 2;
            this.comboS1.SelectedIndexChanged += new System.EventHandler(this.comboS1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Slidey.Properties.Resources.fader;
            this.pictureBox1.Location = new System.Drawing.Point(233, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Slidey.Properties.Resources.fader;
            this.pictureBox2.Location = new System.Drawing.Point(334, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 227);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // comboS2
            // 
            this.comboS2.AutoCompleteCustomSource.AddRange(new string[] {
            "Master",
            "Current App"});
            this.comboS2.FormattingEnabled = true;
            this.comboS2.ItemHeight = 23;
            this.comboS2.Items.AddRange(new object[] {
            "Master",
            "Current App"});
            this.comboS2.Location = new System.Drawing.Point(334, 271);
            this.comboS2.Name = "comboS2";
            this.comboS2.Size = new System.Drawing.Size(121, 29);
            this.comboS2.TabIndex = 2;
            this.comboS2.SelectedIndexChanged += new System.EventHandler(this.comboS2_SelectedIndexChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(21, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(619, 290);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 470);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Form1";
            this.Text = "Slidey Settings";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.Leave += new System.EventHandler(this.Form1_Leave);
            this.metroTabControl1.ResumeLayout(false);
            this.Start.ResumeLayout(false);
            this.Serial.ResumeLayout(false);
            this.Serial.PerformLayout();
            this.Debug.ResumeLayout(false);
            this.Debug.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.Modes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage Start;
        private MetroFramework.Controls.MetroTabPage Serial;
        private MetroFramework.Controls.MetroTabPage About;
        private System.Windows.Forms.Label fromSerial;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroTabPage Debug;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroButton connectButton;
        private MetroFramework.Controls.MetroComboBox comboBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private MetroFramework.Controls.MetroLabel serialLabel;
        private MetroFramework.Controls.MetroTabPage Modes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroComboBox comboS1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroComboBox comboS2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

