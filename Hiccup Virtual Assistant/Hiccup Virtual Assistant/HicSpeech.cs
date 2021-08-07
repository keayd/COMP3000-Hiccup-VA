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
        public SpeechSynthesizer hicVoice = new SpeechSynthesizer();
        bool isSpeaking = false;
        

        public HicSpeech()
        {
            InitializeHicSpeech();
            
            
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
        }

        public void ChangeVoice(string voice)
        {
            hicVoice.SelectVoice(voice);
            
        }

        public void ChangeVolume(int volume)
        {
            hicVoice.Volume = volume;

        }

        public void ChangeRate(int rate)
        {
            hicVoice.Rate = rate;
        }

        private void InitializeHicSpeech()
        {
            //Hello, would you like some beans? It is seven o'clock
            //speechConfig = SpeechConfig.FromSubscription("daba658c554947eca9afec43d0cc9e5e", "uksouth");
            //speechConfig.SpeechSynthesisVoiceName = "en-GB-RyanNeural";
            //speechConfig.SpeechSynthesisVoiceName = "en-AU-Catherine";
            //Microsoft.CognitiveServices.Speech.SpeechSynthesizer hicVoice = new Microsoft.CognitiveServices.Speech.SpeechSynthesizer(speechConfig);
            
        }
       
        

    }
}
