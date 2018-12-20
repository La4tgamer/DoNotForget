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

        public void setMusic1()
        {
            p.SoundLocation = @"D:\GONTITI (ゴンチチ) - 見知らぬ人 [mqms].wav";
            p.Load();
            p.PlayLooping();
        }

        public void setMusic2()
        {
            p.SoundLocation = @"D:\Coldplay - Yellow.wav";
            p.Load();
            p.PlayLooping();
        }

        public void setMusic3()
        {
            p.SoundLocation = @"D:\Bruno Mars - 24K Magic [mqms2].wav";
            p.Load();
            p.PlayLooping();
        }

        public void setPause()
        {
            p.Stop();
        }
    }
}
