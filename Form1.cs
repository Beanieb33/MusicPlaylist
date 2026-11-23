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

namespace MusicPlaylist
{
    public partial class Form1 : Form
    {
        public static void MusicPlayer()
        {
            string audioFilePath = @"C:\Users\ajbal\Documents\Comp Sci HND\Algorithms and Data Structures\2026-09-30\WorkingWithFileTypes\Exercise_4_Working_With_Audio_Files\bin\Debug\smooth_sound.wav";

            try
            {
                SoundPlayer player = new SoundPlayer(audioFilePath);

                player.Load();

                player.Play();

                Console.WriteLine("Playing audiofile: " + audioFilePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusicPlayer();
        }
    }
}
