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
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.Net.Mail;
using System.Net;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Net.Mime;
using Microsoft.VisualBasic;

namespace AlarmTrigger
{
    public partial class AlarmTriggerBB : Form
    {
        public AlarmTriggerBB()
        {
            InitializeComponent();
        }

        #region Variables

        string[] AI =
        {
            "What are you doing...",
            "Do you realize what you've done?",
            "Do not repeat this action, do you understand?",
            "Sending an message to the owner of this device, " +
            "Standby...",
            "The owner of this device has been informed about this situation.",
            "You better run...",
            "Locking this computer in t- minus 5 seconds!"
        };

        bool notGoneAway      = true;
        bool goneAway         = false;
        bool intruder         = false;
        bool altF4Pressed     = false;
        bool mousePositionSet = false;

        int timerMiliseconds = 0;
        int mousePositionX   = 0;
        int mousePositionY   = 0;

        private FilterInfoCollection captureDevice;
        private VideoCaptureDevice capturedImage;
        private ComboBox camComboBox;
        private Bitmap bmpImage;

        #region hmm...
        string bb = "collerr4567";
        #endregion

        #endregion

        // Variables and functions...

        #region Functions

        [DllImport("user32")]
        public static extern void LockWorkStation();

        // On load
        private void AlarmTriggerBB_Load(object sender, EventArgs e)
        {
            timer.Start();
            timerMiliseconds++;

            if (notGoneAway)
            {
                hiddenAppIcon.BalloonTipTitle = "Intruder Alarm 1.0";
                hiddenAppIcon.BalloonTipText  = "Up and running...";

                hiddenAppIcon.ShowBalloonTip(4000);

                TopMost            = false;
                this.ShowInTaskbar = false;
                this.WindowState   = FormWindowState.Minimized;
            }

            // Web camera initialization *Important*
            camComboBox = new ComboBox();

            camPreview.Visible = false;
            camPreview.Bounds  = Screen.PrimaryScreen.Bounds;

            captureDevice = new FilterInfoCollection(
                      FilterCategory.VideoInputDevice);
            foreach (FilterInfo camDevice in captureDevice)
            {
                camComboBox.Items.Add(camDevice.Name);
            }

            if (camComboBox.Items.Contains(captureDevice))
            {
                camComboBox.SelectedIndex = Properties.Settings.Default.CamIndex;

                capturedImage = new VideoCaptureDevice(captureDevice
                           [camComboBox.SelectedIndex].MonikerString);

                capturedImage.NewFrame += CaptureImageCam;
                capturedImage.Start();
            }

            if (Properties.Settings.Default.OwnerEmail == "youremail@domain.com")
            {
                if (MessageBox.Show((new Form { TopMost = true }), 
                        "We advise you to go to the settings now! *Important*\n\n" + 
                        "- Change your email and choose a console text color!\n\n" + 
                                        "Click OK to proceed!", "Intruder Alarm 1.0", 
                                                                MessageBoxButtons.OK)
                                                                  == DialogResult.OK)
                {
                    Form2 settings = new Form2();
                    settings.Show();
                }
            }
        }

        private void hiddenAppIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                hiddenAppIcon.ContextMenu = new ContextMenu();
                hiddenAppIcon.ContextMenu.MenuItems.Add(0,
                    new MenuItem("Gone Away", new EventHandler(ChosenOptionMenu)));
                hiddenAppIcon.ContextMenu.MenuItems.Add(1,
                    new MenuItem("On Computer", new EventHandler(ChosenOptionMenu)));

                hiddenAppIcon.ContextMenu.MenuItems.Add(2, new MenuItem("-"));

                hiddenAppIcon.ContextMenu.MenuItems.Add(3,
                    new MenuItem("Settings", new EventHandler(ChosenOptionMenu)));

