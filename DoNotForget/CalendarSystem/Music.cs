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
        public Music() { }

        public void SetMusic(int index) {

            switch (index) {
                case 1:
                    p.SoundLocation = @".\GONTITI (ゴンチチ) - 見知らぬ人 [mqms].wav";
                    break;
                case 2:
                    p.SoundLocation = @".\Coldplay - Yellow.wav";
                    break;
                case 3:
                    p.SoundLocation = @".\Bruno Mars - 24K Magic [mqms2].wav";
                    break;
                
                default:
                    return;
            }
            p.Load();
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
