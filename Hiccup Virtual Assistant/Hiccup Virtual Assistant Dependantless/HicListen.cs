using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;

namespace Hiccup_Virtual_Assistant
{
    public class HicListen
    {

        SpeechRecognitionEngine hicListen = new SpeechRecognitionEngine();
        DictationGrammar dictgram = new DictationGrammar();

        public HicListen()
        {
            hicListen.LoadGrammar(dictgram);
            hicListen.SetInputToDefaultAudioDevice();
            
        }

        
        
        public string ListenFromMic()
        {


            string response = "";
            RecognitionResult wordsRecognized = hicListen.Recognize();
            if (wordsRecognized == null)
            {
                response = "Error: Unrecognized Sentence.";

            }
            else
            {
                response = wordsRecognized.Text;
            }
            return response;


            
        }
        

    }
}
