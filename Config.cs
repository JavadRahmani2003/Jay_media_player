using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

/*
namespace Jay_Media_Player {
    class Config
    {
        string _FileName = "";
        bool isPlaying = false;
        private bool iPause;

        int Result = 0;

        [DllImport("winmm.dll")]
        private static extern int mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, IntPtr hwndCallBack);

        public string Filename
        {
            get
            {
                return _FileName;
            }
            set
            {
                _FileName = value;
            }
        }
        public bool IsPlaying
        {
            get
            {
                return isPlaying;
            }
        }
        public bool IsPaused
        {
            get
            {
                return iPause;
            }
        }

        public void Play()
        {
            //check if already opened
            if (this.isPlaying)
            {
                this.Stop();
            }

            //Open media
            Result = mciSendString("open \"" + Filename + "\" mpegvideo alias MediaFile", null, 0, IntPtr.Zero);

            //Play media
            Result = mciSendString("Play MediaFile", null, 0, IntPtr.Zero);

            if (Result == 0)
            {
                this.isPlaying = true;
                return;
            }
        }

        public void Pause()
        {
            //check if playing
            if (this.isPlaying)
            {
                iPause = (!iPause);

                if (!iPause)
                {
                    //Pause Command
                    mciSendString("pause MediaFile",null,0,IntPtr.Zero);
                    return;
                }
            }
        }

        public void Stop()
        {
            //Stop mediafile is playing
            if (this.isPlaying)
            {
                Result = mciSendString("stop MediaFile", null, 0, IntPtr.Zero);
                Result = mciSendString("close MediaFile", null, 0, IntPtr.Zero);
                //Set playing to false
                this.isPlaying = false;
            }
        }
    }
}
*/