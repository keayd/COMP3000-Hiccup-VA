using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Speech.Synthesis;


namespace Hiccup_Virtual_Assistant
{
    public class HicSpeech
    {
        //public SpeechConfig speechConfig;
        public SpeechSynthesizer hicVoice;
        bool isSpeaking = false;
        private string currentVoice = "Microsoft David Desktop";
        private int currentRate = 0;
        private int currentVolume = 50;
        

        public HicSpeech()
        {
            InitializeHicSpeech();
            newHicVoice();
            
            
        }
        /*
        public async Task<string> FromMic(SpeechConfig speechConfig)
        {
            var audioConfig = AudioConfig.FromDefaultMicrophoneInput();
            var recognizer = new SpeechRecognizer(speechConfig, audioConfig);
            var result = await recognizer.RecognizeOnceAsync();
            return result.Text;
        }
        */
        public void SpeakText(string TextToSpeak)
        {
            isSpeaking = true;
            hicVoice.SpeakAsync(TextToSpeak);

        }

        public void PauseSpeaking()
        {
            if (isSpeaking == true)
            {
                hicVoice.Pause();
                isSpeaking = false;
            }
        }

        public void ResumeSpeaking()
        {
            if (isSpeaking == false)
            {
                hicVoice.Resume();
                
            }
            isSpeaking = true;
        }

        public void StopSpeaking()
        {
            if (isSpeaking == true)
            {
                hicVoice.Dispose();
                isSpeaking = false;
                newHicVoice();
            }
            
        }

        private void newHicVoice()
        {
            hicVoice = new SpeechSynthesizer();
            hicVoice.SelectVoice(currentVoice);
            hicVoice.Rate = currentRate;
            hicVoice.Volume = currentVolume;

        }

        public void ChangeVoice(string voice)
        {
            hicVoice.SelectVoice(voice);
            currentVoice = voice; // This is for when the speech synthesizer is disposed and a new one takes its place, so that the same settings remain.
            
        }

        public void ChangeVolume(int volume)
        {
            hicVoice.Volume = volume;
            currentVolume = volume; // This is for when the speech synthesizer is disposed and a new one takes its place, so that the same settings remain.

        }

        public void ChangeRate(int rate)
        {
            hicVoice.Rate = rate;
            currentRate = rate; // This is for when the speech synthesizer is disposed and a new one takes its place, so that the same settings remain.
        }

        private void InitializeHicSpeech()
        {
            
            //speechConfig = SpeechConfig.FromSubscription("daba658c554947eca9afec43d0cc9e5e", "uksouth");
            //speechConfig.SpeechSynthesisVoiceName = "en-GB-RyanNeural";
            //speechConfig.SpeechSynthesisVoiceName = "en-AU-Catherine";
            //Microsoft.CognitiveServices.Speech.SpeechSynthesizer hicVoice = new Microsoft.CognitiveServices.Speech.SpeechSynthesizer(speechConfig);
            
        }
       
        

    }
}
