using SpeechLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Lucky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SpeechVoiceSpeakFlags flag = SpeechVoiceSpeakFlags.SVSFlagsAsync;
            SpVoice voice = new SpVoice();
            voice.Voice = voice.GetVoices(string.Empty, string.Empty).Item(1);
            //Item(0)单词男声Sam
            //Item(1)单词男声Mike
            //Item(2)单词女声Mary
            //Item(3)中文发音，如果是英文，就依单词字母一个一个发音
            voice.Speak("欢迎黄漫漫获的本次特等奖", flag);










            //Type type = Type.GetTypeFromProgID("SAPI.SpVoice");

            //dynamic spVoice = Activator.CreateInstance(type);
            //spVoice.Speak("你好,欢迎使用 Congratulations to kyle for the special award.");





            //SpVoice voice = new SpVoice();
            //voice.Rate = -5; //语速,[-10,10]
            //voice.Volume = 100; //音量,[0,100]
            //voice.Voice = voice.GetVoices().Item(0); //语音库
            //voice.Speak("你好abcdefg");

        }


    }
}
