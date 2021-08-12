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
        public HicSpeech hicVoice = new HicSpeech();
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
                    hicVoice.SpeakText(response); // The american voices read the date in mm/dd/yyyy, but the british ones read it in dd/mm/yyyy. Fix this given enough time.
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
                    try
                    {
                        ExternalProcess.Start();
                    }
                    catch (System.Exception)
                    {
                        hicVoice.SpeakText("Error: File not found.");
                        return ("Error: File not found.");
                    }
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
            else if(theme == "none")
            {
                if(number == 1) 
                { 
                    string answer = "I’m sorry, I don’t recognize that command, please try again.";
                    hicVoice.SpeakText(answer);
                    return (answer);
                }
            }
            return "";
            
            
        }

    }
}
