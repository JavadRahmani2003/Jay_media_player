using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Notepad;

namespace Jay_Media_Player
{
    public partial class MediaPlayer : Form
    {
        public MediaPlayer() => InitializeComponent();
        WMPLib.WindowsMediaPlayer myPlayer = new WMPLib.WindowsMediaPlayer();
        string path = "";
        bool isPlaying = true;
        bool isMuted = false;

        private void quitAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void whosDeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutbox = new AboutBox();
            aboutbox.Show();
        }

        private void PausePlay_Click(object sender, EventArgs e)
        {
            
            if (isPlaying == false)
            {
                myPlayer.controls.play();
                isPlaying = true;
                this.PausePlay.Image = Jay_Media_Player.Properties.Resources.Play;
            }
            else if (isPlaying == true)
            {
                myPlayer.controls.pause();
                isPlaying = false;
                this.PausePlay.Image = Jay_Media_Player.Properties.Resources.Pause;
            }
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenMedia.Filter = "MP3 Songs| *.mp3 | All files | *.*";
            OpenMedia.Title = "Open a media file";
            if (OpenMedia.ShowDialog() == DialogResult.OK)
            {
                path = OpenMedia.FileName;
                myPlayer.URL = path;
                Status.Text = path;
            }
        }

        private void MuteUnmute_Click(object sender, EventArgs e)
        {
            if (isMuted == false)
            {
                myPlayer.settings.mute = true;
                isMuted = true;
                this.MuteUnmute.Image = Jay_Media_Player.Properties.Resources.Mute;
            }
            else if (isMuted == true)
            {
                myPlayer.settings.mute = false;
                isMuted = false;
                this.MuteUnmute.Image = Jay_Media_Player.Properties.Resources.unmute;
            }
        }

        private void VolumeController_Scroll(object sender, EventArgs e)
        {
            myPlayer.settings.volume = VolumeController.Value * 10;
            Counter.Text = myPlayer.settings.volume + "%";
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            myPlayer.controls.stop();
        }
    }
}
