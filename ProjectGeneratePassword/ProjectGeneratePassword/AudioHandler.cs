using NAudio.Wave;
using System;
using System.Threading;

namespace ProjectGeneratePassword
{   
    public static class AudioHandler
    {
        public static void PlaySound()
        {   
            // Modify file name to change audio that plays
            using (var audioFile = new AudioFileReader(@$"{Environment.CurrentDirectory}\..\..\../Audio/NoshFrog.mp3"))
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFile);
                outputDevice.Play();
                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
