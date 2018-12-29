using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using static System.Net.Mime.MediaTypeNames;

namespace CalendarSystem
{
    public class Music
    {
        SoundPlayer p = new SoundPlayer();
        public string MusicPath { get; set; }
        public Music() { }


        public void SetMusic(string musicPath) {
            MusicPath = musicPath;
        }

        public void SelectMusic(int index) {
            try {
                switch (index) {
                    case 1:
                        p.SoundLocation = @".\音乐1.wav";
                        p.Load();
                        break;
                    case 2:
                        p.SoundLocation = @".\音乐2.wav";
                        p.Load();
                        break;
                    case 3:
                        p.SoundLocation = @".\音乐3.wav";
                        p.Load();
                        break;
                    case 4:
                        p.SoundLocation = MusicPath;
                        p.Load();
                        break;
                    default:
                        return;
                }
            }
            catch {
                p.SoundLocation = @".\音乐1.wav";
                p.Load();
            }
            //p.PlayLooping();


        }

        public void PlayMusic() {
            
            p.PlayLooping();
        }

        public void SetRemindMusic(int index) {
            if (index != 0) {
                p.SoundLocation = @".\remind.wav";
                p.Load();
                p.Play();
            }
        }
        
        public void SetPause()
        {
            p.Stop();
        }
    }
}
