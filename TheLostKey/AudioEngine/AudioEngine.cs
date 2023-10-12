using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace TheLostKey.AudioEngine
{
    internal class AudioEngine
    {
        public static void PlaySound(string fileName)
        {
            using (var output = new WaveOutEvent())
            using (var player = new AudioFileReader(fileName))
            {
                output.Init(player);
                output.Play();
                while(output.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(500);
                }
            }

        }
    }
}
