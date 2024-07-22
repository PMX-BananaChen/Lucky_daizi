using System;
using System.Collections.Generic;
using System.Text;
using System.Media;

namespace Lucky
{
    public class PublicClass
    {
        public void MusicPlayer(int state)
        {
            //加载音乐
            SoundPlayer Player = new SoundPlayer();
            Player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "Sound3.wav";
            if (state == 0)
            {
                Player.PlayLooping();
            }
            else if (state == 1)
            {
                Player.Stop();
            }

        }
    }

    public class PublicClassFinish
    {
        public void MusicPlayer(int state)
        {
            //加载音乐
            SoundPlayer Player = new SoundPlayer();
            Player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "finish.wav";
            if (state == 0)
            {
                Player.Play();
            }
            else if (state == 1)
            {
                Player.Stop();
            }

        }
    }
}
