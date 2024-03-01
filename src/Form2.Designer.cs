namespace AlarmTrigger
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.settingsTitle = new System.Windows.Forms.Label();
            this.settingsTitleLittle = new System.Windows.Forms.Label();
            this.settingsFontT = new System.Windows.Forms.Label();
            this.footerT = new System.Windows.Forms.Label();
            this.contactBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.webLabel = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.camBox = new System.Windows.Forms.ComboBox();
            this.settingsEmailText = new System.Windows.Forms.Label();
            this.toEmailTxtBox = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.anonMask = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anonMask)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Lime",
            "Blue",
            "Aqua",
            "Yellow",
            "Red",
            "Purple"});
            this.comboBox1.Location = new System.Drawing.Point(338, 234);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // settingsTitle
            // 
            this.settingsTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsTitle.BackColor = System.Drawing.Color.Transparent;
            this.settingsTitle.Font = new System.Drawing.Font("Segoe UI Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsTitle.ForeColor = System.Drawing.Color.White;
            this.settingsTitle.Location = new System.Drawing.Point(220, 129);
            this.settingsTitle.Name = "settingsTitle";
            this.settingsTitle.Size = new System.Drawing.Size(286, 47);
            this.settingsTitle.TabIndex = 1;
            this.settingsTitle.Text = "Intruder Alarm 1.0";
            this.settingsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // settingsTitleLittle
            // 
            this.settingsTitleLittle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsTitleLittle.BackColor = System.Drawing.Color.Transparent;
            this.settingsTitleLittle.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsTitleLittle.ForeColor = System.Drawing.Color.White;
            this.settingsTitleLittle.Location = new System.Drawing.Point(316, 176);
            this.settingsTitleLittle.Name = "settingsTitleLittle";
            this.settingsTitleLittle.Size = new System.Drawing.Size(92, 25);
            this.settingsTitleLittle.TabIndex = 2;
            this.settingsTitleLittle.Text = "Settings";
            this.settingsTitleLittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // settingsFontT
            // 
            this.settingsFontT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.settingsFontT.AutoSize = true;
            this.settingsFontT.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsFontT.ForeColor = System.Drawing.Color.White;
            this.settingsFontT.Location = new System.Drawing.Point(222, 227);
            this.settingsFontT.Name = "settingsFontT";
            this.settingsFontT.Size = new System.Drawing.Size(106, 30);
            this.settingsFontT.TabIndex = 3;
            this.settingsFontT.Text = "Font Color";
            // 
            // footerT
            // 
            this.footerT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.footerT.BackColor = System.Drawing.Color.Transparent;
            this.footerT.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footerT.ForeColor = System.Drawing.Color.White;
            this.footerT.Location = new System.Drawing.Point(493, 705);
            this.footerT.Name = "footerT";
            this.footerT.Size = new System.Drawing.Size(234, 20);
            this.footerT.TabIndex = 4;
            this.footerT.Text = "Made by Bachir Bouchemla with  C#";
            this.footerT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // contactBtn
            // 
            this.contactBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.contactBtn.BackColor = System.Drawing.Color.Blue;
            this.contactBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.contactBtn.ForeColor = System.Drawing.Color.White;
            this.contactBtn.Location = new System.Drawing.Point(29, 689);
            this.contactBtn.Name = "contactBtn";
            this.contactBtn.Size = new System.Drawing.Size(97, 36);
            this.contactBtn.TabIndex = 5;
            this.contactBtn.Text = "Contact Creator";
            this.contactBtn.UseVisualStyleBackColor = false;
            this.contactBtn.Click += new System.EventHandler(this.contactBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(226, 366);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 195);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // webLabel
            // 
            this.webLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.webLabel.AutoSize = true;
            this.webLabel.BackColor = System.Drawing.Color.Transparent;
            this.webLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webLabel.ForeColor = System.Drawing.Color.White;
            this.webLabel.Location = new System.Drawing.Point(223, 333);
            this.webLabel.Name = "webLabel";
            this.webLabel.Size = new System.Drawing.Size(139, 30);
            this.webLabel.TabIndex = 7;
            this.webLabel.Text = "Web Cam Test";
            // 
            // save
            // 
            this.save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.save.BackColor = System.Drawing.Color.DarkGreen;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(321, 617);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(87, 39);
            this.save.TabIndex = 8;
            this.save.Text = "Save Image";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // camBox
            // 
            this.camBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.camBox.BackColor = System.Drawing.Color.White;
            this.camBox.FormattingEnabled = true;
            this.camBox.Location = new System.Drawing.Point(226, 575);
            this.camBox.Name = "camBox";
            this.camBox.Size = new System.Drawing.Size(275, 21);
            this.camBox.TabIndex = 9;
            this.camBox.SelectionChangeCommitted += new System.EventHandler(this.camBox_SelectionChangeCommitted);
            // 
            // settingsEmailText
            // 
            this.settingsEmailText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.settingsEmailText.AutoSize = true;
            this.settingsEmailText.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsEmailText.ForeColor = System.Drawing.Color.White;
            this.settingsEmailText.Location = new System.Drawing.Point(222, 267);
            this.settingsEmailText.Name = "settingsEmailText";
            this.settingsEmailText.Size = new System.Drawing.Size(112, 30);
            this.settingsEmailText.TabIndex = 11;
            this.settingsEmailText.Text = "Your E-mail";
            // 
            // toEmailTxtBox
            // 
            this.toEmailTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.toEmailTxtBox.BackColor = System.Drawing.Color.White;
            this.toEmailTxtBox.Location = new System.Drawing.Point(338, 274);
            this.toEmailTxtBox.Name = "toEmailTxtBox";
            this.toEmailTxtBox.Size = new System.Drawing.Size(168, 20);
            this.toEmailTxtBox.TabIndex = 12;
            this.toEmailTxtBox.TextChanged += new System.EventHandler(this.toEmailTxtBox_TextChanged);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.Maroon;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.Red;
            this.closeBtn.Location = new System.Drawing.Point(701, 19);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(30, 30);
            this.closeBtn.TabIndex = 13;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // anonMask
            // 
            this.anonMask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.anonMask.BackColor = System.Drawing.Color.Transparent;
            this.anonMask.BackgroundImage = global::AlarmTrigger.Properties.Resources.guy_fawkes1;
            this.anonMask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.anonMask.Location = new System.Drawing.Point(321, 29);
            this.anonMask.Name = "anonMask";
            this.anonMask.Size = new System.Drawing.Size(87, 97);
            this.anonMask.TabIndex = 14;
            this.anonMask.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::AlarmTrigger.Properties.Resources.Anonymous_Wallpaper21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 750);
            this.Controls.Add(this.anonMask);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.toEmailTxtBox);
            this.Controls.Add(this.settingsEmailText);
            this.Controls.Add(this.camBox);
            this.Controls.Add(this.save);
            this.Controls.Add(this.webLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.contactBtn);
            this.Controls.Add(this.footerT);
            this.Controls.Add(this.settingsFontT);
            this.Controls.Add(this.settingsTitleLittle);
            this.Controls.Add(this.settingsTitle);
            this.Controls.Add(this.comboBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Intruder Alarm 1.0 - Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anonMask)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label settingsTitle;
        private System.Windows.Forms.Label settingsTitleLittle;
        private System.Windows.Forms.Label settingsFontT;
        private System.Windows.Forms.Label footerT;
        private System.Windows.Forms.Button contactBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label webLabel;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ComboBox camBox;
        private System.Windows.Forms.Label settingsEmailText;
        private System.Windows.Forms.TextBox toEmailTxtBox;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.PictureBox anonMask;
    }
}