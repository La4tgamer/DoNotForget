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

        public void SetMusic1()
        {
            p.SoundLocation = @".\GONTITI (ゴンチチ) - 見知らぬ人 [mqms].wav";
            p.Load();
            p.PlayLooping();
        }

        public void SetMusic2()
        {
            p.SoundLocation = @".\Coldplay - Yellow.wav";
            p.Load();
            p.PlayLooping();
        }

        public void SetMusic3()
        {
            p.SoundLocation = @".\Bruno Mars - 24K Magic [mqms2].wav";
            p.Load();
            p.PlayLooping();
        }

        public void SetPause()
        {
            p.Stop();
        }
    }
}
