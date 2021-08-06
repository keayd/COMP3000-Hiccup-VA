﻿using System;
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
    
    public partial class MainWindow : Form
    {
        
        SettingsForm settings = new SettingsForm();
        public HicSpeech hicVoice = new HicSpeech();
        WebForm webForm = new WebForm();
        Responses responses = new Responses();

        public MainWindow()
        {
            
            InitializeComponent();
            
        }

       

        async void listenButton_Click(object sender, EventArgs e)
        {
            
            string question = typeBox.Text;
            speakBox.Text = "";

            string reply = (ProcessInputs.Interpreter.match_input(question)).ToString();
            
            if(reply.Any(char.IsDigit))
            {
                string a = String.Join("", reply.Where(char.IsDigit));
                int number = System.Convert.ToInt32(a);
                if (a != null)
                {
                    reply = reply.TrimEnd(a[0]);
                    responses.originalQuery = question;
                    reply = responses.InterpretQuestion(reply, number);

                }

            }
            else
            {
                hicVoice.SpeakText(reply);
                
            }
            

            speakBox.AppendText(reply);
        }
        

        private void SpeakButton_Click(object sender, EventArgs e)
        {
            string textToSpeak = speakBox.Text;
            hicVoice.SpeakText(textToSpeak);

        }
        private void settingsButton_Click(object sender, EventArgs e)
        {

            
            settings.ShowDialog();


        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            hicVoice.PauseSpeaking();
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            hicVoice.ResumeSpeaking();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            hicVoice.StopSpeaking();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void typeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void speakBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
