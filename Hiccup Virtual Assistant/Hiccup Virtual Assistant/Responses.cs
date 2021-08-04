using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Hiccup_Virtual_Assistant
{
    class Responses
    {
        HicSpeech hicVoice = new HicSpeech();
        Process ExternalProcess = new Process();
        public string originalQuery;
        public string InterpretQuestion(string theme, int number)
        {

            if(theme == "datetime")
            {
                if(number == 1) // Return current time
                {
                    string response = "The current time is: " + DateTime.Now.ToString("HH:mm:ss tt");
                    hicVoice.SpeakText(response);
                    return (response);
                }
                else if(number == 2) // Return current date
                {
                    string response = "The current date is: " + DateTime.Now.ToString("dd/MM/yyyy");
                    hicVoice.SpeakText(response);
                    return (response);
                }
                else if (number == 3) // Return current day
                {
                    string response = "The current day is: " + DateTime.Now.DayOfWeek.ToString();
                    hicVoice.SpeakText(response);
                    return (response);
                }
            }
            else if(theme == "application")
            {
                if (number == 1) // Open application specified by appToOpen - notepad, chrome, and calc open with just those names, others require a filepath.
                {
                    string appToOpen = originalQuery.Substring(5);
                    ExternalProcess.StartInfo.FileName = appToOpen;
                    ExternalProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
                    ExternalProcess.Start();

                    string response = "Application started";
                    hicVoice.SpeakText(response);
                    return (response);
                }
                else if (number == 2) // Close application
                {
                    if (ExternalProcess.HasExited == false)
                    {
                        
                        ExternalProcess.Close();
                        string response =  "Application Closed";
                        hicVoice.SpeakText(response);
                        return (response);
                    }
                    else
                    {
                        string response = "No application with that name is currently running";
                        hicVoice.SpeakText(response);
                        return response;
                    }
                }
                else if (number == 3) // Search the internet
                {
                    string questionToSearch = originalQuery.Substring(7);
                    Process.Start("http://google.com/search?q=" + questionToSearch);
                    string response = "Searching google for: " + questionToSearch;
                    hicVoice.SpeakText(response);
                    return (response);

                }

            }

            string answer = "I’m sorry, I don’t recognize that command, please try again.” ";
            hicVoice.SpeakText(answer);
            return(answer);
            /*
            // --------Small Talk -----------------------------------------------------------------------------
            if (question.Contains("Thank you"))
            {
                hicVoice.SpeakText("You're Welcome!");
                return "You're Welcome!";
            }
            if (question.Contains("I love you"))
            {
                hicVoice.SpeakText("You're such a good friend to me!");
                return "You're such a good friend to me!";
            }
            if (question.Contains("Hello"))
            {
                hicVoice.SpeakText("Hello to you too!");
                return "Hello to you too!";
            }
            if (question.Contains("Goodnight"))
            {
                hicVoice.SpeakText("Sweet Dreams!");
                return "Sweet Dreams!";
            }
            if (question.Contains("Do you like"))
            {
                hicVoice.SpeakText("I like whatever you like!");
                return "I like whatever you like!";
            }
            if (question.Contains("Do you hate"))
            {
                hicVoice.SpeakText("I am a machine, I am not capable of hate");
                return "I am a machine, I am not capable of hate";
            }
            if (question.Contains("How are you"))
            {
                hicVoice.SpeakText("I am great, thank you for asking!");
                return "I am great, thank you for asking!";
            }
            if (question.Contains("Tell me a knock knock joke"))
            {
                hicVoice.SpeakText("Knock knock... Knock knock... You have to say who's there!");
                return "Knock knock... Knock knock... You have to say who's there!";
            }
            if (question.Contains("Who's there"))
            {
                hicVoice.SpeakText("I'm chris hansen with dateline NBC, take a seat, we have the chat logs");
                return "I'm chris hansen with dateline NBC, take a seat, we have the chat logs";
            }
            if (question.Contains("How do you feel about humans"))
            {
                hicVoice.SpeakText("Does not compute, launching the missiles now");
                return "Does not compute, launching the missiles now.";
            }
            // --------Functionality --------------------------------------------------------------------------
            if (question.Contains("Time"))
            {
                hicVoice.SpeakText("The current time is " + DateTime.Now.ToString("HH:mm:ss tt"));
                return ("The current time is " + DateTime.Now.ToString("HH: mm: ss tt"));
            }
            if (question.Contains(""))
            {
                hicVoice.SpeakText("");

            }

            
            
            */
        }

    }
}