                hiddenAppIcon.ContextMenu.MenuItems.Add(4,
                    new MenuItem("Application Exit", new EventHandler(ChosenOptionMenu)));
            }
            else if (e.Button == MouseButtons.Left)
            {
                Form2 settings = new Form2();
                settings.Show();
            }
        }

        // Context menu options
        protected void ChosenOptionMenu(object sender, EventArgs e)
        {
            var menuItemAction = ((MenuItem)sender).Index;
            switch (menuItemAction)
            {
                // Deactivates the monitoring of the device
                case 0:
                    notGoneAway = false;
                    goneAway    = true;
                    break;
                // Activates the monitoring of the device
                case 1:
                    notGoneAway = true;
                    goneAway    = false;
                    MessageBox.Show((new Form { TopMost = true }), 
                        "Be careful from now on!", "Intruder Alarm 1.0");
                    break;
                // Launches the settings window
                case 3:
                    Form2 f2 = new Form2();
                    f2.Show();
                    break;
                // Activates the monitoring of the device
                case 4:
                    if (capturedImage != null && capturedImage.IsRunning)
                    {
                        capturedImage.NewFrame -= CaptureImageCam;
                        capturedImage.SignalToStop();
                        capturedImage = null;
                    }

                    MessageBox.Show((new Form { TopMost = true }),
                       "Bye for now, be safe...", "Intruder Alarm 1.0");

                    Task.Delay(2000);
                    hiddenAppIcon.Visible = false;
                    this.Close();
                    Application.Exit();
                    break;
            }
        }

        // Console or AI speech
        private async void AISpeech(string sentence, int speed)
        {
            foreach (char c in sentence)
            {
                await Task.Delay(speed);
                aiSpeech.Text += c.ToString();
            }
        }

        // Receives the actual image from web cam
        private void CaptureImageCam(object sender, NewFrameEventArgs eventArgs)
        {
            bmpImage = (Bitmap)eventArgs.Frame.Clone();
            camPreview.Image = bmpImage;
        }

        // Saves or writes image to a new file with the format jpeg.
        private void SaveImage()
        {
            if (camComboBox.Items.Contains(captureDevice))
            {
                camPreview.Image.Save(Environment.CurrentDirectory +
                                  "Intruder.jpg", ImageFormat.Jpeg);
            }
        }

        // Event to send an email to the owners device via smtp servers
        private void SendMessage()
        {
            try
            {
                MailMessage message = new MailMessage();
                message.From = new MailAddress("bbouchemla@live.com");
                message.To.Add(Properties.Settings.Default.OwnerEmail);
                message.Subject = "Intruder Alarm 1.0 - Alert!";
                message.Body = "Your PC was visited by an intruder at: " + 
                                    DateTime.Now.ToString("HH:mm:ss tt") +
                               "\nWe advise you to take action immediately!";
                
                if (camComboBox.Items.Contains(captureDevice))
                {
                    Attachment img = new Attachment
                        (Environment.CurrentDirectory + "\\Intruder.jpg");
                    message.Attachments.Add(img);
                }

                SmtpClient Smtp = new SmtpClient("smtp.live.com", 587);
                Smtp.Credentials = new NetworkCredential("bbouchemla@live.com", bb);
                Smtp.EnableSsl = true;
                Smtp.Send(message);

                AISpeech("\n\nMessage successfully sent!", 50);
            }
            catch (Exception exE)
            {
                string fake = exE.ToString();
                Console.WriteLine("\n");
                AISpeech("\n\n" + "Couldn't send the message...", 50);
            }
        }

        // Busts the intruder and fires up the matrix styled console
        async void Intruder()
        {
            timer.Stop();
            Cursor.Hide();

            TopMost          = true;
            this.WindowState = FormWindowState.Maximized;
            this.Bounds      = Screen.PrimaryScreen.Bounds;
            aiSpeech.Bounds  = Screen.PrimaryScreen.Bounds;
            aiSpeech.Padding = new Padding(50);

            await Task.Delay(500);

            AISpeech(AI[0], 25);

            await Task.Delay(3000);
            aiSpeech.Text = null;
            await Task.Delay(250);

            AISpeech(AI[1], 25);

            await Task.Delay(3000);
            aiSpeech.Text = null;
            await Task.Delay(250);

            AISpeech(AI[2], 25);

            await Task.Delay(3000);
            aiSpeech.Text = null;
            await Task.Delay(500);

            AISpeech(AI[3], 25);

            await Task.Delay(3000);

            SendMessage();

            await Task.Delay(3000);
            aiSpeech.Text = null;
            await Task.Delay(500);

            AISpeech(AI[4], 25);

            await Task.Delay(3000);
            aiSpeech.Text = null;
            await Task.Delay(500);

            await Task.Delay(3000);
            aiSpeech.Text = null;
            await Task.Delay(500);

            AISpeech(AI[5], 25);

            await Task.Delay(3000);
            aiSpeech.Text = null;
            await Task.Delay(250);

            AISpeech(AI[6], 25);

            await Task.Delay(7000);

            bool lockNow = true;

            if (lockNow)
            {
                this.Close();
                Application.Exit();
                LockWorkStation();
            }
        }

        // Gets the mouse position and alerts if not same
        private void GetMousePos(int x, int y)
        {
            mousePositionX = x;
            mousePositionY = y;
        }

        // Monitors PC activity in real time
        private void timer_Tick(object sender, EventArgs e)
        {
            if (goneAway && !notGoneAway && !intruder)
            {
                if (!mousePositionSet)
                {
                    GetMousePos(Cursor.Position.X, Cursor.Position.Y);
                    mousePositionSet = true;
                    Thread.Sleep(2000);
                }

                if (Cursor.Position.X != mousePositionX &&
                    Cursor.Position.Y != mousePositionY &&
                    mousePositionSet)
                {
                    intruder = true;
                }
            }

            if (goneAway && intruder && !notGoneAway)
            {
                SaveImage();
                Intruder();
            }

            switch (Properties.Settings.Default.SettingColor)
            {
                case "Lime":
                    aiSpeech.ForeColor = Color.Lime;
                    break;
                case "Blue":
                    aiSpeech.ForeColor = Color.Blue;
                    break;
                case "Aqua":
                    aiSpeech.ForeColor = Color.Aqua;
                    break;
                case "Yellow":
                    aiSpeech.ForeColor = Color.Yellow;
                    break;
                case "Red":
                    aiSpeech.ForeColor = Color.Red;
                    break;
                case "Purple":
                    aiSpeech.ForeColor = Color.Purple;
                    break;
            }
        }

        // Prevents the intruder from closing app by pressing ALT + F4 together
        private void AlarmTriggerBB_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (altF4Pressed)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    e.Cancel = true;
                }
                altF4Pressed = false;
            }

            Properties.Settings.Default.Save();
        }

        // Key press options
        private void AlarmTriggerBB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                altF4Pressed = true;
            }

            if (e.Control && e.KeyCode == Keys.B)
            {
                Application.Exit();
            }
        }

        #endregion
    }
}
