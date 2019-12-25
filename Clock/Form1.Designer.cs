namespace Clock
{
    partial class Clock
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelDate = new System.Windows.Forms.Label();
            this.LabelTime = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.LabelDate);
            this.panel1.Controls.Add(this.LabelTime);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 179);
            this.panel1.TabIndex = 5;
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelDate.ForeColor = System.Drawing.Color.Peru;
            this.LabelDate.Location = new System.Drawing.Point(265, 140);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(100, 24);
            this.LabelDate.TabIndex = 5;
            this.LabelDate.Text = "25.12.2019";
            // 
            // LabelTime
            // 
            this.LabelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTime.AutoSize = true;
            this.LabelTime.Font = new System.Drawing.Font("Arial", 72F);
            this.LabelTime.ForeColor = System.Drawing.Color.Black;
            this.LabelTime.Location = new System.Drawing.Point(107, 17);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(417, 107);
            this.LabelTime.TabIndex = 4;
            this.LabelTime.Text = "00:00:00";
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(632, 181);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(211, 120);
            this.Name = "Clock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clock";
            this.Resize += new System.EventHandler(this.Time_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.Label LabelTime;
    }
}

