using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using CSCore.CoreAudioAPI;

namespace Yemekhane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 60000;
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dateTimePicker1.Value;
            DateTime dateTime2 = dateTime.AddMinutes(20);
            DateTime dateTime3 = dateTime2.AddMinutes(20);
            DateTime dateTime4 = dateTime3.AddMinutes(20);
            infoTxt.Text =
                "Alarm Kuruldu \n" +
                dateTime.ToString("HH:mm") + ("\n") +
                dateTime2.ToString("HH:mm") + ("\n") +
                dateTime3.ToString("HH:mm") + ("\n") +
                dateTime4.ToString("HH:mm");
            infoTxt.ForeColor = Color.Green;
            timer1.Start();
            button1.Enabled = true;
            saveBtn.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            DateTime dateTime = dateTimePicker1.Value;
           // dateTime.AddMinutes(-1);
            DateTime dateTime2 = dateTime.AddMinutes(20);
            DateTime dateTime3 = dateTime2.AddMinutes(20);
            DateTime dateTime4 = dateTime3.AddMinutes(20);


            if (currentTime.Hour == dateTime.Hour && currentTime.Minute == dateTime.Minute)
                ses(true);
            else if (currentTime.Hour == dateTime2.Hour && currentTime.Minute == dateTime2.Minute)
                ses(true);
            else if (currentTime.Hour == dateTime3.Hour && currentTime.Minute == dateTime3.Minute)
                ses(true);
            else if (currentTime.Hour == dateTime4.Hour && currentTime.Minute == dateTime4.Minute)
                ses(false);
            
        }

        private void startRing_Click(object sender, EventArgs e)
        {
            ses(true);
        }

        private void stopRing_Click(object sender, EventArgs e)
        {
            ses(false);
        }

        void ses(bool baslangic) // true = Başlangıç sesi, false = Bitiş sesi.
        {
            SoundPlayer baslangicSesi = new SoundPlayer(Properties.Resources.Sound005);
            SoundPlayer bitisSesi = new SoundPlayer(Properties.Resources.Sound006);
            Thread thread = new Thread(new ThreadStart(VolumeChanger));
            thread.Start();
            if (baslangic) baslangicSesi.Play();
            else bitisSesi.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            saveBtn.Enabled = true;
            timer1.Stop();
            infoTxt.Text =
                "Alarm Sıfırlandı!";
            infoTxt.ForeColor = Color.Red;
        }

        public void VolumeChanger()
        {
            float volume = 0, volume2 = 0;

            using (var sessionManager = GetDefaultAudioSessionManager2(DataFlow.Render))
            {
                using (var sessionEnumerator = sessionManager.GetSessionEnumerator())
                {
                    Assert.IsNotNull(sessionEnumerator);

                    foreach (var session in sessionEnumerator)
                    {
                        Assert.IsNotNull(session);
                        using (var session2 = session.QueryInterface<AudioSessionControl2>())
                        {
                            using (var simpleVolume = session.QueryInterface<SimpleAudioVolume>())
                            {
                                
                                if (session2.Process.ProcessName == "Yemekhane") //??
                                {
                                    Assert.IsNotNull(simpleVolume);
                                    volume = simpleVolume.MasterVolume;
                                    simpleVolume.MasterVolume = YemekhaneBar.Value * 0.05f;
                                }
                                else
                                {
                                    Assert.IsNotNull(simpleVolume);
                                    volume2 = simpleVolume.MasterVolume;
                                    simpleVolume.MasterVolume = DigerBar.Value * 0.05f;
                                }
                            }
                        }
                    }
                    System.Threading.Thread.Sleep(5000);

                    foreach (var session in sessionEnumerator)
                    {
                        Assert.IsNotNull(session);
                        using (var session2 = session.QueryInterface<AudioSessionControl2>())
                        {
                            using (var simpleVolume = session.QueryInterface<SimpleAudioVolume>())
                            {
                                if (session2.Process.ProcessName == "Yemekhane")
                                {
                                    Assert.IsNotNull(simpleVolume);
                                    simpleVolume.MasterVolume = volume;
                                }
                                else
                                {
                                    Assert.IsNotNull(simpleVolume);
                                    simpleVolume.MasterVolume = volume2;
                                }
                            }
                        }
                    }
                }
            }
        }
        private static AudioSessionManager2 GetDefaultAudioSessionManager2(DataFlow dataFlow)
        {
            using (var enumerator = new MMDeviceEnumerator())
            {
                using (var device = enumerator.GetDefaultAudioEndpoint(dataFlow, Role.Multimedia))
                {
                    Debug.WriteLine("DefaultDevice: " + device.FriendlyName);
                    var sessionManager = AudioSessionManager2.FromMMDevice(device);
                    return sessionManager;
                }
            }
        }

       
    }
}
