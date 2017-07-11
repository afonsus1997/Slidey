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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Sliders = new MetroFramework.Controls.MetroTabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboS2 = new MetroFramework.Controls.MetroComboBox();
            this.comboS1 = new MetroFramework.Controls.MetroComboBox();
            this.knob2 = new System.Windows.Forms.PictureBox();
            this.knob1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.body1 = new System.Windows.Forms.PictureBox();
            this.Serial = new MetroFramework.Controls.MetroTabPage();
            this.serialLabel = new MetroFramework.Controls.MetroLabel();
            this.connectButton = new MetroFramework.Controls.MetroButton();
            this.comboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.Debug = new MetroFramework.Controls.MetroTabPage();
            this.fromSerial = new System.Windows.Forms.Label();
            this.About = new MetroFramework.Controls.MetroTabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Buttons = new MetroFramework.Controls.MetroTabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.metroTabControl1.SuspendLayout();
            this.Start.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.Sliders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.knob2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knob1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.body1)).BeginInit();
            this.Serial.SuspendLayout();
            this.Debug.SuspendLayout();
            this.About.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.Start);
            this.metroTabControl1.Controls.Add(this.Sliders);
            this.metroTabControl1.Controls.Add(this.Serial);
            this.metroTabControl1.Controls.Add(this.Debug);
            this.metroTabControl1.Controls.Add(this.About);
            this.metroTabControl1.Controls.Add(this.Buttons);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
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
            // Sliders
            // 
            this.Sliders.Controls.Add(this.label2);
            this.Sliders.Controls.Add(this.label1);
            this.Sliders.Controls.Add(this.comboS2);
            this.Sliders.Controls.Add(this.comboS1);
            this.Sliders.Controls.Add(this.knob2);
            this.Sliders.Controls.Add(this.knob1);
            this.Sliders.Controls.Add(this.pictureBox1);
            this.Sliders.Controls.Add(this.body1);
            this.Sliders.HorizontalScrollbarBarColor = true;
            this.Sliders.Location = new System.Drawing.Point(4, 35);
            this.Sliders.Name = "Sliders";
            this.Sliders.Size = new System.Drawing.Size(657, 334);
            this.Sliders.TabIndex = 4;
            this.Sliders.Text = "Modes";
            this.Sliders.VerticalScrollbarBarColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(431, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 54);
            this.label2.TabIndex = 5;
            this.label2.Text = "Right Slider";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 54);
            this.label1.TabIndex = 5;
            this.label1.Text = "Left Slider";
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
            this.comboS2.Location = new System.Drawing.Point(431, 79);
            this.comboS2.Name = "comboS2";
            this.comboS2.Size = new System.Drawing.Size(121, 29);
            this.comboS2.TabIndex = 2;
            this.comboS2.SelectedIndexChanged += new System.EventHandler(this.comboS2_SelectedIndexChanged);
            // 
            // comboS1
            // 
            this.comboS1.FormattingEnabled = true;
            this.comboS1.ItemHeight = 23;
            this.comboS1.Items.AddRange(new object[] {
            "Master",
            "Current App"});
            this.comboS1.Location = new System.Drawing.Point(83, 79);
            this.comboS1.Name = "comboS1";
            this.comboS1.Size = new System.Drawing.Size(121, 29);
            this.comboS1.TabIndex = 2;
            this.comboS1.SelectedIndexChanged += new System.EventHandler(this.comboS1_SelectedIndexChanged);
            // 
            // knob2
            // 
            this.knob2.Image = global::Slidey.Properties.Resources.faderknob;
            this.knob2.Location = new System.Drawing.Point(353, 234);
            this.knob2.Name = "knob2";
            this.knob2.Size = new System.Drawing.Size(51, 80);
            this.knob2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.knob2.TabIndex = 4;
            this.knob2.TabStop = false;
            // 
            // knob1
            // 
            this.knob1.Image = global::Slidey.Properties.Resources.faderknob;
            this.knob1.Location = new System.Drawing.Point(248, 234);
            this.knob1.Name = "knob1";
            this.knob1.Size = new System.Drawing.Size(51, 80);
            this.knob1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.knob1.TabIndex = 4;
            this.knob1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Slidey.Properties.Resources.faderbody;
            this.pictureBox1.Location = new System.Drawing.Point(325, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 309);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // body1
            // 
            this.body1.Image = global::Slidey.Properties.Resources.faderbody;
            this.body1.Location = new System.Drawing.Point(219, 22);
            this.body1.Name = "body1";
            this.body1.Size = new System.Drawing.Size(100, 309);
            this.body1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.body1.TabIndex = 3;
            this.body1.TabStop = false;
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
            this.About.Controls.Add(this.label5);
            this.About.Controls.Add(this.label4);
            this.About.Controls.Add(this.label3);
            this.About.Controls.Add(this.pictureBox2);
            this.About.HorizontalScrollbarBarColor = true;
            this.About.Location = new System.Drawing.Point(4, 35);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(657, 334);
            this.About.TabIndex = 2;
            this.About.Text = "About";
            this.About.VerticalScrollbarBarColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(318, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "©Afonso Muralha 2017";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(316, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Slider Interface";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(310, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 65);
            this.label3.TabIndex = 3;
            this.label3.Text = "Slidey";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Slidey.Properties.Resources.Sliderbkbig;
            this.pictureBox2.Location = new System.Drawing.Point(3, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 300);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Buttons
            // 
            this.Buttons.HorizontalScrollbarBarColor = true;
            this.Buttons.Location = new System.Drawing.Point(4, 35);
            this.Buttons.Name = "Buttons";
            this.Buttons.Size = new System.Drawing.Size(657, 334);
            this.Buttons.TabIndex = 5;
            this.Buttons.Text = "Buttons";
            this.Buttons.VerticalScrollbarBarColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 453);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "Slidey Settings";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Leave += new System.EventHandler(this.Form1_Leave);
            this.metroTabControl1.ResumeLayout(false);
            this.Start.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.Sliders.ResumeLayout(false);
            this.Sliders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.knob2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knob1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.body1)).EndInit();
            this.Serial.ResumeLayout(false);
            this.Serial.PerformLayout();
            this.Debug.ResumeLayout(false);
            this.Debug.PerformLayout();
            this.About.ResumeLayout(false);
            this.About.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
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
        private MetroFramework.Controls.MetroTabPage Sliders;
        private MetroFramework.Controls.MetroComboBox comboS1;
        private MetroFramework.Controls.MetroComboBox comboS2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox knob1;
        private System.Windows.Forms.PictureBox body1;
        private System.Windows.Forms.PictureBox knob2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTabPage Buttons;
    }
}

