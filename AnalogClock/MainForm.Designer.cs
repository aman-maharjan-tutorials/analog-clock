namespace AnalogClock
{
    partial class MainForm
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
            this.analogClockControl1 = new AnalogClockControl.AnalogClockControl();
            this.analogClockControl2 = new AnalogClockControl.AnalogClockControl();
            this.SuspendLayout();
            // 
            // analogClockControl1
            // 
            this.analogClockControl1.Location = new System.Drawing.Point(12, 12);
            this.analogClockControl1.Name = "analogClockControl1";
            this.analogClockControl1.Size = new System.Drawing.Size(243, 248);
            this.analogClockControl1.TabIndex = 0;
            this.analogClockControl1.TimeZone = "Sydney";
            // 
            // analogClockControl2
            // 
            this.analogClockControl2.Location = new System.Drawing.Point(261, 12);
            this.analogClockControl2.Name = "analogClockControl2";
            this.analogClockControl2.Size = new System.Drawing.Size(243, 248);
            this.analogClockControl2.TabIndex = 1;
            this.analogClockControl2.TimeZone = "GMT";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 277);
            this.Controls.Add(this.analogClockControl2);
            this.Controls.Add(this.analogClockControl1);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "Drawing Demo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private AnalogClockControl.AnalogClockControl analogClockControl1;
        private AnalogClockControl.AnalogClockControl analogClockControl2;
    }
}

