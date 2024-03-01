namespace AlarmTrigger
{
    partial class AlarmTriggerBB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmTriggerBB));
            this.aiSpeech = new System.Windows.Forms.Label();
            this.hiddenAppIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.camPreview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.camPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // aiSpeech
            // 
            this.aiSpeech.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aiSpeech.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aiSpeech.ForeColor = System.Drawing.Color.Lime;
            this.aiSpeech.Location = new System.Drawing.Point(26, 24);
            this.aiSpeech.Name = "aiSpeech";
            this.aiSpeech.Size = new System.Drawing.Size(0, 0);
            this.aiSpeech.TabIndex = 0;
            // 
            // hiddenAppIcon
            // 
            this.hiddenAppIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("hiddenAppIcon.Icon")));
            this.hiddenAppIcon.Text = "Inspection Alarm BB";
            this.hiddenAppIcon.Visible = true;
            this.hiddenAppIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.hiddenAppIcon_MouseClick);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // camPreview
            // 
            this.camPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.camPreview.Location = new System.Drawing.Point(-16, -12);
            this.camPreview.Name = "camPreview";
            this.camPreview.Size = new System.Drawing.Size(0, 0);
            this.camPreview.TabIndex = 1;
            this.camPreview.TabStop = false;
            this.camPreview.Tag = "camPr";
            this.camPreview.Visible = false;
            // 
            // AlarmTriggerBB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(0, 0);
            this.Controls.Add(this.camPreview);
            this.Controls.Add(this.aiSpeech);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlarmTriggerBB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm Trigger BB";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AlarmTriggerBB_FormClosing);
            this.Load += new System.EventHandler(this.AlarmTriggerBB_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AlarmTriggerBB_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.camPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label aiSpeech;
        private System.Windows.Forms.NotifyIcon hiddenAppIcon;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox camPreview;
    }
}

