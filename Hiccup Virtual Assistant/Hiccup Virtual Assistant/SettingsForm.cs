using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Hiccup_Virtual_Assistant
{
    public partial class SettingsForm : Form
    {
        
        private SpeechSynthesizer installVoices = new SpeechSynthesizer();
        public HicSpeech setHicVoice;
        
        public SettingsForm()
        {
           
            InitializeComponent();
            AddInstalledVoices();

        }

        private void AddInstalledVoices()
        {
            foreach(InstalledVoice voice in installVoices.GetInstalledVoices())
            {
                VoiceInfo info = voice.VoiceInfo;
                voiceSelectorList.Items.Add(info.Name);
            }

        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            

        }

        public void voiceSelectorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var voice = voiceSelectorList.SelectedItem.ToString();
            if (voice != null)
            {
                setHicVoice.ChangeVoice(voice);
                
            }
            

        }

        private void voiceSpeedBar_Scroll(object sender, EventArgs e)
        {
            int rate = voiceSpeedBar.Value;
            setHicVoice.ChangeRate(rate);
        }

        private void voiceVolumeBar_Scroll(object sender, EventArgs e)
        {
            int volume = voiceVolumeBar.Value;
            setHicVoice.ChangeVolume(volume);
        }
    }
}
