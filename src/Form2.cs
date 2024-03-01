//----------------------------------\\
//      Intruder Alarm 1.0          \\
//                                  \\
//  Application made by Bachir B    \\
//  Created human year 2016, for    \\
//  the security of owners device.  \\
//  Alerts if someone touches it.   \\
//----------------------------------\\
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;

namespace AlarmTrigger
{
    public partial class Form2 : Form
    {
        // Variables
        private FilterInfoCollection captureDevice;
        private VideoCaptureDevice capturedImage;
        private Bitmap bmpImage;

        private int mouseBtnDragDown = 0;
        private int MouseX, MouseY = 0;

        private int ScreenX = Screen.PrimaryScreen.Bounds.Width;
        private int ScreenY = Screen.PrimaryScreen.Bounds.Height;

        public Form2()
        {
            #region Main

            InitializeComponent();

            TopMost = true;

            switch (Properties.Settings.Default.SettingColor)
            {
                case "Lime":
                    settingsTitle.ForeColor       = Color.Lime;
                    settingsTitleLittle.ForeColor = Color.Lime;
                    settingsFontT.ForeColor       = Color.Lime;
                    footerT.ForeColor             = Color.Lime;
                    settingsEmailText.ForeColor   = Color.Lime;
                    webLabel.ForeColor            = Color.Lime;
                    break;
                case "Blue":
                    settingsTitle.ForeColor       = Color.Blue;
                    settingsTitleLittle.ForeColor = Color.Blue;
                    settingsFontT.ForeColor       = Color.Blue;
                    footerT.ForeColor             = Color.Blue;
                    settingsEmailText.ForeColor   = Color.Blue;
                    webLabel.ForeColor            = Color.Blue;
                    break;
                case "Aqua":
                    settingsTitle.ForeColor       = Color.Aqua;
                    settingsTitleLittle.ForeColor = Color.Aqua;
                    settingsFontT.ForeColor       = Color.Aqua;
                    footerT.ForeColor             = Color.Aqua;
                    settingsEmailText.ForeColor   = Color.Aqua;
                    webLabel.ForeColor            = Color.Aqua;
                    break;
                case "Yellow":
                    settingsTitle.ForeColor       = Color.Yellow;
                    settingsTitleLittle.ForeColor = Color.Yellow;
                    settingsFontT.ForeColor       = Color.Yellow;
                    footerT.ForeColor             = Color.Yellow;
                    settingsEmailText.ForeColor   = Color.Yellow;
                    webLabel.ForeColor            = Color.Yellow;
                    break;
                case "Red":
                    settingsTitle.ForeColor       = Color.Red;
                    settingsTitleLittle.ForeColor = Color.Red;
                    settingsFontT.ForeColor       = Color.Red;
                    footerT.ForeColor             = Color.Red;
                    settingsEmailText.ForeColor   = Color.Red;
                    webLabel.ForeColor            = Color.Red;
                    break;
                case "Purple":
                    settingsTitle.ForeColor       = Color.Purple;
                    settingsTitleLittle.ForeColor = Color.Purple;
                    settingsFontT.ForeColor       = Color.Purple;
                    footerT.ForeColor             = Color.Purple;
                    settingsEmailText.ForeColor   = Color.Purple;
                    webLabel.ForeColor            = Color.Purple;
                    break;
                case null:
                    comboBox1.SelectedItem                   = comboBox1.Items[0];
                    Properties.Settings.Default.SettingColor = "Lime";
                    break;
            }

            captureDevice = new FilterInfoCollection(
                      FilterCategory.VideoInputDevice);
            foreach (FilterInfo deviceCam in captureDevice)
            {
                camBox.Items.Add(deviceCam.Name);
                camBox.SelectedItem = deviceCam.Name;
            }

            if (camBox.Items.Contains(captureDevice))
            {
                camBox.SelectedIndex = Properties.Settings.Default.CamIndex;

                if (capturedImage != null && capturedImage.IsRunning)
                {
                    capturedImage.Stop();
                }

                capturedImage = new VideoCaptureDevice(captureDevice
                                [camBox.SelectedIndex].MonikerString);

                capturedImage.NewFrame += CaptureImageCam;
                capturedImage.Start();
            }
            else
            {
                Bitmap bmpWall = Properties.Resources.Anonymous_Wallpaper;
                pictureBox1.Image = bmpWall;
            }

            toEmailTxtBox.Text     = Properties.Settings.Default.OwnerEmail;
            comboBox1.SelectedItem = Properties.Settings.Default.SettingColor;
        }

        #endregion

        #region Functions       

        // Captures an image of the target while he/she's intruding the PC
        private void CaptureImageCam(object sender, NewFrameEventArgs eventArgs)
        {
            bmpImage = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bmpImage;
        }

        // On color changes
        private async void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Properties.Settings.Default.SettingColor = comboBox1.SelectedItem.ToString();
            Properties.Settings.Default.Save();

            await Task.Delay(500);

            Form2 form = new Form2();
            form.Show();

            this.Close();
        }

        // On contact button click
        private void contactBtn_Click(object sender, EventArgs e)
        {
            Process.Start("http://bludaygames.com/contact.html");
        }

        // Saves the color scheme when this window closes
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.OwnerEmail = toEmailTxtBox.Text;
            Properties.Settings.Default.Save();

            if (capturedImage != null && capturedImage.IsRunning)
            {
                capturedImage.NewFrame -= CaptureImageCam;
                capturedImage.SignalToStop();
                capturedImage = null;
            }
        }

        // Closes the form, settings
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Brings the color scheme information on window load
        private void Form2_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation((ScreenX / 2) - (this.Width  / 2), 
                                    (ScreenY / 2) - (this.Height / 2));

            comboBox1.SelectedItem = Properties.Settings.Default.SettingColor;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (capturedImage.IsRunning)
            {
                pictureBox1.Image.Save(Environment.CurrentDirectory + 
                                     "\\Intruder.jpg", ImageFormat.Jpeg);

                MessageBox.Show((new Form2 { TopMost = true }),
                    "Success! Your image has been saved at: " + Environment.CurrentDirectory);
            }
            else MessageBox.Show((new Form2 { TopMost = true }),
                          "Error, connect a webcam to your PC!");
        }

        // Saves the info
        private async void camBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Properties.Settings.Default.OwnerEmail = toEmailTxtBox.Text.ToString();
            
            if (camBox.Items.Contains(captureDevice))
            {
                capturedImage.NewFrame -= CaptureImageCam;
                Properties.Settings.Default.CamIndex = camBox.SelectedIndex;
            }

            Properties.Settings.Default.Save();

            await Task.Delay(500);

            capturedImage = new VideoCaptureDevice(captureDevice
                                [camBox.SelectedIndex].MonikerString);

            capturedImage.NewFrame += CaptureImageCam;
            capturedImage.Start();
        }

        // Move the form app around your screen \\
        // On mouse down
        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseBtnDragDown = 1;
            MouseX = e.X;
            MouseY = e.Y;
        }

        // When the mouse is moving
        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseBtnDragDown == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MouseX, 
                                        MousePosition.Y - MouseY);
            }
        }

        // On mouse up
        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseBtnDragDown = 0;
        }

        // Saves the email address when the textbox value changes
        private void toEmailTxtBox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.OwnerEmail = toEmailTxtBox.Text;
            Properties.Settings.Default.Save();
        }

        #endregion
    }
}
